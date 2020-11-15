using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vježba_4__String_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vaša rečenica = ");
            string recenica = Console.ReadLine();
            Console.WriteLine("Recenica = " + recenica);
            string sVelika = recenica.ToUpper(); ;
            Console.WriteLine("Velika recenica = " + sVelika);
            string sMala = recenica.ToLower();
            Console.WriteLine("Mala recenica = " + sMala);
            try { string sPrvaTri = recenica.Substring(0, 3); Console.WriteLine("Prva tri = " + sPrvaTri); }
            catch (Exception e) { };
            try { string sZadnjihPet = recenica.Substring(recenica.Length - 5); Console.WriteLine("Zadnjih 5 = " + sZadnjihPet); }
            catch (Exception e) { };
            try { string s8_11 = recenica.Substring(7, 4); Console.WriteLine("Od 8 do 11 = " + s8_11); }
            catch (Exception e) { };
            Console.ReadKey();
        }
    }
}
