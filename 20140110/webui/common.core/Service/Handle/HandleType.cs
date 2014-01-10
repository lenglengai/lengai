namespace common.core
{
    public class HandleType : IStream
    {
        public void _serialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mContext, "context");
            nSerialize._serialize(ref mCount, "count");
            nSerialize._serialize(ref mType, "type");
            nSerialize._serialize(ref mId, "id");
        }

        public void _initHandle(HandleService nHandleService, ref uint nIndex) {
            nHandleService._addHandleCount(mId, mCount);
            for (byte i = 0; i < mCount; ++i) {
                Handle handle = new Handle(nIndex, mType);
                this._initHandle(handle);
                nHandleService._addHandle(nIndex, handle);
                ++nIndex;
            }
        }

        void _initHandle(Handle nHandle)
        {
            ContextConfig contextConfig = new ContextConfig();
            this._initContext(contextConfig);
            contextConfig._initHandle(nHandle);
        }

        void _initContext(ContextConfig nContextConfig)
        {
            string contextConfigUrl_ = @"Config/";
            contextConfigUrl_ += mContext;
            contextConfigUrl_ += @"xml";
            XmlReader xmlReader_ = new XmlReader();
            xmlReader_._openUrl(contextConfigUrl_);
            string streamName_ = nContextConfig._streamName();
            xmlReader_._selectStream(streamName_);
            nContextConfig._headSerialize(xmlReader_);
            xmlReader_._runClose();
        }

        public string _getContext() {
            return mContext;
        }

        public byte _getCount() {
            return mCount;
        }

        public byte _getType() {
            return mType;
        }

        public uint _getId() {
            return mId;
        }

        public HandleType() {
            mContext = null;
            mCount = 0;
            mType = 0;
            mId = 0;
        }

        string mContext;
        byte mCount;
        byte mType;
        uint mId;
    }
}
