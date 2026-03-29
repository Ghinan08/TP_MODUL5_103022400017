using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400017
{
    internal class DataGeneric<T>
    {
        public T Data { get; private set; }
        public DataGeneric(T data)
        {
            Data = data;

        }
        public void PrintData()
        {

            Console.WriteLine("Data yang tersimpan adalah: " + Data);
        }

    }
}
