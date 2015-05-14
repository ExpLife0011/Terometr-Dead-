﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sniffer.Tera
{
    public class TeraPacket
    {
        public Type type;
        public ushort size;
        public ushort opCode;
        public byte[] data;

        public TeraPacket(byte[] _data, Type _type)
        {
            data = (byte[])_data.Clone();
            size = BitConverter.ToUInt16(data, 0);//Размер
            opCode = BitConverter.ToUInt16(data, 2);//id пакета или OpCode
            type = _type;
        }
        public enum Type { Send, Recv }
    }
}