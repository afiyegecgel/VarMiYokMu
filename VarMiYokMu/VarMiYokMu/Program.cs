using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> günesSistemi = new List<string>();
            günesSistemi.Add("Merkür");
            günesSistemi.Add("Venüs");
            günesSistemi.Add("Dünya");
            günesSistemi.Add("Mars");
            günesSistemi.Add("Jüpiter");
            günesSistemi.Add("Satürn");
            günesSistemi.Add("Uranüs");
            günesSistemi.Add("Neptün");

            Console.WriteLine("Selam, sana girdiğin bir gezegenin güneş sisteminde kaçıncı sırada olduğunu söyleyebilirim");
            Console.WriteLine("Deneyelim istersen. Bir gezegen girmeyi dene");

            string gezegen = Console.ReadLine();
            bool varMi = false;
            int i;
            for ( i= 0; i <= gezegen.Length+1; i++)
            {
                if(gezegen == günesSistemi[i])
                {
                    varMi = true;
                    break;
                }
            }

            if (varMi)
            {
                Console.WriteLine($"{gezegen} güneş sisteminde {i+1}. sırada");
            }
            else
            {
                Console.WriteLine($"{gezegen} güneş sisteminde yok :( ");
            }
            Console.ReadLine();
            
        }
    }
}
