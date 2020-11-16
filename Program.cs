/*
* Trivia Application by Donald Knechtel
* Introduction to Programming, 9/19/2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TriviaGame
{
    class Game
    {
        string gameName = "Trivia Game";
        static Player playerone = new Player();


        public Game()
        {
            //Write out header and credit
            WriteLine("Trivia Night by Donald Knechtel");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Trivia Night by Donald Knechtel";
            string title = @" 
           _____ ___ _____   _____   _     _  _ ___ ___ _  _ _____ _ 
          |_   _| _ \_ _\ \ / /_ _| /_\   | \| |_ _/ __| || |_   _| |
            | | |   /| | \ V / | | / _ \  | .` || | (_ | __ | | | |_|
            |_| |_|_\___| \_/ |___/_/ \_\ |_|\_|___\___|_||_| |_| (_)
                                                                   ";
            Console.WriteLine(title);
            Console.ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Welcome to Trivia Night!");
            ResetColor();
            Play();
            ReadKey();
        }
        private void Play()
        {
            //Character Name
            //Player input and instructions
            Console.WriteLine("Please enter your name.");
            playerone.name = Console.ReadLine();

            Console.WriteLine("Welcome to the game " + playerone.name + "! ");
            Console.WriteLine("Answer each question correctly to gain points. Good luck, and have fun!");
            Console.WriteLine("Press ENTER to continue");

            //Questions and answers
            TriviaItem item1 = new TriviaItem();
            TriviaItem item2 = new TriviaItem();
            TriviaItem item3 = new TriviaItem();
            TriviaItem item4 = new TriviaItem();
            TriviaItem item5 = new TriviaItem();

            //add color to questions
            ReadLine();
            Clear();
            WriteLine("Question 1:");
            item1.question = "What is your quest?";
            item1.answer = "I seek the holy grail";
            item2.question = "What game was estimated to be installed on more computers worldwide than Microsoft’s 95?";
            item2.answer = "Doom";
            item3.question = "In Monty Python's The Holy Grail, what is the first gift requested by The Nights Who Say 'Ni' to pass through the woods?";
            item3.answer = "shrubbery";
            item4.question = "On what Year did humanity first land on the moon?";
            item4.answer = "1969";
            item5.question = "What is the tallest building in the world?";
            item5.answer = "Burj Khalifa";

            //Console.WriteLine("The correct Answers is " + Answer1 +".");

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(item1.question);
            ResetColor();

            String s;
            s = ReadLine();
            if (s == item1.answer) { playerone.score = playerone.score + 1; }
            WriteLine("The correct answer is " + item1.answer + ". Your answer was " + s);
            WriteLine("Press ENTER to continue.");
            ReadLine();
            Clear();

            WriteLine("Question 2:");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(item2.question);
            ResetColor();

            s = ReadLine();
            if (s == item2.answer) { playerone.score = playerone.score + 1; }
            WriteLine("The correct answer is " + item2.answer + ". Your answer was " + s);
            WriteLine("Press ENTER to continue.");
            ReadLine();
            Clear();

            WriteLine("Question 2:");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(item3.question);
            ResetColor();

            s = ReadLine();
            if (s == item3.answer) { playerone.score = playerone.score + 1; }
            WriteLine("The correct answer is " + item3.answer + ". Your answer was " + s);
            WriteLine("Press ENTER to continue.");
            ReadLine();
            Clear();

            WriteLine("Question 4:");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(item4.question);
            ResetColor();

            s = ReadLine();
            if (s == item4.answer) { playerone.score = playerone.score + 1; }
            WriteLine("The correct answer is " + item4.answer + ". Your answer was " + s);
            WriteLine("Press ENTER to continue.");
            ReadLine();
            Clear();

            WriteLine("Question 5:");
            ForegroundColor = ConsoleColor.Green;
            WriteLine(item5.question);
            ResetColor();

            s = ReadLine();
            if (s == item5.answer) { playerone.score = playerone.score + 1; }
            WriteLine("The correct answer is " + item5.answer + ". Your answer was " + s);
            WriteLine("Press ENTER to continue.");
            ReadLine();
            Clear();
            // add int counter for points
            //Goal of 5 of 5 points Keep track with int
            WriteLine("" + playerone.name + " got " +playerone.score + "/5 correct.");
            WriteLine("Press ENTER to exit the game.");
        }
    }
    class Player
    {
        //Add to tally player points
        public string name = "Anonymous Person";
        public int score = 0;

    }
    class TriviaItem
    {
        public string question = "";
        public string answer = "";
    }
    class Program
    {
        static void Main()
        {
            Game game = new Game();
         
        }
    }
}
