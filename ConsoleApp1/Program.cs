using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 16;
            String dato2 = "25g";
            int resultado = dato1 + Convert.ToInt32(dato2);

            MessageBox.Show("Lo sentimos no se pudo realizar la operación solicitada");
        }
    }
}
