using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program();
        }

        public Program()
        {
            Convertor convertor = new Convertor();
            double vtotal = 0;

            List<string> list = new List<string>();
            List<double> list2 = new List<double>();

            convertor.transferirdouble(list);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite a nota 0{0}: ", i + 1);
                list.Add(Console.ReadLine());
            }

            list2 = convertor.transferirdouble(list);
            vtotal = convertor.resulfinal(list2);
     
            Console.WriteLine("A média do aluno foi: {0}", vtotal);
            Console.ReadKey();
        }
    }
}
