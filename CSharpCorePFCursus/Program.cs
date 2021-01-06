using System;
using Firma;
using Firma.Materiaal;
using Firma.Personeel;
using MateriaalStatus = Firma.Materiaal.Status;
using PersoneelStatus = Firma.Personeel.Status;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            MateriaalStatus statusBoorMachine = MateriaalStatus.Werkend;
            PersoneelStatus statusChef = PersoneelStatus.HogerKader;
            Console.WriteLine(statusBoorMachine);
            Console.WriteLine(statusChef);
        }
    }
}