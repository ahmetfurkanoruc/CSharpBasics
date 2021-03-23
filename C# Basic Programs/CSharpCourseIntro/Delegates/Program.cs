using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SentMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SentMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SentMessage;

            MyDelegate2 myDelegate2 = customerManager.SentMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            int sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);

            myDelegate2("Hello");
            myDelegate();

            Console.ReadLine();
            
        }
    }

    public class CustomerManager
    {
        public void SentMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Alert");
        }

        public void SentMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
