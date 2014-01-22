﻿//<TunynetCopyright>
//------------------------------------------------------------------------------
// <copyright company="Tunynet">
//     Copyright (c) Tunynet Inc.  All rights reserved.
// </copyright> 
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace Spacebuilder.Iditu
{
    /// <summary>
    /// Url Routing注册
    /// </summary>
    public class UrlRoutingRegistration : AreaRegistration
    {
        private static readonly string ApplicationKey = IdituConfig.Instance().ApplicationKey;

        /// <summary>
        /// AreaName
        /// </summary>
        public override string AreaName
        {
            get { return ApplicationKey; }
        }

        /// <summary>
        /// 注册Area的Url路由数据
        /// </summary>
        /// <param name="context"></param>
        public override void RegisterArea(AreaRegistrationContext context)
        {
            string routeNamePrefix = ApplicationKey + "_";

            //对于IIS6.0默认配置不支持无扩展名的url
            string extensionForOldIIS = ".aspx";
            int iisVersion = 0;
            if (!int.TryParse(ConfigurationManager.AppSettings["IISVersion"], out iisVersion))
                iisVersion = 7;

            if (iisVersion >= 7)
                extensionForOldIIS = string.Empty;

            context.MapRoute(routeNamePrefix + "Channel_Index", "HelloWorld/{action}" + extensionForOldIIS,
                new { action = "Index", Controller = "ChannelHelloWorld", CurrentNavigationId = "109001001" });

        }
    }
}