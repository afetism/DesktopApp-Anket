using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesktopApp_Anket.DataBase
{
    internal class JsonHandler<T>
    {
        string Path { get; set; }

        public List<T> Values { get; set; } 
        public JsonHandler(string path)
        {
            Path = path;
            if (File.Exists(Path))
            {
                string allData = File.ReadAllText(Path);
                Values = JsonSerializer.Deserialize<List<T>>(allData)?? new();

            }
            else { Values = new (); }

        }

        public void SaveData()
        {
            string saveData= JsonSerializer.Serialize(Values);
            File.WriteAllText(Path, saveData);
           
        }
        





    }
}
