using System;

namespace NickNG
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] nicknames = new string[10,2];

            nicknames[0,0] = "Violent  ";
            nicknames[0,1] = "Magician";
            
            nicknames[1,0] = "Dynamic";
            nicknames[1,1] = "Warlock";

            nicknames[2,0] = "Tuff";
            nicknames[2,1] = "Overlord";

            nicknames[3,0] = "Amateur";
            nicknames[3,1] = "Wanderer";

            nicknames[4,0] = "Foolish";
            nicknames[4,1] = "Mastermind";

            nicknames[5,0] = "Tha";
            nicknames[5,1] = "Proffessional";

            nicknames[6,0] = "Phantom";
            nicknames[6,1] = "Madman";

            nicknames[7,0] = "Gentleman";
            nicknames[7,1] = "Menace";

            nicknames[8,0] = "Violent";
            nicknames[8,1] = "Leader";

            nicknames[9,0] = "Vulgar";
            nicknames[9,1] = "Bandit";


            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            //Console.WriteLine($"Hello {name}");
            //Console.WriteLine($"Your name reversed is {Reverser(name)}");
            //Console.WriteLine($"Your name is {name.Length} characters long");

            string[] parts = name.Split(new char[]{' '});

            Console.WriteLine($"Your nickname is {GetNickNameComponent(parts[0],nicknames,"first")} {GetNickNameComponent(parts[1],nicknames,"first")} ");

            //Console.WriteLine($"1st nickname: {GetNickNameComponent(parts[0],nicknames,"first")}");

            //Console.WriteLine($"2st nickname: {GetNickNameComponent(parts[1],nicknames,"first")}");
        }

        public static string GetNickNameComponent(string input, string[,] nicknames, string position){
            string output = "";

            int index = input.Length % nicknames.GetLength(0);

            if(position == "first"){
                output = nicknames[index,0];

            }else if(position == "last"){
                output = nicknames[index,1];

            }
            return output;

        }

        public static string Reverser(string original){
            char [] temp = original.ToCharArray();

            for(int i = 0;i<temp.Length;i++){
                Console.WriteLine($"{temp[i]}");
            }

            Array.Reverse(temp);

            Console.WriteLine(temp);

            string output = new string (temp);

            return output;
        }

    }
}
