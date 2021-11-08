using System;

namespace array_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sDizi ={1,4,54,87,3,2};
            
            Console.WriteLine("**** Sırasız Dizi ****");
            foreach(var sayi in sDizi){
            Console.WriteLine(sayi);
            }

            Console.WriteLine("**** Sıralı Dizi ****");
            Array.Sort(sDizi);// diziyi sıralı hale sokar 
            foreach(var sayi in sDizi){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("**** Array Clear ****");
            Array.Clear(sDizi,2,2);// sDizisi 2. indexten sonraki 2 elemanın değerini 0 yapar.

            foreach(var sayi in sDizi){
                Console.WriteLine(sayi);
            }

            // Reverse Diziyi tersine çevirmek

            Console.WriteLine("**** Reverse ****");
            Array.Reverse(sDizi);// diziyi ters çevirir

            foreach(var sayi in sDizi){
                Console.WriteLine(sayi);
            }

            // IndexOf (verilen değerin dizinin kaçıncı index'i olduğunu göstermede kullanılır.)

            Console.WriteLine("**** IndexOf ****");
            Console.WriteLine(Array.IndexOf(sDizi,4));// Not: girilen değer dizi içerisinde mevcut değilse -1 değerini dönecektir.
            

            //Resize (Yeniden boyutlandırma-Eleman sayısında değişiklik yapmak)
            Console.WriteLine("**** Resize ****");
            Array.Resize<int>(ref sDizi,6);// ilk tanımladığım dizi 5 elemanlıydı şuan 6 elemanlı olacak şekilde boyutlandırdım.
            sDizi[5]=44;// index olarak düşünürsek 6. elemanı 5. index numarasıdır yani 6. elemana 44 değerini atadım.

            foreach(var sayi in sDizi){
                Console.WriteLine(sayi);
            }

        }
    }
}
