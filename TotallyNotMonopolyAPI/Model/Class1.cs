using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class Class1
    {

        public List<Class2> LoadJson()
        {
            List<Class2> cardsList;
            using (StreamReader r = new StreamReader(@".\Asset\json1.json"))
            {
                string json = r.ReadToEnd();
                cardsList = JsonConvert.DeserializeObject<List<Class2>>(json);                
            }      
            return cardsList;
        }
    }
}
