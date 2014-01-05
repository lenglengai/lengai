using System.Collections.Generic;

namespace common.core
{
    public class HandleOption : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize) {
            nSerialize._serialize(ref mHandleTypes, "handleTypes");
        }

        public string _streamName() {
            return @"handleOption";
        }

        public void _initHandle(HandleService nHandleService) {
            uint index = 1;
            foreach (HandleType i in mHandleTypes) {
                nHandleService._addHandleCount(i._getId(), i._getCount());
                ContextOption contextOption = i._getContextOption();
                for (byte j = 0; j < i._getCount(); ++j) {
                    Handle handle = new Handle(index, i._getType());
                    contextOption._initHandle(handle);
                    nHandleService._addHandle(index, handle);
                    ++index;
                }
            }
        }

        public HandleOption() {
            mHandleTypes = new List<HandleType>();
        }

        List<HandleType> mHandleTypes;
    }
}
