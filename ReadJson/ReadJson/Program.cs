using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject sonSpec = new JObject(
                new JProperty("score", 9),
                new JProperty("name", "손흥민"),
                new JProperty("number", 7)
            );

            File.WriteAllText(@"C:\path2.json", sonSpec.ToString());

        }

    }
}
