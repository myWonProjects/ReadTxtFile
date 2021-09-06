using System;
using System.Collections.Generic;
using System.IO;

namespace ReadTxtFile
{
    class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                //try -> dizinde hata olasılığı olan bloklar
                
                string filePath = @"C:\Users\bahci\Desktop\emailFile.txt"; //dosya yolu belirtilir
                string[] mails = System.IO.File.ReadAllLines(filePath);    //txt dosyasının bütün dizinleri bir diziye atılır
                string mainMail = "vakifbank@vakifbank.com";               //bulmak istediğimiz mail adresi

                
                foreach (string m in mails)      //mails dizisindeki her bir elemanı sayması için döngü oluşturur
                {
                    if (String.Equals(m, mainMail))   //dizideki herbir değer ile istenilen string değeri karşılatırır.
                        Console.WriteLine(m);         //eğer eşitse ekrana yazdırır                   
                   
                }
                Console.ReadKey();
                              
            }

            catch (IOException e)

               //try bloğundaki işlemler yapılırken hata oluşur ise catch bloğu yakalar ve çıktı verir. Hata yoksa bu blok çalışmaz.
            {
                Console.WriteLine("the file could not be read:");
                Console.WriteLine(e.Message);

            }

            finally

               //hata olsa da mutlaka çalışması gereken kod bloğu
            {
                Console.WriteLine("kzcmcz");
            }

        }               
                   
    }
}
