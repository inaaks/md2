using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // M/ajas darbs Nr.2
            //____________________________________________________
            // Uzdevums Nr.1

            Console.WriteLine("Ievādiet Jūsu lietotāja vārdu");
            string lietName = Console.ReadLine();
            Console.WriteLine("Labdien," + lietName);

            //____________________________________________________
            //Uzdevums Nr.2

            Console.WriteLine("Ievādiet Jūsu vecumu");
            string age = Console.ReadLine();
            int vecums = int.Parse(age);
            int vecumNak = vecums + 1;
            Console.WriteLine("Apsvecu nākam gad Jums būs " + vecumNak);

            //_____________________________________________________
            //uzdevums Nr.3

            Console.WriteLine("Ievādiet pirmo skaitļi");
            string skNum1 = Console.ReadLine();
            int pSk = int.Parse(skNum1);
            Console.WriteLine("Ievādiet otro skaitļi");
            string skNum2 = Console.ReadLine();
            int oSk = int.Parse(skNum2);
            int maksSk = Math.Max(pSk, oSk);
            Console.WriteLine("Lielākais skaitlis ir " + maksSk);

            //_______________________________________________________
            //uzdevums Nr.4
            Console.WriteLine("Ievādiet pirmo skaitļi");
            string skNum3 = Console.ReadLine();
            int pSk3 = int.Parse(skNum3);
            Console.WriteLine("Ievādiet otro skaitļi");
            string skNum4 = Console.ReadLine();
            int oSk4 = int.Parse(skNum4);
            int minsSk = Math.Min(pSk3, oSk4);
            Console.WriteLine("Mazākais skaitlis ir " + minsSk);

            //__________________________________________________________
            //uzdevums Nr.5

            Console.WriteLine("Ievādiet pirmo skaitļi");
            string pirmsSk1 = Console.ReadLine();
            int ipirmsSk1 = int.Parse(pirmsSk1);
            Console.WriteLine("Ievādiet otro skaitļi");
            string otrsSk1 = Console.ReadLine();
            int iotrsSk1 = int.Parse(otrsSk1);
            int iAtlik = ipirmsSk1 % iotrsSk1;
            Console.WriteLine(ipirmsSk1 + "/" + iotrsSk1 + " Dalījuma atlikums ir " + iAtlik);

            //_____________________________________________________________
            //uzdevums Nr.6

            Console.WriteLine("Ievādiet  skaitļi");
            string numb1 = Console.ReadLine();
            int inumb1 = int.Parse(numb1);
            int atlik2 = inumb1 % 2;
            bool par = atlik2 == 0;
            Console.WriteLine("Skaitlis " + inumb1 + " ir pāra?-" + par);

            //________________________________________________________________
            //uzdevums Nr.7

            Console.WriteLine("Ievādiet taisnstūra malas garumu, sm");
            string aMala = Console.ReadLine();
            double iaMala = double.Parse(aMala);
            double laukums = (iaMala * iaMala);
            double laukumsRounded = Math.Round(laukums, 2);
            Console.WriteLine("Taisnstūra laukums ir " + laukumsRounded + " sm2");

            //__________________________________________________________________
            //uzdevums Nr.8

            Console.WriteLine("Ievādiet vienādsānu trijstūra malas garumu, sm");
            string tMala = Console.ReadLine();
            double itMala = double.Parse(aMala);
            double sqr3 = Math.Sqrt(3);
            double laukumst = (itMala * itMala*sqr3/4);
            double laukumstRounded = Math.Round(laukumst, 2);
            Console.WriteLine("Vienādsānu trijstūra laukums ir " + laukumstRounded + " sm2");

            //_____________________________________________________________________
            //uzdevums Nr.9

            Console.WriteLine("Ievādiet ,lūdzu, Jūsu vārdu");
            string lietName1= Console.ReadLine();
            Console.WriteLine("Ievādiet ,lūdzu, Jūsu vēcumu");
            string vecums1 = Console.ReadLine();
            int ivec = int.Parse(vecums1);
            Console.WriteLine($"Sveiks, {lietName1}! Tavs vecums ir {ivec} gadi.");

        }

        
    }
}
