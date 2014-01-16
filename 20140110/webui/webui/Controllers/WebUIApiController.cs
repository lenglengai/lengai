using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using common.core;

namespace webui.Controllers
{
    public class WebUIApiController : ApiController
    {
        protected NewsMgr _checkPacket(Packet nPacket) {
            NewsMgr result_ = null;
            SettingService settingService = __singleton<SettingService>._instance();
            if (!settingService._checkVersion(nPacket.m_tVersion)) {
                result_ = new NewsMgr();
                VersionNews versionNews = new VersionNews();
                result_._addNews(versionNews);
            }
            return result_;
        }

        protected string _getMessage(NewsMgr nNewMgr) {
            JsonWriter jsonWriter = new JsonWriter();
            string streamName = nNewMgr._streamName();
            jsonWriter._selectStream(streamName);
            nNewMgr._headSerialize(jsonWriter);
            jsonWriter._runClose();
            return jsonWriter._getString();
        }
    }
}
