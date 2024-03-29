
/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) Under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You Under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed Under the License is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations Under the License.
==================================================================== */


namespace NPOI.HSSF.Record
{

    using NPOI.Util;
    using System;
    using System.Text;
    using System.IO;
    using System.Collections.Generic;

    /**
     * PaletteRecord - Supports custom palettes.
     * @author Andrew C. Oliver (acoliver at apache dot org)
     * @author Brian Sanders (bsanders at risklabs dot com) - custom palette editing
     * @version 2.0-pre
     */

    public class PaletteRecord
       : Record
    {
        public const short sid = 0x92;
        /** The standard size of an XLS palette */
        public static byte STANDARD_PALETTE_SIZE = (byte)56;
        /** The byte index of the first color */
        public static short FIRST_COLOR_INDEX = (short)0x8;

        
        private List<PColor> field_2_colors;

        public PaletteRecord()
        {
            PColor[] defaultPalette = CreateDefaultPalette();
            field_2_colors = new List<PColor>(defaultPalette.Length);
            for (int i = 0; i < defaultPalette.Length; i++)
            {
                field_2_colors.Add(defaultPalette[i]);
            }
        }

        /**
         * Constructs a PaletteRecord record and Sets its fields appropriately.
         * @param in the RecordInputstream to Read the record from
         */

        public PaletteRecord(RecordInputStream in1)
        {
            short field_1_numcolors = in1.ReadShort();
            field_2_colors = new List<PColor>(field_1_numcolors);
            for (int k = 0; k < field_1_numcolors; k++)
            {
                field_2_colors.Add(new PColor(in1));
            }
        }

        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();

            buffer.Append("[PALETTE]\n");
            buffer.Append("  numcolors     = ").Append(field_2_colors.Count)
                  .Append('\n');
            for (int k = 0; k < field_2_colors.Count; k++)
            {
                PColor c = (PColor)field_2_colors[k];
                buffer.Append("* colornum      = ").Append(k)
                      .Append('\n');
                buffer.Append(c.ToString());
                buffer.Append("/*colornum      = ").Append(k)
                      .Append('\n');
            }
            buffer.Append("[/PALETTE]\n");
            return buffer.ToString();
        }

        public override int Serialize(int offset, byte[] data)
        {
            LittleEndian.PutShort(data, 0 + offset, sid);
            LittleEndian.PutShort(data, 2 + offset, (short)(RecordSize - 4));
            LittleEndian.PutShort(data, 4 + offset, (short)field_2_colors.Count);
            for (int k = 0; k < field_2_colors.Count; k++)
            {
                PColor c = (PColor)field_2_colors[k];
                c.Serialize(data, (6 + offset + (k * 4)));
            }

            return RecordSize;
        }

        public override int RecordSize
        {
            get { return 4 + 2 + (field_2_colors.Count * 4); }
        }

        public override short Sid
        {
            get { return sid; }
        }

        /**
         * Returns the color value at a given index
         *
         * @return the RGB triplet for the color, or null if the specified index
         * does not exist
         */
        public byte[] GetColor(short byteIndex)
        {
            int i = byteIndex - FIRST_COLOR_INDEX;
            if (i < 0 || i >= field_2_colors.Count)
            {
                return null;
            }
            PColor color = (PColor)field_2_colors[i];
            return new byte[] { color.red, color.green, color.blue };
        }

        /**
         * Sets the color value at a given index
         *
         * If the given index Is greater than the current last color index,
         * then black Is Inserted at every index required to make the palette continuous.
         *
         * @param byteIndex the index to Set; if this index Is less than 0x8 or greater than
         * 0x40, then no modification Is made
         */
        public void SetColor(short byteIndex, byte red, byte green, byte blue)
        {
            int i = byteIndex - FIRST_COLOR_INDEX;
            if (i < 0 || i >= STANDARD_PALETTE_SIZE)
            {
                return;
            }
            while (field_2_colors.Count <= i)
            {
                field_2_colors.Add(new PColor((byte)0, (byte)0, (byte)0));
            }
            PColor custColor = new PColor(red, green, blue);
            field_2_colors[i] = custColor;
        }

        /**
         * Creates the default palette as PaletteRecord binary data
         *
         * @see org.apache.poi.hssf.model.Workbook#createPalette
         */
        private static PColor[] CreateDefaultPalette()
        {
            return new PColor[] {
                pc(0, 0, 0),
                pc(255, 255, 255),
                pc(255, 0, 0),
                pc(0, 255, 0),
                pc(0, 0, 255),
                pc(255, 255, 0),
                pc(255, 0, 255),
                pc(0, 255, 255),
                pc(128, 0, 0),
                pc(0, 128, 0),
                pc(0, 0, 128),
                pc(128, 128, 0),
                pc(128, 0, 128),
                pc(0, 128, 128),
                pc(192, 192, 192),
                pc(128, 128, 128),
                pc(153, 153, 255),
                pc(153, 51, 102),
                pc(255, 255, 204),
                pc(204, 255, 255),
                pc(102, 0, 102),
                pc(255, 128, 128),
                pc(0, 102, 204),
                pc(204, 204, 255),
                pc(0, 0, 128),
                pc(255, 0, 255),
                pc(255, 255, 0),
                pc(0, 255, 255),
                pc(128, 0, 128),
                pc(128, 0, 0),
                pc(0, 128, 128),
                pc(0, 0, 255),
                pc(0, 204, 255),
                pc(204, 255, 255),
                pc(204, 255, 204),
                pc(255, 255, 153),
                pc(153, 204, 255),
                pc(255, 153, 204),
                pc(204, 153, 255),
                pc(255, 204, 153),
                pc(51, 102, 255),
                pc(51, 204, 204),
                pc(153, 204, 0),
                pc(255, 204, 0),
                pc(255, 153, 0),
                pc(255, 102, 0),
                pc(102, 102, 153),
                pc(150, 150, 150),
                pc(0, 51, 102),
                pc(51, 153, 102),
                pc(0, 51, 0),
                pc(51, 51, 0),
                pc(153, 51, 0),
                pc(153, 51, 102),
                pc(51, 51, 153),
                pc(51, 51, 51),
            };
        }

        private static PColor pc(int r, int g, int b)
        {
            return new PColor(r, g, b);
        }
    }

    /**
     * PColor - element in the list of colors - consider it a "struct"
     */
    class PColor
    {
        public byte red;
        public byte green;
        public byte blue;
        public PColor(int red, int green, int blue)
        {
            this.red = (byte)red;
            this.green = (byte)green;
            this.blue = (byte)blue;
        }

          public PColor(RecordInputStream in1) {
            red = (byte)in1.ReadByte();
            green = (byte)in1.ReadByte();
            blue = (byte)in1.ReadByte();
            in1.ReadByte(); // unused
          }

        public void Serialize(byte[] data, int offset)
        {
            data[offset + 0] = red;
            data[offset + 1] = green;
            data[offset + 2] = blue;
            data[offset + 3] = 0;
        }

        public override String ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("  red           = ").Append(red & 0xff).Append('\n');
            buffer.Append("  green         = ").Append(green & 0xff).Append('\n');
            buffer.Append("  blue          = ").Append(blue & 0xff).Append('\n');
            return buffer.ToString();
        }
    }
}