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
    public class Struct_52
    {
        public bool valid = false;
        internal Struct_52()
        {
            //Made for conditional structures
        }

        internal Struct_52(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 152)
            {
                for(var i = 0; i < Unk0; i++)
                {
                    sub_Unk0_0.Add(new sub_Unk0(reader));
                }
            }
        }

        public short Unk0 { get; }
        public class sub_Unk0
        {
            public bool valid = false;
            internal sub_Unk0()
            {
                //Made for conditional structures
            }
            internal sub_Unk0(BitReader reader)
            {
                valid = true;
                Unk0_0_0 = new ReadNBytesInt64(reader);
                Unk0_0_1 = reader.ReadByte();
            }

            public ReadNBytesInt64 Unk0_0_0 { get; } = new ReadNBytesInt64();
            public byte Unk0_0_1 { get; }
        }
        public List<sub_Unk0> sub_Unk0_0 { get; } = new List<sub_Unk0>();
    }
}