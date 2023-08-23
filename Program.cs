using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(2012,"L",2.5f,3.0f);
            sv.ToString();
            Console.ReadKey();
        }
    }
}
