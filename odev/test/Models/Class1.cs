using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Class1
    {
        
        public int Id { get; set; }
        public string TakımAdı { get; set; }
        public string Fiyat { get; set; }


        public static List<Class1> NBAtakımları = new List<Class1>
        {
                 new Class1
             {
                 Id=1,
                 TakımAdı="LA Lakers Forma",
                 Fiyat="100$",
             },
                  new Class1
             {
                 Id=2,
                 TakımAdı="Golden State Warriors",
                 Fiyat="65$",
             },
                   new Class1
             {
                 Id=3,
                 TakımAdı="Brooklyn Nets",
                 Fiyat="139$",
             },
                   new Class1
                   {
                 Id=4,
                 TakımAdı="Cleveland Cavaliers",
                 Fiyat="99$",
             }
        };
    }
}