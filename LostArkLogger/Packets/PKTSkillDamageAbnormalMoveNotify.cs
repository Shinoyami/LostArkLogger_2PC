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
    public class PKTSkillDamageAbnormalMoveNotify
    {
        public PKTSkillDamageAbnormalMoveNotify(BitReader reader)
        {
            SkillEffectId = reader.ReadUInt32();
            SourceId = reader.ReadUInt64();
            SkillDamageAbnormalMoveEvents = new SkillDamageAbnormalMoveEvents(reader);
            SkillId = reader.ReadUInt32();
            Unk1_m = reader.ReadByte();
            Unk2_m = reader.ReadUInt32();
        }

        public uint SkillEffectId { get; }
        public ulong SourceId { get; }
        public SkillDamageAbnormalMoveEvents SkillDamageAbnormalMoveEvents { get; } = new SkillDamageAbnormalMoveEvents();
        public uint SkillId { get; }
        public byte Unk1_m { get; }
        public uint Unk2_m { get; }
    }
}