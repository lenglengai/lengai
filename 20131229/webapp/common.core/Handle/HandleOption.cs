using System.Collections.Generic;

namespace common.core
{
    public class HandleOption : IHeadstream
    {
        public void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mHandleTypes, "handleTypes");
        }

        public string _streamName()
        {
            return @"handleOption";
        }

        public HandleOption() {
            mHandleTypes = new List<HandleType>();
        }

        List<HandleType> mHandleTypes;
    }
}
