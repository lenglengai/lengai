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

        public void _runInit() {

        }

        public void _initHandle(HandleService nHandleService) {
            uint index = 1, count_ = 0;
            foreach (HandleType i in mHandleTypes) {
                count_ = i._getCount();
                nHandleService._addHandleCount(i._getId(), count_);
                for (byte j = 0; j < count_; ++j)
                {
                    Handle handle = new Handle(index, i._getType());
                    nHandleService._addHandle(index, handle);
                    ++index;
                }
            }
        }

        public HandleConfig() {
            mHandleTypes = new List<HandleType>();
        }

        List<HandleType> mHandleTypes;
    }
}
