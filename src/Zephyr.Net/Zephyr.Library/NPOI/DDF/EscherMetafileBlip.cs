/*
* Licensed to the Apache Software Foundation (ASF) under one or more
* contributor license agreements.  See the NOTICE file distributed with
* this work for Additional information regarding copyright ownership.
* The ASF licenses this file to You under the Apache License, Version 2.0
* (the "License"); you may not use this file except in compliance with
* the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
namespace NPOI.DDF
{
    using System;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Drawing;
    using NPOI.Util;
    using Ionic.Zlib;

    /// <summary>
    /// @author Daniel Noll
    /// </summary>
    public class EscherMetafileBlip:EscherBlipRecord
    {
        private static POILogger log = POILogFactory.GetLogger(typeof(EscherMetafileBlip));

        public const short RECORD_ID_EMF = unchecked((short) 0xF018) + 2;
        public const short RECORD_ID_WMF = unchecked((short)0xF018) + 3;
        public const short RECORD_ID_PICT = unchecked((short)0xF018) + 4;

        /**
         * BLIP signatures as defined in the escher spec
         */
        public const short SIGNATURE_EMF = 0x3D40;
        public const short SIGNATURE_WMF = 0x2160;
        public const short SIGNATURE_PICT = 0x5420;

        private const int HEADER_SIZE = 8;

        private byte[] field_1_UID;
        /**
         * The primary UID is only saved to disk if (blip_instance ^ blip_signature == 1)
         */
        private byte[] field_2_UID;
        private int field_2_cb;
        private int field_3_rcBounds_x1;
        private int field_3_rcBounds_y1;
        private int field_3_rcBounds_x2;
        private int field_3_rcBounds_y2;
        private int field_4_ptSize_w;
        private int field_4_ptSize_h;
        private int field_5_cbSave;
        private byte field_6_fCompression;
        private byte field_7_fFilter;

        private byte[] raw_pictureData;

        /// <summary>
        /// This method deSerializes the record from a byte array.
        /// </summary>
        /// <param name="data">The byte array containing the escher record information</param>
        /// <param name="offset">The starting offset into</param>
        /// <param name="recordFactory">May be null since this is not a container record.</param>
        /// <returns>
        /// The number of bytes Read from the byte array.
        /// </returns>
        public override int FillFields( byte[] data, int offset, EscherRecordFactory recordFactory )
        {
            int bytesAfterHeader = ReadHeader( data, offset );
            int pos = offset + HEADER_SIZE;

            field_1_UID = new byte[16];
            Array.Copy( data, pos, field_1_UID, 0, 16 ); pos += 16;

            if((Options ^ Signature) == 0x10){
                field_2_UID = new byte[16];
                Array.Copy( data, pos, field_2_UID, 0, 16 ); pos += 16;
            }

            field_2_cb = LittleEndian.GetInt( data, pos ); pos += 4;
            field_3_rcBounds_x1 = LittleEndian.GetInt( data, pos ); pos += 4;
            field_3_rcBounds_y1 = LittleEndian.GetInt( data, pos ); pos += 4;
            field_3_rcBounds_x2 = LittleEndian.GetInt( data, pos ); pos += 4;
            field_3_rcBounds_y2 = LittleEndian.GetInt( data, pos ); pos += 4;
            field_4_ptSize_w = LittleEndian.GetInt( data, pos ); pos += 4;
            field_4_ptSize_h = LittleEndian.GetInt( data, pos ); pos += 4;
            field_5_cbSave = LittleEndian.GetInt( data, pos ); pos += 4;
            field_6_fCompression = data[pos]; pos++;
            field_7_fFilter = data[pos]; pos++;

            raw_pictureData = new byte[field_5_cbSave];
            Array.Copy( data, pos, raw_pictureData, 0, field_5_cbSave );

            // 0 means DEFLATE compression
            // 0xFE means no compression
            if (field_6_fCompression == 0)
            {
                field_pictureData = InflatePictureData(raw_pictureData);
            }
            else
            {
                field_pictureData = raw_pictureData;
            }

            return bytesAfterHeader + HEADER_SIZE;
        }

        /// <summary>
        /// Serializes the record to an existing byte array.
        /// </summary>
        /// <param name="offset">the offset within the byte array</param>
        /// <param name="data">the data array to Serialize to</param>
        /// <returns>the number of bytes written.</returns>
        public override int Serialize(int offset, byte[] data, EscherSerializationListener listener)
        {
            listener.BeforeRecordSerialize(offset, RecordId, this);

            int pos = offset;
            LittleEndian.PutShort( data, pos, Options ); pos += 2;
            LittleEndian.PutShort( data, pos, RecordId ); pos += 2;
            LittleEndian.PutInt( data, pos, RecordSize - HEADER_SIZE ); pos += 4;

            Array.Copy( field_1_UID, 0, data, pos, field_1_UID.Length ); pos += field_1_UID.Length;
            if((Options ^ Signature) == 0x10){
                Array.Copy( field_2_UID, 0, data, pos, field_2_UID.Length ); pos += field_2_UID.Length;
            }
            LittleEndian.PutInt( data, pos, field_2_cb ); pos += 4;
            LittleEndian.PutInt( data, pos, field_3_rcBounds_x1 ); pos += 4;
            LittleEndian.PutInt( data, pos, field_3_rcBounds_y1 ); pos += 4;
            LittleEndian.PutInt( data, pos, field_3_rcBounds_x2 ); pos += 4;
            LittleEndian.PutInt( data, pos, field_3_rcBounds_y2 ); pos += 4;
            LittleEndian.PutInt( data, pos, field_4_ptSize_w ); pos += 4;
            LittleEndian.PutInt( data, pos, field_4_ptSize_h ); pos += 4;
            LittleEndian.PutInt( data, pos, field_5_cbSave ); pos += 4;
            data[pos] = field_6_fCompression; pos++;
            data[pos] = field_7_fFilter; pos++;

            Array.Copy( raw_pictureData, 0, data, pos, raw_pictureData.Length );

            listener.AfterRecordSerialize(offset + RecordSize, RecordId, RecordSize, this);
            return RecordSize;
        }

        /// <summary>
        /// Decompresses the provided data, returning the inflated result.
        /// </summary>
        /// <param name="data">the deflated picture data.</param>
        /// <returns>the inflated picture data.</returns>
        private static byte[] InflatePictureData(byte[] data)
        {
            MemoryStream in1=null;
            MemoryStream out1=null;
            ZlibStream zIn = null;
            try
            {
                in1 = new MemoryStream(data);
                out1 = new MemoryStream();
                zIn = new ZlibStream(in1, CompressionMode.Decompress, true);

                byte[] buf = new byte[4096];
                int ReadBytes;
                while ((ReadBytes = zIn.Read(buf, 0, buf.Length)) > 0)
                {
                    out1.Write(buf, 0, ReadBytes);
                }
                return out1.ToArray();
            }
            catch (IOException e)
            {
                log.Log(POILogger.WARN, "Possibly corrupt compression or non-compressed data", e);
                return data;
            }
            finally
            {
                if (in1 != null)
                    in1.Close();
                if (out1 != null)
                    out1.Close();
            }
        }

        /// <summary>
        /// Returns the number of bytes that are required to Serialize this record.
        /// </summary>
        /// <value>Number of bytes</value>
        public override int RecordSize
        {
            get
            {
                int size = 8 + 50 + raw_pictureData.Length;
                if ((Options ^ Signature) == 0x10)
                {
                    size += field_2_UID.Length;
                }
                return size;
            }
        }

        /// <summary>
        /// Gets or sets the UID.
        /// </summary>
        /// <value>The UID.</value>
        public byte[] UID
        {
            get { return field_1_UID; }
            set { this.field_1_UID = value; }
        }

        /// <summary>
        /// Gets or sets the primary UID.
        /// </summary>
        /// <value>The primary UID.</value>
        public byte[] PrimaryUID
        {
            get{return field_2_UID;}
            set { this.field_2_UID = value; }
        }


        /// <summary>
        /// Gets or sets the size of the uncompressed.
        /// </summary>
        /// <value>The size of the uncompressed.</value>
        public int UncompressedSize
        {
            get { return field_2_cb; }
            set { field_2_cb = value; }
        }

        /// <summary>
        /// Gets or sets the bounds.
        /// </summary>
        /// <value>The bounds.</value>
        public Rectangle Bounds
        {
            get 
            {
                return new Rectangle(field_3_rcBounds_x1,
                                     field_3_rcBounds_y1,
                                     field_3_rcBounds_x2 - field_3_rcBounds_x1,
                                     field_3_rcBounds_y2 - field_3_rcBounds_y1);        
            }
            set
            {
                field_3_rcBounds_x1 = value.X;
                field_3_rcBounds_y1 = value.Y;
                field_3_rcBounds_x2 = value.X + value.Width;
                field_3_rcBounds_y2 = value.Y + value.Height;
            }
        }

        /// <summary>
        /// Gets or sets the size EMU.
        /// </summary>
        /// <value>The size EMU.</value>
        public Size SizeEMU
        {
            get{
                return new Size(field_4_ptSize_w, field_4_ptSize_h);
            }
            set 
            {
                field_4_ptSize_w = value.Width;
                field_4_ptSize_h = value.Height;
            }
        }

        /// <summary>
        /// Gets or sets the size of the compressed.
        /// </summary>
        /// <value>The size of the compressed.</value>
        public int CompressedSize
        {
            get{return field_5_cbSave;}
            set{field_5_cbSave=value;}
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is compressed.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is compressed; otherwise, <c>false</c>.
        /// </value>
        public bool IsCompressed
        {
            get{return (field_6_fCompression == 0);}
            set { field_6_fCompression = value ? (byte)0 : (byte)0xFE; }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override String ToString()
        {
            String nl = Environment.NewLine;

            String extraData;
            MemoryStream b = new MemoryStream();
            try
            {
                HexDump.Dump( this.field_pictureData, 0, b, 0 );
                extraData = b.ToString();
            }
            catch ( Exception e )
            {
                extraData = e.ToString();
            }
            return GetType().Name + ":" + nl +
                    "  RecordId: 0x" + HexDump.ToHex( RecordId ) + nl +
                    "  Options: 0x" + HexDump.ToHex( Options ) + nl +
                    "  UID: 0x" + HexDump.ToHex( field_1_UID ) + nl +
                    (field_2_UID == null ? "" : ("  UID2: 0x" + HexDump.ToHex( field_2_UID ) + nl)) +
                    "  Uncompressed Size: " + HexDump.ToHex( field_2_cb ) + nl +
                    "  Bounds: " + Bounds + nl +
                    "  Size in EMU: " + SizeEMU + nl +
                    "  Compressed Size: " + HexDump.ToHex( field_5_cbSave ) + nl +
                    "  Compression: " + HexDump.ToHex( field_6_fCompression ) + nl +
                    "  Filter: " + HexDump.ToHex( field_7_fFilter ) + nl +
                    "  Extra Data:" + nl + extraData;
        }

        /// <summary>
        /// Return the blip signature
        /// </summary>
        /// <value>the blip signature</value>
        public short Signature
        {
            get{
                short sig = 0;
                switch(RecordId){
                    case RECORD_ID_EMF: 
                        sig = SIGNATURE_EMF; 
                        break;
                    case RECORD_ID_WMF: 
                        sig = SIGNATURE_WMF; 
                        break;
                    case RECORD_ID_PICT: 
                        sig = SIGNATURE_PICT; 
                        break;
                    default: log.Log(POILogger.WARN, "Unknown metafile: " + RecordId); break;
                }
                return sig;
            }
        }
    }
}