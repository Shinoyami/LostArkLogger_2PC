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
    public class UnpublishObject
    {
        public bool valid = false;
        internal UnpublishObject()
        {
            //Made for conditional structures
        }

        internal UnpublishObject(BitReader reader)
        {
            valid = true;
            UnpublishReason = reader.ReadByte();
            ObjectId = reader.ReadUInt64();
        }

        public byte UnpublishReason { get; }
        public ulong ObjectId { get; }
    }
}