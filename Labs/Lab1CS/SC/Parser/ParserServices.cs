using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SC.Parser
{
     class ParserServices
     {
          public void GetFileText(string filePatch, string jsonPath, string jsonName)
          {
               List<string> items = new List<string>();
               List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

               string text = File.ReadAllText(filePatch);
               items = GetListOfItems(text);
               list = splitRules(items);
               generateJson(list, jsonPath, jsonName);

          }

          private void generateJson(List<Dictionary<string, string>> jsonTxt, string jsonPath, string jsonName)
          {
               string path = jsonPath + "\\" + jsonName + ".json";
               string json = JsonConvert.SerializeObject(jsonTxt, Formatting.Indented);

               using (FileStream fs = File.Create(path))
               {
                    byte[] info = new UTF8Encoding(true).GetBytes(json);
                    fs.Write(info, 0, info.Length);
               }
          }

          private List<string> GetListOfItems(string text)
          {
               List<string> items = new List<string>();             
               for (int i = 1; i < text.Split("<custom_item>").Length; i++)
               {
                    var item = text.Split("<custom_item>")[i].Split("</custom_item>")[0];
                    items.Add(item);
               }
               return items;
          }

          private List<Dictionary<string, string>> splitRules(List<string> items)
          {
               List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
               Dictionary<string, string> dictionary;
               foreach (var item in items)
               {
                    dictionary = new Dictionary<string, string>();
                    var e = item.Split("\n ");
                    foreach(var i in e)
                    {    
                         if(i.Contains(':'))
                         {
                              var j = i.Split(":");
                              j[0].Trim();
                              dictionary.Add(j[0], j[1]);
                         }
                    }
                    list.Add(dictionary);
               }
               return list;
          }
     }
}
