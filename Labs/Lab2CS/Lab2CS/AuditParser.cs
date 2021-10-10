using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace Lab2CS
{
    class AuditParser
    {
        public List<JObject> Write_Items_To_Json(IList<IList<string>> listsOfLists)
        {
            var listOfJsonStrings = new List<JObject>();
            foreach (IList<string> list in listsOfLists)
            {
                JObject obj = new JObject();
                foreach (string line in list)
                {
                    if (line.Contains(":"))
                    {
                        string[] propAndValue = line.Split(':');
                        obj.Add(new JProperty(propAndValue[0], propAndValue[1]));
                    }
                    
                }
                listOfJsonStrings.Add(obj);
            }
            return listOfJsonStrings;

        }

        public IList<IList<string>> SplitBy_CustomItemStruct(IList<string> lines)
        {
            IList<IList<string>> customItemStructs = new List<IList<string>>();
            int listIndex = 0;
            foreach(string line in lines)
            {
                if(line == "<custom_item>")
                {
                    customItemStructs.Add(new List<string>());
                }
                customItemStructs[listIndex].Add(line);
                if(line == "</custom_item>")
                {
                    listIndex++;
                }
            }

            return customItemStructs;
        }
        public IList<string> SplitBy_CustomItem(string path)
        {
            IList<string> lines = new List<string>();
            StreamReader reader = File.OpenText(path);
            bool write = false;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line == "<custom_item>")
                {
                    write = true;
                }

                if (write)
                {
                    if (!line.StartsWith("#"))
                    {
                        lines.Add(line);
                    }
                }

                if (line == "</custom_item>")
                {
                    write = false;
                }
            }
            return lines;
        }
    }
}
