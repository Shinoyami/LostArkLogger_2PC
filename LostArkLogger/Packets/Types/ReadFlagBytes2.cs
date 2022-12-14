namespace LostArkLogger.Types
{
    public class ReadFlagBytes2
    {
        public bool valid = false;
        internal ReadFlagBytes2()
        {
            //Made for conditional structures
        }

        internal ReadFlagBytes2(BitReader reader)
        {
            valid = true;
            Flag = reader.ReadByte();
            if ((Flag & 1) != 0)
                Unk1 = reader.ReadInt32();
            if (((Flag >> 1) & 1) != 0)
                Unk2 = reader.ReadInt32();
            if (((Flag >> 2) & 1) != 0)
                Unk3 = reader.ReadInt32();
            if (((Flag >> 3) & 1) != 0)
                Unk4 = reader.ReadInt32();
            if (((Flag >> 4) & 1) != 0)
                Unk5 = reader.ReadInt32();
            if (((Flag >> 5) & 1) != 0)
                Unk6 = reader.ReadInt32();
            if (((Flag >> 6) & 1) != 0)
            {
                Unk7_size = reader.ReadInt16();
                if (Unk7_size <= 6)
                    Unk7 = reader.ReadBytes(Unk7_size);
            }
        }

        public byte Flag { get; }
        public int Unk1 { get; }
        public int Unk2 { get; }
        public int Unk3 { get; }
        public int Unk4 { get; }
        public int Unk5 { get; }
        public int Unk6 { get; }
        public short Unk7_size { get; }
        public byte[] Unk7 { get; }
    }
}