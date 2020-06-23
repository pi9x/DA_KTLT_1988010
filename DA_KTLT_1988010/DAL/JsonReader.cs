using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.DAL
{
    public class JsonReader : IDataReader
    {
        readonly string filePath;
        public JsonReader(string path)
        {
            filePath = path;
        }
        public List<T> Read<T>()
        {
            using var reader = File.OpenText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(reader.ReadToEnd());
        }
    }
}
