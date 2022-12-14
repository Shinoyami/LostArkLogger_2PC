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
    public class PKTTriggerFinishNotify
    {
        public PKTTriggerFinishNotify(BitReader reader)
        {
            InvolvedPCs = new PCIds(reader);
            TriggerId = reader.ReadUInt32();
            PacketResultCode = reader.ReadUInt32();
            Unk0_m = reader.ReadUInt32();
        }

        public PCIds InvolvedPCs { get; } = new PCIds();
        public uint TriggerId { get; }
        public uint PacketResultCode { get; }
        public uint Unk0_m { get; }
    }
}