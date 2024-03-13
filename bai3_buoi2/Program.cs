using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Kitu; string StringIn;char Kiemtra;
            Console.WriteLine("nhap vao 1 chuoi: ");
            StringIn = Console.ReadLine();
            Console.WriteLine("nhap vao 1 ki tu: ");
            do
            {
                Kitu = Console.ReadLine();
                if (Kitu.Length > 1) { Console.WriteLine("ban nhap khong phai 1 ki tu, xin moi nhap lai!"); }
            } while (Kitu.Length > 1);
            Kiemtra=Convert.ToChar(Kitu);
            int dem = 0;
            StringIn.ToList().ForEach(x => { if(x==Kiemtra) dem++; });
            if (dem == 0) { Console.WriteLine("ki tu khong xuat hien trong chuoi!"); }
            else
            {
                Console.WriteLine("so lan ki tu " + Kitu + " xuat hien trong chuoi " + StringIn + " la: " + dem);
            }
            Console.ReadKey();
        }

    }
}
