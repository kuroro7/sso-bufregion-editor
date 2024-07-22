using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOBufRegionEditor {
    public class Data {
        private Header header;

        public int id;
        public BuffRegionType regionType;
        public float len;
        public float width;
        public float radius;
        public float heightLowerLimit;
        public float heightUpperLimit;
        public bool playerValid;
        public bool petValid;
        public bool diedRegion;
        public int skillEnter;
        public int skillLevelEnter;
        public int skillLeave;
        public int skillLevelLeave;
        public int maxCharacterNum;
        public int misteryousNumber;
        public Vector2 pos;

        // version 2
        public bool noRepeat = false;
        public int taskEnter = 0;
        public int taskLeave = 0;

        // version 3
        public bool monsterBornValid = true;

        // version 4
        public bool initValid = false;

        // when is polygon
        public int pointsCount;
        public List<Vector2> points;

        public Data(Header header) {
            this.header = header;
            points = new List<Vector2>();
            pos = new Vector2();
        }

        public void write(BinaryWriter writer) {
            writer.Write(id);
            writer.Write((int) regionType);
            writer.Write(len);
            writer.Write(width);
            writer.Write(radius);
            writer.Write(heightLowerLimit);
            writer.Write(heightUpperLimit);
            writer.Write(playerValid);
            writer.Write(petValid);
            writer.Write(diedRegion);
            writer.Write(skillEnter);
            writer.Write(skillLevelEnter);
            writer.Write(skillLeave);
            writer.Write(skillLevelLeave);
            writer.Write(maxCharacterNum);
            pos.write(writer);

            if (header.version > 1) {
                writer.Write(noRepeat);
                writer.Write(taskEnter);
                writer.Write(taskLeave);
            }

            if (header.version > 2) 
                writer.Write(monsterBornValid);

            if (header.version > 3)
                writer.Write(initValid);

            if (header.version > 4)
                writer.Write(misteryousNumber);

            if (regionType == BuffRegionType.BUF_REGION_POLYGON) {
                writer.Write((int)points.Count);
                foreach (var point in points)
                    point.write(writer);
            }
        }

        public void read(BinaryReader reader) {
            id = reader.ReadInt32();
            regionType = (BuffRegionType)reader.ReadInt32();
            len = reader.ReadSingle();
            width = reader.ReadSingle();
            radius = reader.ReadSingle();
            heightLowerLimit = reader.ReadSingle();
            heightUpperLimit = reader.ReadSingle();
            playerValid = reader.ReadBoolean();
            petValid = reader.ReadBoolean();
            diedRegion = reader.ReadBoolean();
            skillEnter = reader.ReadInt32();
            skillLevelEnter = reader.ReadInt32();
            skillLeave = reader.ReadInt32();
            skillLevelLeave = reader.ReadInt32();
            maxCharacterNum = reader.ReadInt32();
            pos.read(reader);

            if (header.version > 1) {
                noRepeat = reader.ReadBoolean();
                taskEnter = reader.ReadInt32();
                taskLeave = reader.ReadInt32();
            } 

            if (header.version > 2)
                monsterBornValid = reader.ReadBoolean();

            if (header.version > 3)
                initValid = reader.ReadBoolean();

            if (header.version > 4)
                misteryousNumber = reader.ReadInt32();

            if (regionType == BuffRegionType.BUF_REGION_POLYGON) {
                pointsCount = reader.ReadInt32();

                for (var i = 0; i < pointsCount; i++) {
                    Vector2 point = new Vector2();
                    point.read(reader);
                    points.Add(point);
                }
                    
            }
        }
    }
}
