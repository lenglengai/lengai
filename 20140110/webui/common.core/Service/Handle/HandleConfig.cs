using System.Collections.Generic;

namespace common.core
{
    public class HandleConfig : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mHandleTypes, "handleTypes");
        }

        public string _streamName() {
            return @"handleConfig";
        }

        public void _initHandle(HandleService nHandleService) {
            uint index = 1;
            foreach (HandleType i in mHandleTypes) {
                i._initHandle(nHandleService, ref index);
            }
        }

        public HandleConfig() {
            mHandleTypes = new List<HandleType>();
        }

        List<HandleType> mHandleTypes;
    }
}
