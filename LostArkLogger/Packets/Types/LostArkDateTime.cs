
using System;

namespace LostArkLogger.Types
{
    public class LostArkDateTime
    {
        public bool valid = false;
        internal LostArkDateTime()
        {
            //Made for conditional structures
        }
        public LostArkDateTime(BitReader reader)
        {
            //TODO: port full implementation js
            valid = true;
            var s = reader.ReadUInt16();
            if ((s & 0xfff) < 0x81f)
            {
                reader.SkipBits(-2 * 8);
                Value = reader.ReadUInt64();
            }
            else
                Value = (ulong)(s & 0xfff) | 0x11000;
        }
        public ulong Value { get; set; }
    }
}