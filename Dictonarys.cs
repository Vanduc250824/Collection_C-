using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_C_
{
    
    public class Dictonarys
    {
        Dictionary<string, int> d = new Dictionary<string, int>();
        private int tuoi;
        private String ten;
        public Dictonarys() { }
        public void Add() 
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Ten: ");
                ten = Console.ReadLine();
                Console.WriteLine("Tuoi: ");
                tuoi = Convert.ToInt32(Console.ReadLine());
                if(!d.ContainsKey(ten))
                {
                    d.Add(ten, tuoi);
                }
                else
                {
                    Console.WriteLine("Nhap ten khac!!!");
                }
            }
        }
        public void Hienthi() {
            foreach (var entry in d)
            {
                Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
            }
        }
    }
}
