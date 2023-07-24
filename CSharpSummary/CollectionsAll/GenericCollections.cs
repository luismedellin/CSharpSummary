using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpSummary.CollectionsAll
{
    public static class GenericCollections
    {
        public class ListGeneric
        {
            public void PrintList()
            {
                var data = new List<int>() { 4, 1, 2, 3 };
                var value = data[3];
                var position = data.IndexOf(1);
                var position2 = data.IndexOf(20);
                data.Sort();// ordena los elementos


                var listaEmpleados = new List<Empleado>
                {
                    new Empleado("Juan", 30),
                    new Empleado("María", 25),
                    new Empleado("Carlos", 28),
                    new Empleado("Ana", 35)
                };

                listaEmpleados.Sort((emp1, emp2) => emp1.Edad.CompareTo(emp2.Edad)); // Ordenar por edad


                var lista2 = new List<string>() { "hola", "mundo" };

                var lista = new List<string>{ "hola", "mundo" };
                var message = string.Join(',', lista);//hola,mundo


                var _any = data.Any();//existe algun elemento
                var _any2 = data.Any(i=> i==3);//existe elemento 3 
                var _exists = data.Exists(i=> i == 3);

            }
        }

        public class SortedListGeneric { 
            public void PrintSortedList()
            {
                SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {1, "One"},
                                        {2, "Two"}
                                    };
                if (!numberNames.ContainsKey(4))
                {
                    numberNames[4] = "Four";
                }

                if (numberNames.TryGetValue(4, out string result))
                    Console.WriteLine("Key: {0}, Value: {1}", 4, result);

                for (int i = 0; i < numberNames.Count; i++)
                {
                    Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
                }


            }
        }

        public class DictionaryGeneric
        {
            public void PrintSortedList()
            {
                //var cities = new Dictionary<string, string>(){
                //    {"UK", "London, Manchester, Birmingham"},
                //    {"USA", "Chicago, New York, Washington"},
                //    {"India", "Mumbai, New Delhi, Pune"}
                //};

                //Console.WriteLine(cities["UK"]); //prints value of UK key
                //Console.WriteLine(cities["USA"]);//prints value of USA key
                //                                 //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

                var cities = new Dictionary<string, string>(){
                    {"UK", "London, Manchester, Birmingham"},
                    {"USA", "Chicago, New York, Washington"},
                    {"India", "Mumbai, New Delhi, Pune"}
                };

                //use ContainsKey() to check for an unknown key
                if (cities.ContainsKey("France"))
                {
                    Console.WriteLine(cities["France"]);
                }

                //use TryGetValue() to get a value of unknown key
                if (cities.TryGetValue("France", out string result))
                {
                    Console.WriteLine(result);
                }

                var data = cities.Values;
            }
        }

        public class HashtableNoGeneric
        {
            public void Print()
            {
                var cities = new Hashtable(){
                    {"UK", "London, Manchester, Birmingham"},
                    {"USA", "Chicago, New York, Washington"},
                    {"India", "Mumbai, New Delhi, Pune"}
                };

                var uk = cities["UK"];
                var uk2 = (string)cities["UK"];
                var co = cities["CO"];//null
                var co2 = (string)cities["CO"];

            }
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
