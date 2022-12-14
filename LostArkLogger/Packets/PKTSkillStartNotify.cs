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
            hasPitchRotation = reader.ReadByte();
            if(hasPitchRotation == 1)
            {
                PitchRotation = reader.ReadAngle();
            }
            hasAiStateId = reader.ReadByte();
            if(hasAiStateId == 1)
            {
                AiStateId = reader.ReadUInt32();
            }
            CurDirectionYaw = reader.ReadAngle();
            NewDirectionYaw = reader.ReadAngle();
            CurPosition = reader.ReadVector3F();
            AimTargetPosition = reader.ReadVector3F();
            SkillId = reader.ReadUInt32();
            hasUnk1_m = reader.ReadByte();
            if(hasUnk1_m == 1)
            {
                Unk1_m = reader.ReadInt32();
            }
            NewPosition = reader.ReadVector3F();
            SourceId = reader.ReadUInt64();
            SkillOptionData = new ReadFlagBytes(reader);
            SkillLevel = reader.ReadByte();
        }

        public byte hasPitchRotation { get; }
        public Angle PitchRotation { get; }
        public byte hasAiStateId { get; }
        public uint AiStateId { get; }
        public Angle CurDirectionYaw { get; }
        public Angle NewDirectionYaw { get; }
        public Vector3F CurPosition { get; }
        public Vector3F AimTargetPosition { get; }
        public uint SkillId { get; }
        public byte hasUnk1_m { get; }
        public int Unk1_m { get; }
        public Vector3F NewPosition { get; }
        public ulong SourceId { get; }
        public ReadFlagBytes SkillOptionData { get; } = new ReadFlagBytes();
        public byte SkillLevel { get; }
    }
}