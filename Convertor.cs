using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulap3
{
    public class Convertor
    {
       
        public List<double> transferirdouble(List<string> listaS)
        {
            List<double> listaD = listaS.ConvertAll(double.Parse);

            return listaD;
        }
        public double resulfinal(List<double> lista2) 
        {
            double aux = 0;
            foreach(double soma in lista2)
            {
                aux += soma;
            }
            return aux/3.0;
        }
    }
}
