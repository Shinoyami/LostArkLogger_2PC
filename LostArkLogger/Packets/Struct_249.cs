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
    public class Struct_249
    {
        public bool valid = false;
        internal Struct_249()
        {
            //Made for conditional structures
        }

        internal Struct_249(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 12)
            {
                Unk0_0 = reader.ReadBytes(12*Unk0);
            }
        }

        public short Unk0 { get; }
        public byte[] Unk0_0 { get; }
    }
}