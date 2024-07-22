using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOBufRegionEditor {
    public class Header {
        public uint version;
        public int regionCount;
        public uint timestamp;

        public void read(BinaryReader reader) {
            version = reader.ReadUInt32();
            regionCount = reader.ReadInt32();
            timestamp = reader.ReadUInt32();
        }

        public void write(BinaryWriter writer) {
            writer.Write(version);
            writer.Write(regionCount);
            writer.Write(timestamp);
        }
    }


}
