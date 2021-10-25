using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog palub sisestada kasutaja eesnime

            //prog palub sisestada numbrid 1-3

            //Funktsioonide abil, kolm funktsiooni:
            //kui kasutaja sisestab '1', siis kuvatakse eesnimi tagurpidi
            //kui '2', siis kuvatakse eesnime esimest tähte
            //kui '3', siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("Kirjuta oma eesnimi: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number '1','2','3': ");
            char userOperator = Convert.ToChar(Console.ReadLine());

        

            switch (userOperator)

            {
                case '1':
                    Reverse(userName);
                    break;

                case '2':
                    UserNameFirst(userName);
                    break;

                case '3':
                    Length(userName);
                    break;
                
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void Reverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void UserNameFirst(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void Length(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }


}


