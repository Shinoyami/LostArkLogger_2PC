/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArkLogger.Types;

namespace LostArkLogger
{
    public class PCIds
    {
        public bool valid = false;
        internal PCIds()
        {
            //Made for conditional structures
        }

        internal PCIds(BitReader reader)
        {
            valid = true;
            Count = reader.ReadUInt16();
            if(Count <= 40)
            {
                for(var i = 0; i < Count; i++)
                {
                    PCIdList.Add(reader.ReadUInt64());
                }
            }
        }

        public ushort Count { get; }
        public List<ulong> PCIdList { get; } = new List<ulong>();
    }
}