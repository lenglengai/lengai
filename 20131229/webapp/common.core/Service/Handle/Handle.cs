using System.Threading;
using System.Collections.Generic;

namespace common.core
{
    public class Handle
    {
        public Handle(uint nIndex, uint nType) {
            mIndex = nIndex;
            mType = nType;
        }

        const string TAG = "Handle";
        uint mIndex;
        uint mType;
    }
}
