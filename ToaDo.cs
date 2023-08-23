using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class ToaDo
    {
        int ToaDoX;

        public int ToaDoX1
        {
            get { return ToaDoX; }
            set { ToaDoX = value; }
        }
        int ToaDoY;

        public int ToaDoY1
        {
            get { return ToaDoY; }
            set { ToaDoY = value; }
        }
        string TenToaDo;

        public string TenToaDo1
        {
            get { return TenToaDo; }
            set { TenToaDo = value; }
        }
        public ToaDo()
        {
            ToaDoX = 10;
            ToaDoY = 20;
            TenToaDo = "Bac";
        }
        public ToaDo(int ToaDoX, int ToaDoY, string TenToaDo)
        {
            this.ToaDoX = ToaDoX;
            this.ToaDoY = ToaDoY;
            this.TenToaDo = TenToaDo;
        }
        public void ToString()
        {
            Console.WriteLine("Toa do x: {0}, Toa do y: {1}, Ten toa do: {2}", ToaDoX, ToaDoY, TenToaDo);
        }
    }
}
