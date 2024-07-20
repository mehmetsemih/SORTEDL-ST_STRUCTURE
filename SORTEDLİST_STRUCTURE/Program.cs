using System.Collections;

namespace SORTEDLİST_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORTEDLİST STRUCTURE
            //BELONGS TO SYSTEM.COLLECTION CLASS

            // SORTEDLİST DESCRIBING 

            var list = new SortedList()
            {
                {0,"sıfır"},
                {1,"bir"},
                {2,"iki"},
                {8,"sekiz"},
                {10,"on"},
                {19,"on dokuz"},
                {15,"on beş"},
                {25,"yirmi beş"},
            };

            // ADD
            list.Add(5, "beş");

            //REMOVE

            list.Remove(15);

            //ROAM OR WANDER AROUND
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,-5}-  "+
                    $"{item.Value,-10}");
            }

            //COUNT
            Console.WriteLine("LİSTENİN ELEMAN SAYISI : "+list.Count);

            //CAPACİTY
            Console.WriteLine("LİSTENİN KAPASİTESİ : "+list.Capacity);

            //TRİMTOSİZE()
            list.TrimToSize();
            Console.WriteLine("LİSTENİN BOŞLUKLARI KESEREK KALAN ELEMAN SAYISI: "+list.Capacity);

            //ACCESSING THE VALUE
            //KEY
            Console.WriteLine(list[0]);

            //VALUE
            Console.WriteLine(list.GetByIndex(4));

            // GET ->  KEY
            Console.WriteLine(list.GetKey(4));

            //FINDING THE LAST VALUE IN THE LIST
            Console.WriteLine(list.GetByIndex(list.Count-1));


            //*********************
            var anahtarlar = list.Keys;
            Console.WriteLine("\nANAHTARLAR");
            foreach (var key1 in anahtarlar) 
            { 
                Console.WriteLine(key1);
            }



            var değerler=list.Values;
            Console.WriteLine("\nDEĞERLER");
            foreach (var item in değerler)
            {
                Console.WriteLine(item);
            }

            //UPDATE 
            if (list.Contains(1))
            {
                list[1] = "one";
            }
            Console.WriteLine();

            //AGAİN ROAM OR WANDER AROUND
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key,-5}-  " +
                    $"{item.Value,-10}");
            }

            // */*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/

            //SORTEDLİST APPLICATION

            var kıtap_iceriği = new SortedList();
            kıtap_iceriği.Add(1, "ÖNSÖZLER");
            kıtap_iceriği.Add(50, "BİLGİ VE İŞLEM");
            kıtap_iceriği.Add(25, "OPERATÖRLER");
            kıtap_iceriği.Add(70, "İF-ELSE");


            Console.WriteLine("İÇİNDEKİLER");
            Console.WriteLine(new string('-', 25));
            Console.WriteLine($"{"KONULAR",-30}  {"SAYFALAR",5}");
            foreach (DictionaryEntry item in kıtap_iceriği)
            {
                Console.WriteLine($"{item.Value,-30}  {item.Key,5}");
            }










            Console.ReadLine();
        }
    }
}
