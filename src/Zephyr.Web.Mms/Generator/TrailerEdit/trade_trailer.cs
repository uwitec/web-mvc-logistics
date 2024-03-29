﻿using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Web.Trade.Models
{
    [Module("Trade")]
    public class trade_trailerService : ServiceBase<trade_trailer>
    {
       
    }

    public class trade_trailer : ModelBase
    {
        [PrimaryKey]   
        public string JOBNO { get; set; }
        public string TR_JOBNOIN { get; set; }
        public string TR_KIND { get; set; }
        public string TR_LCLID { get; set; }
        public string TR_SELFID { get; set; }
        public string TR_IEID { get; set; }
        public string TR_SALERDEPART { get; set; }
        public string TR_BLNO { get; set; }
        public string TR_CONNO { get; set; }
        public string TR_SEALNO { get; set; }
        public string TR_CARRICD { get; set; }
        public string TR_CARRI { get; set; }
        public string TR_CARNO { get; set; }
        public DateTime? TR_ETSH { get; set; }
        public DateTime? TR_ENDCONDATE { get; set; }
        public string TR_TYPE { get; set; }
        public string TR_SPTYPE { get; set; }
        public string TR_STATUS { get; set; }
        public string TR_CONSTATUS { get; set; }
        public decimal? TR_WEIGHT { get; set; }
        public decimal? TR_MEAS { get; set; }
        public int? TR_PKGS { get; set; }
        public string TR_CARGONAME { get; set; }
        public string TR_CARGOKIND { get; set; }
        public string TR_CONSTAT { get; set; }
        public DateTime? TR_TRAILDATE { get; set; }
        public DateTime? TR_ORDERDATE { get; set; }
        public string TR_PAYPORT { get; set; }
        public string TR_DEST { get; set; }
        public string TR_PICKUPPORT { get; set; }
        public DateTime? TR_OUTPORTDATE { get; set; }
        public string TR_UNLOADPORT { get; set; }
        public DateTime? TR_INPORTDATE { get; set; }
        public string TR_TRAILERCD { get; set; }
        public string TR_TRAILER { get; set; }
        public string TR_SALER { get; set; }
        public string TR_SERVICE { get; set; }
        public string TR_SERVICETEL { get; set; }
        public string TR_OWNER { get; set; }
        public string TR_TRAILPLACECD { get; set; }
        public string TR_TRAILPLACE { get; set; }
        public string TR_TRAILPLACEDT { get; set; }
        public string TR_PAYCD { get; set; }
        public string TR_PAYER { get; set; }
        public string TR_PAYCTCNAME { get; set; }
        public string TR_PAYCTCTELO { get; set; }
        public string TR_PAYCTCFAX { get; set; }
        public string TR_AGENTCD { get; set; }
        public string TR_AGENTER { get; set; }
        public string TR_SHIPPCD { get; set; }
        public string TR_SHIPPER { get; set; }
        public string TR_FACTORYCD { get; set; }
        public string TR_FACTORY { get; set; }
        public string TR_CUSCTCNAME { get; set; }
        public string TR_CUSCTCTELO { get; set; }
        public string TR_CUSCTCFAX { get; set; }
        public string TR_FORWARDCD { get; set; }
        public string TR_FORWARDNAME { get; set; }
        public string TR_FWDCTCNAME { get; set; }
        public string TR_FWDCTCTELO { get; set; }
        public string TR_FWDCTCFAX { get; set; }
        public string TR_CANCELID { get; set; }
        public string TR_DRIVER { get; set; }
        public string TR_TRUCKNAME { get; set; }
        public string TR_FRAMENO { get; set; }
        public decimal? TR_FREIGHT { get; set; }
        public string TR_EXAMCUSID { get; set; }
        public string TR_BYPLATFORMID { get; set; }
        public string TR_TRANCUSID { get; set; }
        public string TR_ENDOPID { get; set; }
        public string TR_BOTHID { get; set; }
        public string TR_ENDDRIVERID { get; set; }
        public string TR_ENDCOSTID { get; set; }
        public string GETCONNOID { get; set; }
        public string TR_SCHEDULER { get; set; }
        public string TR_COSTMARK { get; set; }
        public string TR_REMARK { get; set; }
        public string TR_MODIBY { get; set; }
        public DateTime? TR_MODIDATE { get; set; }
        public string TR_CREATEBY { get; set; }
        public DateTime? TR_CREATEDATE { get; set; }
        public string ORGID { get; set; }
        public DateTime? TR_CONFIRMDATE { get; set; }
        public string tr_salerkind { get; set; }
        public string tr_eirno { get; set; }
        public string TR_CALFREIGHTTYPE { get; set; }
        public string TR_PAYWAYCD { get; set; }
        public string TR_STOWAGEPLACE { get; set; }
        public string TR_STOWAGEPLACEDT { get; set; }
        public string TR_CONSCD { get; set; }
        public string TR_CONSIGNEE { get; set; }
        public string TR_CONSCTCNAME { get; set; }
        public string TR_CONSCTCTELO { get; set; }
        public string TR_CONSCTCFAX { get; set; }
        public decimal? TR_PRICE { get; set; }
        public string TR_PLACED { get; set; }
        public DateTime? TR_STARTDATE { get; set; }
        public string TR_PROXYNO { get; set; }
        public string TR_TRANSPORT { get; set; }
        public string TR_BLNOMARK { get; set; }
        public string TR_DANGERKIND { get; set; }
        public string TR_UNCODE { get; set; }
        public string TR_BackRemark { get; set; }
        public string TR_TrailerRemark { get; set; }
        public string TR_EIRIN { get; set; }
        public string TR_ALLOTNO { get; set; }
        public string TR_STARTPORT { get; set; }
        public string TR_PUTCONID { get; set; }
        public string TR_PICKNAME { get; set; }
        public string TR_PICKCONID { get; set; }
        public string TR_INPORTBILLTYPE { get; set; }
        public string TR_WTPUTCONID { get; set; }
        public string TR_CY { get; set; }
        public string TR_PORTL { get; set; }
        public string TR_TRANSTRAILER { get; set; }
        public string TR_CARRI2 { get; set; }
        public string TR_CARNO2 { get; set; }
        public DateTime? TR_ETSH2 { get; set; }
        public string TR_CARRI3 { get; set; }
        public string TR_CARNO3 { get; set; }
        public DateTime? TR_ETSH3 { get; set; }
        public string TR_EXCEPTITEM { get; set; }
        public DateTime? TR_TRANSDATE { get; set; }
        public string TR_BLNO1 { get; set; }
        public DateTime? TR_ONCNTDATE { get; set; }
        public DateTime? TR_BACKCNTDATE { get; set; }
        public string TR_EXCEPTMARK { get; set; }
        public DateTime? TR_INSURANCEDATE { get; set; }
        public DateTime? TR_ARRIVEDATE { get; set; }
        public DateTime? TR_ARRIVEDATE1 { get; set; }
        public DateTime? TR_ARRIVEDATE2 { get; set; }
        public string TR_TRANSCUSNAME { get; set; }
        public string TR_VESSELCD { get; set; }
        public string TR_VESSELNAME { get; set; }
        public string TR_TAKECONID { get; set; }
        public string TR_TAKECONPLACE { get; set; }
        public string TR_TAKECONMARK { get; set; }
        public string TR_INSURANCENO { get; set; }
        public int? TR_CONCOUNT { get; set; }
        public string TR_TRANSKIND { get; set; }
        public string TR_LADINGFORM { get; set; }
        public decimal? TR_CARGOVALUE { get; set; }
        public string TR_EXPRESSNO { get; set; }
        public string TR_PICKTRAILERCD { get; set; }
        public string TR_PICKTRAILER { get; set; }
        public string TR_PICKDRIVERCD { get; set; }
        public string TR_PICKDRIVER { get; set; }
        public string TR_PICKTRUCKCD { get; set; }
        public string TR_PICKTRUCKNAME { get; set; }
        public string TR_PICKDRIVERTEL { get; set; }
        public string TR_TRANSDRIVERCD { get; set; }
        public string TR_TRANSDRIVER { get; set; }
        public string TR_TRANSTRUCKCD { get; set; }
        public string TR_TRANSTRUCKNAME { get; set; }
        public string TR_TRANSDRIVERTEL { get; set; }
        public DateTime? TR_PICKCARGODATE { get; set; }
        public DateTime? TR_TRUCKSTART { get; set; }
        public DateTime? TR_ETA { get; set; }
        public DateTime? TR_SENDCARGODATE { get; set; }
        public string TR_RETURNMARKS { get; set; }
        public DateTime? TR_RETURNDATE { get; set; }
        public string TR_ACCIDENTID { get; set; }
        public string TR_ACCIDENTMARKS { get; set; }
        public string TR_CANCELTYPE { get; set; }
        public string TR_ONLYID { get; set; }
        public DateTime? TR_BUSCHKDATE { get; set; }
        public string TR_BUSCHK { get; set; }
        public string TR_JOBNOADD { get; set; }
        public decimal? TR_LASTWEIGHT { get; set; }
        public string TR_FYBG { get; set; }
        public string TR_TSGID { get; set; }
    }
}