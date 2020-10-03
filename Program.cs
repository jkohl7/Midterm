using System;
using System.IO;
using System.Collections;

namespace TIcketObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array and read file
            ArrayList TDArray = new ArrayList();
            string file = "tickets.csv";
            StreamReader sr = new StreamReader(file);
           
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(",");
                TDArray.Add(arr);
            }
            

            
        }
    }
}
