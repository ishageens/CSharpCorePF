using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        const string BoodschapWeekdag = "We wensen u een prettige werkdag!";
        const string BoodschapWeekend = "We wensen u een fijn weekend!";
        const string OpeningsurenWeekdag = "9u00-12u00 en 13u00-18u00";
        const string OpeningsurenZaterdag = "10u00-12u00";
        const string OpeningsurenZondag = "Gesloten";
        static void Main(string[] args)
        {
            Console.Write("Datum? ");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            System.Text.StringBuilder boodschap = new System.Text.StringBuilder("Openingsuren: ");

            switch (datum.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    boodschap.AppendLine(OpeningsurenWeekdag);
                    boodschap.Append(BoodschapWeekdag);
                    break;
                case DayOfWeek.Saturday:
                    boodschap.Append(OpeningsurenZaterdag + Environment.NewLine + BoodschapWeekend);
                    break;
                case DayOfWeek.Sunday:
                    boodschap.Clear();
                    boodschap.Append(OpeningsurenZondag + Environment.NewLine + BoodschapWeekend);
                    break;
                default: break;
            }
            Console.WriteLine(boodschap.ToString());
        }
    }
}
