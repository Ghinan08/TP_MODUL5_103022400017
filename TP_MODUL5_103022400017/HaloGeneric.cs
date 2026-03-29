using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400017
{
    internal class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);

        }

    }
}
