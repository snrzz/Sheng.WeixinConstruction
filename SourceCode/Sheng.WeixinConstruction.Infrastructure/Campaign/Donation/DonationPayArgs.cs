﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2016
*
********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    public class DonationPayArgs
    {
        public Guid DomainId
        {
            get;
            set;
        }

        public string AppId
        {
            get;
            set;
        }

        public Guid CampaignId
        {
            get;
            set;
        }


        public Guid MemberId
        {
            get;
            set;
        }

        public string OpenId
        {
            get;
            set;
        }

        public Guid DonationLogId
        {
            get;set;
        }

        /// <summary>
        /// 微信支付金额 单位 分
        /// </summary>
        public int Fee
        {
            get;
            set;
        }

        /// <summary>
        /// 终端IP
        /// APP和网页支付提交用户端ip，Native支付填调用微信支付API的机器IP。
        /// spbill_create_ip
        /// </summary>
        public string SpbillCreateIp
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Contact
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }


    }

    public class DonationPayResult
    {
        /// <summary>
        /// 生成的微信支付订单Id
        /// </summary>
        public Guid? PayOrderId
        {
            get;
            set;
        }
    }
}
