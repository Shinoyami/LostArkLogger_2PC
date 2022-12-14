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
    public class PKTStatusEffectRemoveNotify
    {
        public PKTStatusEffectRemoveNotify(BitReader reader)
        {
            statusEffectIds = new StatusEffectIds(reader);
            Reason = reader.ReadByte();
            ObjectId = reader.ReadUInt64();
        }

        public StatusEffectIds statusEffectIds { get; } = new StatusEffectIds();
        public byte Reason { get; }
        public ulong ObjectId { get; }
    }
}