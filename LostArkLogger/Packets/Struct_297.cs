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
    public class Struct_297
    {
        public bool valid = false;
        internal Struct_297()
        {
            //Made for conditional structures
        }

        internal Struct_297(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 9)
            {
                for(var i = 0; i < Unk0; i++)
                {
                    struct_637.Add(new Struct_637(reader));
                }
            }
        }

        public short Unk0 { get; }
        public List<Struct_637> struct_637 { get; } = new List<Struct_637>();
    }
}