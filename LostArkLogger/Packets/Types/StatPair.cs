using System;
using System.Collections.Generic;

namespace LostArkLogger.Types
{
    public class StatPair
    {
        public bool valid = false;
        internal StatPair()
        {
            //Made for conditional structures
        }

        internal StatPair(BitReader reader)
        {
            num = reader.ReadUInt16();
            for (var i = 0; i < num; i++)
            {
                Value.Add(new ReadNBytesInt64(reader));
                StatType.Add(reader.ReadByte());
            }
        }
        public List<ReadNBytesInt64> Value = new List<ReadNBytesInt64>();
        public List<Byte> StatType = new List<Byte>();
        public UInt16 num;
    }
}