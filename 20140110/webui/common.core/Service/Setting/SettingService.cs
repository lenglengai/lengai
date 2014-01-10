using System.IO;

namespace common.core
{
    public class SettingService : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mServerCount, "serverCount");
            nSerialize._serialize(ref mServerId, "serverId");
            nSerialize._serialize(ref mVersion, "version");
        }

        public string _streamName() {
            return "settingService";
        }

        public bool _checkServerId(uint nServerId) {
            return (mServerId == nServerId);
        }

        public void _setServerId(uint nServerId) {
            mServerId = nServerId;
        }

        public uint _getServerId() {
            return mServerId;
        }

        public void _setServerCount(uint nServerCount) {
            mServerCount = nServerCount;
        }

        public uint _getServerCount() {
            return mServerCount;
        }

        public bool _checkVersion(uint nVersion) {
            return (mVersion == nVersion);
        }

        public uint _getVersion() {
            return mVersion;
        }

        public void _runPreinit(string nPath = null) {
            mSystemPath = Path.Combine(nPath, @"bin");
            this._initConfig();
        }

        void _initConfig() {
            string streamName_ = this._streamName();
            string settingConfigUrl_ = @"Config/setting.xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(settingConfigUrl_);
            xmlReader_._selectStream(streamName_);
            this._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public string _systemPath() {
            return mSystemPath;
        }

        public SettingService() {
            mSystemPath = null;
            mServerCount = 0;
            mServerId = 0;
            mVersion = 0;
        }

        string mSystemPath;
        uint mServerCount;
        uint mServerId;
        uint mVersion;
    }
}
