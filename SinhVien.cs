using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class SinhVien
    {
        int MaSV;

        public int MaSV1
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        string HoTen;

        public string HoTen1
        {
            get { return HoTen; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Loi roi ku");
                    Console.ReadKey();
                }
                else HoTen = value;
            }
        }
        float DiemLT;

        public float DiemLT1
        {
            get { return DiemLT; }
            set { DiemLT = value; }
        }
        float DiemTH;

        public float DiemTH1
        {
            get { return DiemTH; }
            set { DiemTH = value; }
        }
        public SinhVien()
        {
            MaSV = 2001216272;
            HoTen = "Le Duc Tu";
            DiemLT = 7.0f;
            DiemTH = 7.2f;
        }
        public SinhVien(int MaSV, string HoTen, float DiemLT, float DiemTH)
        {
            this.MaSV = MaSV;
            HoTen1 = HoTen;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }
        public float DTB()
        {
            float dtb = 0;
            return dtb = (DiemLT + DiemTH) / 2;
        }
        public void ToString()
        {
            Console.WriteLine("MaSV: {0}, Ho ten: {1}, Diem LT: {2}, Diem TH: {3}, DTB: {4}", MaSV, HoTen, DiemLT, DiemTH, DTB());
        }
    }
}
