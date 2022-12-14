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
    public class ProjectileInfo
    {
        public bool valid = false;
        internal ProjectileInfo()
        {
            //Made for conditional structures
        }

        internal ProjectileInfo(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt32();
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadByte();
            if(Unk2 == 1)
            {
                Unk2_0 = reader.ReadInt64();
            }
            Unk3 = reader.ReadInt32();
            Unk4 = reader.ReadInt32();
            Unk5 = reader.ReadByte();
            Unk6 = reader.ReadInt64();
            ProjectileId = reader.ReadUInt64();
            SkillLevel = reader.ReadByte();
            Unk9 = reader.ReadInt16();
            Unk10 = reader.ReadByte();
            if(Unk10 == 1)
            {
                Unk10_0 = reader.ReadInt32();
            }
            Unk11 = reader.ReadByte();
            if(Unk11 == 1)
            {
                struct_316 = new Struct_316(reader);
            }
            Unk12 = reader.ReadInt64();
            Tripods = reader.ReadBytes(3);
            SkillId = reader.ReadUInt32();
            Unk15 = reader.ReadInt64();
            OwnerId = reader.ReadUInt64();
            Unk17 = reader.ReadBytes(6);
            Unk18 = reader.ReadInt16();
            SkillEffect = reader.ReadUInt32();
            Unk20 = reader.ReadByte();
        }

        public int Unk0 { get; }
        public int Unk1 { get; }
        public byte Unk2 { get; }
        public long Unk2_0 { get; }
        public int Unk3 { get; }
        public int Unk4 { get; }
        public byte Unk5 { get; }
        public long Unk6 { get; }
        public ulong ProjectileId { get; }
        public byte SkillLevel { get; }
        public short Unk9 { get; }
        public byte Unk10 { get; }
        public int Unk10_0 { get; }
        public byte Unk11 { get; }
        public Struct_316 struct_316 { get; } = new Struct_316();
        public long Unk12 { get; }
        public byte[] Tripods { get; }
        public uint SkillId { get; }
        public long Unk15 { get; }
        public ulong OwnerId { get; }
        public byte[] Unk17 { get; }
        public short Unk18 { get; }
        public uint SkillEffect { get; }
        public byte Unk20 { get; }
    }
}