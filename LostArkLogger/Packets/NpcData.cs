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
    public class NpcData
    {
        public bool valid = false;
        internal NpcData()
        {
            //Made for conditional structures
        }

        internal NpcData(BitReader reader)
        {
            valid = true;
            Unk0 = reader.ReadByte();
            if(Unk0 == 1)
            {
                Unk0_0 = reader.ReadByte();
            }
            Unk1 = reader.ReadByte();
            statusEffectDatas = new StatusEffectDatas(reader);
            Unk3 = reader.ReadInt16();
            statPair = new StatPair(reader);
            SpawnIndex = reader.ReadInt32();
            Unk6 = reader.ReadByte();
            if(Unk6 == 1)
            {
                Unk6_0 = new Struct_673(reader);
            }
            Unk7 = reader.ReadByte();
            if(Unk7 == 1)
            {
                Unk7_0 = reader.ReadInt16();
            }
            Unk8 = reader.ReadByte();
            if(Unk8 == 1)
            {
                Unk8_0 = reader.ReadByte();
            }
            Unk9 = reader.ReadByte();
            if(Unk9 == 1)
            {
                Unk9_0 = reader.ReadInt16();
            }
            Unk10 = reader.ReadByte();
            Unk11 = reader.ReadByte();
            if(Unk11 == 1)
            {
                Unk11_0 = reader.ReadInt32();
            }
            ObjectId = reader.ReadUInt64();
            Unk13 = reader.ReadByte();
            if(Unk13 == 1)
            {
                Unk13_0 = reader.ReadByte();
            }
            Position = reader.ReadVector3F();
            Unk15 = reader.ReadByte();
            if(Unk15 == 1)
            {
                Unk15_0 = reader.ReadInt32();
            }
            Unk16 = reader.ReadByte();
            if(Unk16 == 1)
            {
                Unk16_0 = reader.ReadByte();
            }
            Unk17 = reader.ReadByte();
            Unk18 = reader.ReadByte();
            DirectionYaw = reader.ReadAngle();
            Unk20 = reader.ReadByte();
            if(Unk20 == 1)
            {
                Unk20_0 = new Struct_249(reader);
            }
            Unk21 = reader.ReadByte();
            if(Unk21 == 1)
            {
                Unk21_0 = reader.ReadInt64();
            }
            Unk22 = reader.ReadByte();
            if(Unk22 == 1)
            {
                Unk22_0 = reader.ReadByte();
            }
            Unk23 = reader.ReadByte();
            if(Unk23 == 1)
            {
                Unk23_0 = reader.ReadInt32();
            }
            Unk24 = reader.ReadByte();
            TypeId = reader.ReadUInt32();
            Unk26 = new Struct_370(reader);
            Unk27 = reader.ReadByte();
            if(Unk27 == 1)
            {
                Unk27_0 = reader.ReadByte();
            }
            Unk28 = reader.ReadByte();
            if(Unk28 == 1)
            {
                Unk28_0 = new Struct_316(reader);
            }
            Unk29 = reader.ReadByte();
            if(Unk29 == 1)
            {
                Unk29_0 = reader.ReadInt32();
            }
            Unk30 = reader.ReadByte();
            if(Unk30 == 1)
            {
                Unk30_0 = reader.ReadByte();
            }
            Unk31 = reader.ReadByte();
            hasTransitIndex = reader.ReadByte();
            if(hasTransitIndex == 1)
            {
                TransitIndex = reader.ReadUInt32();
            }
        }

        public byte Unk0 { get; }
        public byte Unk0_0 { get; }
        public byte Unk1 { get; }
        public StatusEffectDatas statusEffectDatas { get; } = new StatusEffectDatas();
        public short Unk3 { get; }
        public StatPair statPair { get; } = new StatPair();
        public int SpawnIndex { get; }
        public byte Unk6 { get; }
        public Struct_673 Unk6_0 { get; } = new Struct_673();
        public byte Unk7 { get; }
        public short Unk7_0 { get; }
        public byte Unk8 { get; }
        public byte Unk8_0 { get; }
        public byte Unk9 { get; }
        public short Unk9_0 { get; }
        public byte Unk10 { get; }
        public byte Unk11 { get; }
        public int Unk11_0 { get; }
        public ulong ObjectId { get; }
        public byte Unk13 { get; }
        public byte Unk13_0 { get; }
        public Vector3F Position { get; }
        public byte Unk15 { get; }
        public int Unk15_0 { get; }
        public byte Unk16 { get; }
        public byte Unk16_0 { get; }
        public byte Unk17 { get; }
        public byte Unk18 { get; }
        public Angle DirectionYaw { get; }
        public byte Unk20 { get; }
        public Struct_249 Unk20_0 { get; } = new Struct_249();
        public byte Unk21 { get; }
        public long Unk21_0 { get; }
        public byte Unk22 { get; }
        public byte Unk22_0 { get; }
        public byte Unk23 { get; }
        public int Unk23_0 { get; }
        public byte Unk24 { get; }
        public uint TypeId { get; }
        public Struct_370 Unk26 { get; } = new Struct_370();
        public byte Unk27 { get; }
        public byte Unk27_0 { get; }
        public byte Unk28 { get; }
        public Struct_316 Unk28_0 { get; } = new Struct_316();
        public byte Unk29 { get; }
        public int Unk29_0 { get; }
        public byte Unk30 { get; }
        public byte Unk30_0 { get; }
        public byte Unk31 { get; }
        public byte hasTransitIndex { get; }
        public uint TransitIndex { get; }
    }
}