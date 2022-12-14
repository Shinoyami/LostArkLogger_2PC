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
    public class UnpublishedObjects
    {
        public bool valid = false;
        internal UnpublishedObjects()
        {
            //Made for conditional structures
        }

        internal UnpublishedObjects(BitReader reader)
        {
            valid = true;
            Count = reader.ReadUInt16();
            if(Count <= 200)
            {
                for(var i = 0; i < Count; i++)
                {
                    previous.Add(new UnpublishObject(reader));
                }
            }
        }

        public ushort Count { get; }
        public List<UnpublishObject> previous { get; } = new List<UnpublishObject>();
    }
}