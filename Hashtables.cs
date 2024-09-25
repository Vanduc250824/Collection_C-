using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_C_
{
    public class Hashtables
    {
        private String ten;
        private int tuoi;
        private Hashtable ht = new Hashtable();
       
        public void Nhap()
        {

            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Ten: ");
                ten = Console.ReadLine();
                Console.WriteLine("Tuoi: ");

                tuoi = Convert.ToInt32(Console.ReadLine());
                ht.Add(ten, tuoi);
            }
            
        }
        public void Xuat()
        {
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
            }
        }
    }
}
