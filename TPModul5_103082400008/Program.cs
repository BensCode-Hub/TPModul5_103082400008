using System;
using System.Collections.Generic;
using System.Text;

namespace TPModul5_103082400008

{

    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo User " + x);
        }
    }


    class Program

    {
        static void Main(string[] args)
        {
            HaloGeneric sapa = new HaloGeneric();
            sapa.SapaUser<string>("Ruben");

            DataGeneric<string> Nim = new DataGeneric<string>("103082400008");
            Nim.PrintData();
        }
    }

    public class DataGeneric<T>
    {

        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data tersimpan adalah: " + Data);
        }
    }
}
            
    
