namespace LostArkLogger.Types
{
    public class ReadFlagBytes
    {
        public bool valid = false;
        internal ReadFlagBytes()
        {
            //Made for conditional structures
        }

        internal ReadFlagBytes(BitReader reader)
        {
            valid = true;
            Flag = reader.ReadByte();
            if ((Flag & 1) != 0)
                Unk1 = reader.ReadByte();
            if (((Flag >> 1) & 1) != 0)
                Unk2 = reader.ReadByte();
            if (((Flag >> 2) & 1) != 0)
                Unk3 = reader.ReadInt32();
            if (((Flag >> 3) & 1) != 0)
                Unk4 = reader.ReadInt32();
            if (((Flag >> 4) & 1) != 0)
                Unk5 = reader.ReadInt32();
            if (((Flag >> 5) & 1) != 0)
                Unk6 = reader.ReadBytes(3);
            if (((Flag >> 6) & 1) != 0)
                Unk7 = reader.ReadBytes(6);
        }

        public byte Flag { get; }
        public byte Unk1 { get; }
        public byte Unk2 { get; }
        public int Unk3 { get; }
        public int Unk4 { get; }
        public int Unk5 { get; }
        public byte[] Unk6 { get; }
        public byte[] Unk7 { get; }
    }
}