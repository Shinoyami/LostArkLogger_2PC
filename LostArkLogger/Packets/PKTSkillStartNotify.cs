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
    public class PKTSkillStartNotify
    {
        public PKTSkillStartNotify(BitReader reader)
        {
            CurDirectionYaw = reader.ReadAngle();
            SkillId = reader.ReadUInt32();
            hasUnk1_m = reader.ReadByte();
            if(hasUnk1_m == 1)
            {
                Unk1_m = reader.ReadInt32();
            }
            NewDirectionYaw = reader.ReadAngle();
            SkillOptionData = new ReadFlagBytes(reader);
            CurPosition = reader.ReadVector3F();
            hasPitchRotation = reader.ReadByte();
            if(hasPitchRotation == 1)
            {
                PitchRotation = reader.ReadAngle();
            }
            SourceId = reader.ReadUInt64();
            hasAiStateId = reader.ReadByte();
            if(hasAiStateId == 1)
            {
                AiStateId = reader.ReadUInt32();
            }
            AimTargetPosition = reader.ReadVector3F();
            NewPosition = reader.ReadVector3F();
            Unk0_m = reader.ReadByte();
        }

        public Angle CurDirectionYaw { get; }
        public uint SkillId { get; }
        public byte hasUnk1_m { get; }
        public int Unk1_m { get; }
        public Angle NewDirectionYaw { get; }
        public ReadFlagBytes SkillOptionData { get; } = new ReadFlagBytes();
        public Vector3F CurPosition { get; }
        public byte hasPitchRotation { get; }
        public Angle PitchRotation { get; }
        public ulong SourceId { get; }
        public byte hasAiStateId { get; }
        public uint AiStateId { get; }
        public Vector3F AimTargetPosition { get; }
        public Vector3F NewPosition { get; }
        public byte Unk0_m { get; }
    }
}