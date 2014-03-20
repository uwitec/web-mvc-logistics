using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Trade.Models
{
    [Module("Trade")]
    public class trade_schedulerService : ServiceBase<trade_scheduler>
    {
       
    }

    public class trade_scheduler : ModelBase
    {
        [PrimaryKey]   
        public string JOBNO { get; set; }
        [PrimaryKey]   
        public short SNO { get; set; }
        public string SC_DRIVERCD { get; set; }
        public string SC_DRIVER { get; set; }
        public string SC_TRUCKCD { get; set; }
        public string SC_TRUCKNAME { get; set; }
        public string SC_FRAMECD { get; set; }
        public string SC_FRAMENO { get; set; }
        public string SC_DRIVERTEL { get; set; }
        public string SC_DISTANCEID { get; set; }
        public DateTime? SC_ONCNTDATE { get; set; }
        public DateTime? SC_STARTDATE { get; set; }
        public DateTime? SC_ARRIVEDATE { get; set; }
        public DateTime? SC_BACKDATE { get; set; }
        public DateTime? SC_INPORTDATE { get; set; }
        public string SC_ROUTENAME { get; set; }
        public string SC_STARTPLACE { get; set; }
        public string SC_MIDPOINTPLACE { get; set; }
        public string SC_GOALPLACE { get; set; }
        public decimal? SC_WEIGHTKMS { get; set; }
        public decimal? SC_LIGHTKMS { get; set; }
        public decimal? SC_ADDKMS { get; set; }
        public decimal? SC_GQF { get; set; }
        public decimal? SC_TRUCKFEE { get; set; }
        public decimal? SC_SHARE { get; set; }
        public decimal? SC_OILAMOUNT { get; set; }
        public decimal? SC_OILPRICE { get; set; }
        public string SC_DRIVERWAY { get; set; }
        public string SC_DRIVER1 { get; set; }
        public string SC_CHECK { get; set; }
        public DateTime? SC_CHECKDATE { get; set; }
        public string SC_SCHEDULER { get; set; }
        public DateTime? SC_SCHEDULERDATE { get; set; }
        public string SC_REMARK { get; set; }
        public DateTime? SC_COMPLETEDATE { get; set; }
        public string SC_EXCEPTIONOP { get; set; }
        public string JOBNOADD { get; set; }
        public short? SNOADD { get; set; }
        public string SC_BACKID { get; set; }
        public string SC_BACK { get; set; }
        public DateTime? SC_BOOKINGDOCK { get; set; }
        public DateTime? SC_BOOKINGINPORT { get; set; }
        public DateTime? SC_BOOKINGDOCKDATE { get; set; }
        public DateTime? SC_BOOKINGINPORTDATE { get; set; }
        public string SC_REPLYDOCK { get; set; }
        public string SC_REPLYINPORT { get; set; }
        public string SC_BACKTYPE { get; set; }
        public decimal? SC_ADDOIL { get; set; }
        public decimal? SC_OILSTOCK { get; set; }
        public DateTime? SC_OILADDTIME { get; set; }
        public DateTime? SC_GETLISTTIME { get; set; }
        public decimal? SC_PORTSETTLETIME { get; set; }
        public decimal? SC_REPAIRTIME { get; set; }
        public decimal? SC_DOCKSETTLETIME { get; set; }
        public decimal? SC_WEIGHT { get; set; }
        public string SC_TRAILERCD { get; set; }
        public string SC_TRAILER { get; set; }
        public string SC_TRUCKSNO { get; set; }
        public decimal? SC_MONTHOILSTOCK { get; set; }
        public decimal? SC_OILCOST { get; set; }
        public decimal? SC_ADDTRUCKFEE { get; set; }
        public decimal? SC_LIGHTOILRATE { get; set; }
        public decimal? SC_WEIGHTOILRATE { get; set; }
        public decimal? SC_TIRELOSS { get; set; }
        public string SC_WEIGHTTYPE { get; set; }
        public decimal? SC_STANDARDOIL { get; set; }
        public decimal? SC_YSWEIGHT { get; set; }
        public string SC_DRIVEWAY { get; set; }
        public string SC_TRAINSMAN { get; set; }
        public string SC_OILCOSTIMPORT { get; set; }
        public string SC_GQFIMPORT { get; set; }
        public string SC_TRUCKFEEIMPORT { get; set; }
        public string SC_SHAREIMPORT { get; set; }
        public string SC_GJFIMPORT { get; set; }
        public string SC_DXFIMPORT { get; set; }
        public string SC_XXFIMPORT { get; set; }
        public string SC_FQFIMPORT { get; set; }
        public string SC_MTFIMPORT { get; set; }
        public string SC_QTFIMPORT { get; set; }
        public short? sc_oilcost_ctisno { get; set; }
        public short? sc_gqf_ctisno { get; set; }
        public short? sc_truckfee_ctisno { get; set; }
        public short? sc_share_ctisno { get; set; }
        public short? SC_GJF_CTISNO { get; set; }
        public short? SC_DXF_CTISNO { get; set; }
        public short? SC_XXF_CTISNO { get; set; }
        public short? SC_FQF_CTISNO { get; set; }
        public short? SC_MTF_CTISNO { get; set; }
        public short? SC_QTF_CTISNO { get; set; }
        public decimal? SC_GJF { get; set; }
        public decimal? SC_DXF { get; set; }
        public decimal? SC_XXF { get; set; }
        public decimal? SC_FQF { get; set; }
        public decimal? SC_MTF { get; set; }
        public decimal? SC_QTF { get; set; }
    }
}