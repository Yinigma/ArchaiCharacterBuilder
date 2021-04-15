using Domain.Adapter;
using Domain.Entities;
using Domain.UseCase.SaveProjectToFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.InterfaceAdapters
{
    class ProjectFileLoader : IProjectLoader, IProjectWriter
    {
        enum ItemType : byte
        {
            GROUP,
            FIGHTER
        }

        enum PrimitiveType : byte
        {
            BYTE,
            UBYTE,
            SHORT,
            USHORT,
            INTEGER,
            UINTEGER,
            LONG,
            ULONG,
            CHAR,
            FLOAT,
            DOUBLE,
            STRING
        }


        public Project LoadProject(string uri)
        {
            Project project = new Project();
            using (FileStream stream = new FileStream(uri, FileMode.Open, FileAccess.Read))
            {
                int groupSize = (int) DeserializePrimitive(stream);
                while()
                {

                }
            }
        }

        public void SaveProject(Project project, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                List<ProjectItemGroup> groupQueue = new List<ProjectItemGroup>() { project.Root };
                while (groupQueue.Count > 0)
                {
                    if(groupQueue[0].Items.Count > int.MaxValue)
                    {
                        throw new GroupSizeExceededException();
                    }
                    stream.Write(BitConverter.GetBytes(groupQueue[0].Items.Count), 0, 4);
                    foreach (IProjectItem projectItem in groupQueue[0].Items)
                    {
                        if(projectItem is ProjectItemGroup)
                        {
                            groupQueue.Add(projectItem as ProjectItemGroup);
                        }
                        if(projectItem is Fighter)
                        {
                            Fighter fighter = projectItem as Fighter;
                            stream.Write(BitConverter.GetBytes(fighter.Id), 0, 8);
                            SerializePrimitive(fighter.Name, stream);
                            SerializePrimitive(fighter.GroundFriction, stream);
                            SerializePrimitive(fighter.MoonwalkAccel, stream);
                            SerializePrimitive(fighter.WalkAcceleration, stream);
                            SerializePrimitive(fighter.WalkSpeed, stream);
                            SerializePrimitive(fighter.WalkTurnTime, stream);
                            SerializePrimitive(fighter.WaveFriction, stream);
                            SerializePrimitive(fighter.WaveLandAdj, stream);
                            SerializePrimitive(fighter.WaveLandTime, stream);
                        }
                    }
                }
            }
        }

        public static object DeserializePrimitive(FileStream stream)
        {
            PrimitiveType type = (PrimitiveType) stream.ReadByte();
            switch(type)
            {
                case PrimitiveType.UBYTE:
                    return stream.ReadByte();
                case PrimitiveType.BYTE:
                    return stream.ReadByte();
                case PrimitiveType.USHORT:
                    byte[] ushortArr = new byte[2];
                    stream.Read(ushortArr, 0, 2);
                    return BitConverter.ToUInt16(ushortArr, 0);
                case PrimitiveType.SHORT:
                    byte[] shortArr = new byte[2];
                    stream.Read(shortArr, 0, 2);
                    return BitConverter.ToInt16(shortArr, 0);
                case PrimitiveType.UINTEGER:
                    byte[] uintArr = new byte[4];
                    stream.Read(uintArr, 0, 4);
                    return BitConverter.ToUInt32(uintArr, 0);
                case PrimitiveType.INTEGER:
                    byte[] intArr = new byte[4];
                    stream.Read(intArr, 0, 4);
                    return BitConverter.ToInt32(intArr, 0);
                case PrimitiveType.ULONG:
                    byte[] ulongArr = new byte[8];
                    stream.Read(ulongArr, 0, 8);
                    return BitConverter.ToUInt64(ulongArr, 0);
                case PrimitiveType.LONG:
                    byte[] longArr = new byte[8];
                    stream.Read(longArr, 0, 8);
                    return BitConverter.ToInt64(longArr, 0);
                case PrimitiveType.STRING:
                    byte[] lenArr = new byte[4];
                    stream.Read(lenArr, 0, 4);
                    int len = BitConverter.ToInt32(lenArr, 0);
                    byte[] strBytes = new byte[len];
                    stream.Read(strBytes, 0, len);
                    return Encoding.UTF8.GetString(strBytes);
                case PrimitiveType.CHAR:
                    byte[] charArr = new byte[2];
                    stream.Read(charArr, 0, 2);
                    return BitConverter.ToChar(charArr, 0);
                case PrimitiveType.FLOAT:
                    byte[] floatArr = new byte[4];
                    stream.Read(floatArr, 0, 4);
                    return BitConverter.ToSingle(floatArr, 0);
                case PrimitiveType.DOUBLE:
                    byte[] doubleArr = new byte[8];
                    stream.Read(doubleArr, 0, 8);
                    return BitConverter.ToDouble(doubleArr, 0);
                default:
                    return null;
            }
        }

        //TODO - handle endianness
        public static void SerializePrimitive(sbyte num, FileStream stream)
        {
            stream.WriteByte((byte) PrimitiveType.BYTE);
            stream.WriteByte((byte) num);
        }

        public static void SerializePrimitive(byte num, FileStream stream)
        {
            stream.WriteByte((byte) PrimitiveType.BYTE);
            stream.WriteByte(num);
        }

        public static void SerializePrimitive(short num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.SHORT);
            stream.Write(BitConverter.GetBytes(num), 0, 2);
        }

        public static void SerializePrimitive(ushort num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.USHORT);
            stream.Write(BitConverter.GetBytes(num), 0, 2);
        }

        public static void SerializePrimitive(int num, FileStream stream)
        {
            stream.WriteByte((byte) PrimitiveType.INTEGER);
            stream.Write(BitConverter.GetBytes(num), 0, 4);
        }

        public static void SerializePrimitive(uint num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.UINTEGER);
            stream.Write(BitConverter.GetBytes(num), 0, 4);
        }

        public static void SerializePrimitive(long num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.LONG);
            stream.Write(BitConverter.GetBytes(num), 0, 8);
        }

        public static void SerializePrimitive(ulong num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.ULONG);
            stream.Write(BitConverter.GetBytes(num), 0, 8);
        }

        public static void SerializePrimitive(float num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.FLOAT);
            stream.Write(BitConverter.GetBytes(num), 0, 4);
        }

        public static void SerializePrimitive(double num, FileStream stream)
        {
            stream.WriteByte((byte)PrimitiveType.DOUBLE);
            stream.Write(BitConverter.GetBytes(num), 0, 8);
        }

        private static void SerializePrimitive(string data, FileStream stream)
        {
            byte[] strBytes = Encoding.UTF8.GetBytes(data);
            stream.WriteByte((byte)PrimitiveType.STRING);
            stream.Write(BitConverter.GetBytes(strBytes.Length), 0, 8);
            stream.Write(strBytes, 0, strBytes.Length);
        }
    }
}
