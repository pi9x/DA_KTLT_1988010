using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.DAL
{
    public class JsonWriter : IDataWriter
    {
        readonly string filePath;
        public JsonWriter(string path)
        {
            filePath = path;
        }
        public void Write<T>(List<T> objects)
        {
            using var writer = File.CreateText(filePath);
            writer.Write(JsonConvert.SerializeObject(objects));
        }
    }
}
