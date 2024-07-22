using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOBufRegionEditor {
    public class Vector2 {
        public float x;
        public float z;

        public void read(BinaryReader reader) {
            x = reader.ReadSingle();
            z = reader.ReadSingle();
        }

        public void write(BinaryWriter writer) {
            writer.Write(x);
            writer.Write(z);
        }
    }
}
