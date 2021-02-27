using System;
using Newtonsoft.Json;


namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona Qualunque = new Persona("Mario", "Rossi", 34);
            
            //string objectSerialized = JsonConvert.SerializeObject(Qualunque);

            string objectSerialized = JsonConvert.SerializeObject(Qualunque, Formatting.Indented);
          
            Console.WriteLine($"  serializzato {objectSerialized}");

            Console.ReadLine();


            //Persona Normale = JsonConvert.DeserializeObject<Persona>(objectSerialized);

            Alieno Normale = JsonConvert.DeserializeObject<Alieno>(objectSerialized);

            Console.ReadLine();
        }
    }


    class Persona
    {
       
        public string Nome { get; set; }
             
        public string Cognome { get; set; }

        public int Eta { get; set; }

        public Persona (string N, string C, int E)
        {

            Nome = N;
            Cognome = C;
            Eta = E;

        }

    }

    class Alieno
    {
        
        public string Nome { get; set; }

       
        public string CognomeA { get; set; }

        
        public int Eta { get; set; }

        public string Galassia { get; set; }

        public Alieno(string N, string C, int E)
        {

            Nome = N;
            CognomeA = C;
            Eta = E;

        }

    }


}
