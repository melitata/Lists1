using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> guests = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Bergen",
            "Müslüm Baba",
            "Murat Boz",
            "Tupac",
            "Tarkan"
        };
        Console.WriteLine("Davetliler Listesi:");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}
