using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;
using System.Reflection;


namespace Configurator
{

    public class Params
    {


        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int id { get; set; }
        public int date { get; set; }
        public int radio { get; set; }
        public Params()
        {

        }
        public Params(int x, int y, int z, int id, int date, int radio)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.id = id;
            this.date = date;
            this.radio = radio;
        }
        public String ToJson()
        {

            String s;
            s = "{" + "\"id\":" + id + "," + "\"x\":" + x + "," + "\"y\":" + y + "," + "\"z\":" + z + "," + "\"position\":" + radio + "," + "\"timestamp\":" + date + "," + "\"crc\":" + "}";
            Console.WriteLine(s);
            return s;
        }
        ///////
        ///////
        static byte[] HexToBytes(string input)
        {
            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }

        public PropertyInfo[] GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }





    }

    ///////////////

    public static class Crc16
    {

        const ushort polynomial = 0x8005;
        static readonly ushort[] table = new ushort[256];

        public static ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        static Crc16()
        {
            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }
    }



}