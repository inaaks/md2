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

            // klases darbs
            int myNumber = 15;
            char myFavoriteLetter = 'A';
            double myConstant = 4.58;
            float myChangigngNum = 2.46f;
            string name1 = "Andis is a ....";
            bool isCar = true;




            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangigngNum);
            Console.WriteLine(name1);
            Console.WriteLine(isCar);

            Console.WriteLine(myChangigngNum * myConstant);

            //______________________________________________________________


            int myNumber1 = 3;
            int myNumber2 = 17;
            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name11 = " Helli ";
            string name2 = "from code";
            string namesTogether = name11 + name2;

            Console.WriteLine(namesTogether);

            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);


            int divisionReminder1 = 49;
            int divisionReminder2 = 10;

            int divisionReminderResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionReminderResult);

            //____________________________________________________________________



            int myNumber5 = 14;
            int myNumber6 = 17;
            bool isEqualNum = myNumber5 == myNumber6;

            Console.WriteLine(isEqualNum);

            string myText4 = " ACC";
            string myText5 = " ACC";
            bool isEqualText = myText5 == myText4;

            Console.WriteLine(isEqualText);

            int myNumber7 = 15;
            int myNumber8 = 17;
            bool isEqualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEqualNumber2);

            //_______________________________________________________________________


            bool iAmTrue = true;
            bool iAmFalse = false;

            bool both = iAmTrue && iAmFalse;
            bool or = iAmTrue || iAmFalse;
            bool bothReverse = !both;

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(bothReverse);


            //____________________________________________________________________________


            int myNumber9 = 14;
            myNumber9 += 10;
            Console.WriteLine(myNumber9);

            //_____________________________________________________________________________

            Console.WriteLine("Kāds ir Jūsu vārds?");
            string userName = Console.ReadLine();
            Console.WriteLine("Sveiks," + userName);


            //_____________________________________________________________________________

            Console.WriteLine("Kāds ir Jūsu vecums?");
            string ageText = Console.ReadLine();

            int age9 = int.Parse(ageText);
            int previosYearAge = age9 - 1;
            Console.WriteLine("Sveiks,tev iepriekšējā gada bija " + previosYearAge);
            //_______________________________________________________________________________

            Console.WriteLine("__________________________________________________________________");

            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);
            Console.WriteLine(absAfter);

            double numberToRound = 1.5557;
            double roundedNumber = Math.Round(numberToRound, 2);
            Console.WriteLine(roundedNumber);



        }


    }
}
