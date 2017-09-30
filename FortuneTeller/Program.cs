using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Statement
            Console.WriteLine("Welcome to Finn and Jake's Fortune Telling service!");
            Console.WriteLine("I am BMO! Finn and Jake's game!");
            Console.WriteLine("\nYay BMO!");

            //User Input and fortunes
            //names
            Console.WriteLine("\nTo start your fortune, I will need your name.");
            string fName = Console.ReadLine();

            Console.WriteLine("And your last name too.");
            string lName = Console.ReadLine();

            //age question
            Console.WriteLine("I also need your age!");
            int userAge = int.Parse(Console.ReadLine());

            //age fortune. 
            string uAge;
            if (userAge % 2 == 0)//even
            {

                //Why can't I convert from int to string here?
                //Actually I can!!!! Global variables v. Local variables
                uAge = " in 10 years";
            }
            else //odd.
            {
                uAge = " shortly";
            }


            //month question
            Console.WriteLine("Oh, hehe! That's so old. BMO is not that old.");
            Console.WriteLine("Please tell BMO the number of the month in which you were born.");
            double bMonth = double.Parse(Console.ReadLine());

            //num month fortune
            string uMoney;

            if (bMonth >= 1 && bMonth <= 4)
            {
                uMoney = " more money than you could dream";
            }
            else if (bMonth >= 5 && bMonth <= 8)
            {
                uMoney = " not much money at all";
            }
            else if (bMonth >= 9 && bMonth <= 12)
            {
                uMoney = " about as much money as the entire Candy Kingdom has";
            }
            else
            {
                uMoney = " $0.00";
            }


            //color question
            //better as switch
            //I am struggling to get switch to run right.
            Console.WriteLine("BMO also requires your favorite color.");
            Console.WriteLine("In Roy G Biv, please!");
            Console.WriteLine("Or in case you don't know, say to me Help!");
            string fColor = Console.ReadLine().Trim().ToLower();
            

            string userColor = "";

            if (fColor == "red")
            {
                userColor = " blood red bass";
            }
            else if (fColor == "orange")
            {
                userColor = " stretchy orange dog";
            }
            else if (fColor == "yellow")
            {
                userColor = " bright yellow candy car";
            }
            else if (fColor == "green")
            {
                userColor = "n ogre";
            }
            else if (fColor == "blue")
            {
                userColor = " white boat on the open blue sea with BMO";
            }
            else if (fColor == "indigo")
            {
                userColor = " flapping moustache";
            }
            else if (fColor == "violet")
            {
                userColor = " long walk on the beach with BMO";
            }
            else if (fColor == "help")
            {
                Console.WriteLine("Roy G Biv refers to the color spectrum. But BMO knows that some things can't see color.");
                Console.WriteLine("It goes like this: Red Orange Yellow Green Blue Indigo Violet");
                string fav = Console.ReadLine().Trim().ToLower();

                if (fav == "red")
                {
                    userColor = " blood red bass";
                }
                else if (fav == "orange")
                {
                    userColor = " stretchy orange dog";
                }
                else if (fav == "yellow")
                {
                    userColor = " bright yellow candy car";
                }
                else if (fav == "green")
                {
                    userColor = "n ogre";
                }
                else if (fav == "blue")
                {
                    userColor = " white boat on the open blue sea with BMO";
                }
                else if (fav == "indigo")
                {
                    userColor = " flapping moustache";
                }
                else if (fav == "violet")
                {
                    userColor = " long walk on the beach with BMO";
                }
            }
            else
            {
                userColor = " nothing";
            }











            //sibling question
            Console.WriteLine("Final question. How many siblings do you have?");
            int uSiblings = int.Parse(Console.ReadLine());

            //sibling fortune
            //it would be valuable to experiment with switch on my own time
            //need to make int into a string?? What the hell.
            string vacation;

            if (uSiblings == 0)
            {
                vacation = " the Candy Kingdom";
            }
            else if (uSiblings == 1)
            {
                vacation = " the Ice Kingdom";
            }
            else if (uSiblings == 2)
            {
                vacation = " the Slime Kingdom";
            }
            else if (uSiblings >= 3)
            {
                vacation = " the Fire Kingdom";
            }
            else
            {
                vacation = " the dreaded Nightosphere";
            }




            //Your Fortune ...I've made the decision to write only the variable segments as the variables, 
            //instead of the whole fragment.

            Console.WriteLine("Your fortune is");
            Console.WriteLine(fName.Trim() + " " + lName.Trim() + " will retire" + uAge);
            Console.WriteLine("with" + uMoney + " in the bank,");
            Console.WriteLine("a vacation home in" + vacation);
            Console.WriteLine("and a" + userColor + " as your way to get around!");

            Console.WriteLine("\nHurray for BMO!\n");
            



        }
    }
}
