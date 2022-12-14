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
    public class PKTPartyLeaveResult
    {
        public PKTPartyLeaveResult(BitReader reader)
        {
            Name = new LostArkString(reader);
            PartyInstanceId = reader.ReadUInt32();
            PartyLeaveType = reader.ReadByte();
        }

        public LostArkString Name { get; } = new LostArkString();
        public uint PartyInstanceId { get; }
        public byte PartyLeaveType { get; }
    }
}