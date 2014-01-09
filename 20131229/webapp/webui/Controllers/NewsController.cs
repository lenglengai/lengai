using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using common.core;

namespace webui.Controllers
{
    public class NewsController : ApiController
    {
        protected bool _checkPacket(Packet nPacket)
        {
            SettingService settingService =
                __singleton<SettingService>._instance();
            return settingService._checkVersion(nPacket.m_tVersion);
        }
    }
}
