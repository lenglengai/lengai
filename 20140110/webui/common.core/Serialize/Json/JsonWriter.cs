using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace common.core
{
    public class JsonWriter : ISerialize
    {
        public void _serialize(ref bool nValue, string nName, bool nOptimal = default(bool))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<sbyte> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (sbyte i in nValue) {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref byte nValue, string nName, byte nOptimal = default(byte))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<byte> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (byte i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref short nValue, string nName, short nOptimal = default(short))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<short> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (short i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref ushort nValue, string nName, ushort nOptimal = default(ushort))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<ushort> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (ushort i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref int nValue, string nName, int nOptimal = default(int))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<int> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (int i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref uint nValue, string nName, uint nOptimal = default(uint))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<uint> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (uint i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref long nValue, string nName, long nOptimal = default(long))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<long> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (long i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref ulong nValue, string nName, ulong nOptimal = default(ulong))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<ulong> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (ulong i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref string nValue, string nName, string nOptimal = default(string))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<string> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (string i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<DateTime> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (DateTime i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref float nValue, string nName, float nOptimal = default(float))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<float> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (float i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize(ref double nValue, string nName, double nOptimal = default(double))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void _serialize(ref List<double> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (double i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _serialize<__t>(ref __t nValue, string nName, __t nOptimal = default(__t)) where __t : IStream
        {
            if (null == nValue) return;
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartObject();
            nValue._serialize(this);
            mJsonTextWriter.WriteEndObject();
        }

        public void _serialize<__t>(ref List<__t> nValue, string nName) where __t : IStream
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartArray();
            foreach (__t i in nValue)
            {
                __t t_ = i;
                mJsonTextWriter.WriteStartObject();
                t_._serialize(this);
                mJsonTextWriter.WriteEndObject();
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void _openUrl(string nUrl)
        {
        }

        public string _getString()
        {
            string result = mStringBuilder.ToString();
            mStringBuilder.Clear();
            foreach (char i in result) {
                if ( (i != '\r') && (i != '\n')
                    && (i != ' ') && (i != '\t') )
                {
                    mStringBuilder.Append(i);
                }
            }
            return mStringBuilder.ToString();
        }

        public void _selectStream(string nStreamName)
        {
            mJsonTextWriter.WriteStartObject();
        }

        public void _runClose()
        {
            mJsonTextWriter.WriteEndObject();
            mJsonTextWriter.Close();
            mStringWriter.Close();
        }

        public JsonWriter() {
            mStringBuilder = new StringBuilder();
            mStringWriter = new StringWriter(mStringBuilder);
            mJsonTextWriter = new JsonTextWriter(mStringWriter);
            mJsonTextWriter.Formatting = Formatting.Indented;
        }

        JsonTextWriter mJsonTextWriter;
        StringBuilder mStringBuilder;
        StringWriter mStringWriter;
    }
}
