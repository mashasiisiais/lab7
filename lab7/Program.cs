using laba04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    internal class Program
    {
        static List<Abonent> abonents;

        static void PrintAbonents()
        {
            foreach (Abonent abonent in abonents)
            {
                Console.WriteLine(abonent.Info());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            abonents = new List<Abonent>();
            try
            {
                using (FileStream fs = new FileStream("FINALY.abonents", FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        Abonent abonent = new Abonent();
                        abonent.Name = br.ReadString();
                        abonent.Number = br.ReadString();
                        abonent.Extra = br.ReadDouble();
                        abonent.CostT = br.ReadDouble();
                        abonent.Service = br.ReadDouble();
                        abonent.Debt = br.ReadBoolean();
                        abonent.Contract = br.ReadBoolean();

                        abonents.Add(abonent);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталась помилка: \n{0}", ex.Message);
            }

            Console.WriteLine("Несортований перелік абонентів: {0}", abonents.Count);
            PrintAbonents();
            abonents.Sort();
            Console.WriteLine("Сортований перелік абонентів: {0}", abonents.Count);
            PrintAbonents();
            Console.WriteLine();
            Abonent abonetOleg = new Abonent("Семенко Олег Григорович", "+3742839", 34, 40, 30, true, false);
            abonents.Add(abonetOleg);
            abonents.Sort();
            Console.WriteLine("Перелік абонентів: {0}", abonents.Count);
            PrintAbonents();
            Console.WriteLine("Видаляємо останнє значення");
            abonents.RemoveAt(abonents.Count - 1);
            Console.WriteLine("Перелік абонентів {0}", abonents.Count);
            PrintAbonents();
            Console.ReadKey();
        }
    }


}