//<TunynetCopyright>
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
using Tunynet.Common;
using Tunynet.UI;

namespace Spacebuilder.Iditu.Controllers
{

    [Themed(PresentAreaKeysOfBuiltIn.Channel, IsApplication = true)]
    [TitleFilter(IsAppendSiteName = true)]
    public class ChannelIdituController : Controller
    {

        /// <summary>
        /// 主页
        /// </summary>
        public ActionResult Home()
        {
            return View();
        }
    }
}
