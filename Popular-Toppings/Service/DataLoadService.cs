using Newtonsoft.Json;
using Popular_Toppings.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popular_Toppings.Service
{
    public static class DataLoadService
    {
        static public List<Pizza> Pizzas { get; set; }

        static public bool LoadJsonData()
        {
            using (var reader = new System.IO.StreamReader(ConfigurationManager.AppSettings.Get("PizzaPath")))
            {
                try
                {
                    Pizzas = JsonConvert.DeserializeObject<List<Pizza>>(reader.ReadToEnd());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
           
            return true;
        }
    }
}
