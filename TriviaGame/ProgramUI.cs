using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    public class ProgramUI
    {
      public void Run()
        {
            Menu();
        }
       
      private void Menu()
        {
            Player[] scoreboard = SeedContent();
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to our Trivia Game!\n" +
                "Please choose an option:\n" +
                "1. Start New Game\n" +
                "2. View Scoreboard\n" +
                "3. Exit Program");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Player playerOne = PlayGame();
                        scoreboard[1] = playerOne;
                        break;
                    case "2":
                        DisplayScores(scoreboard);
                        break;
                    case "3":
                        keepRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        break;
                }
            }
        }

        private Player PlayGame()
        {
            Console.Clear();
            Player one = CreateNewPlayer();
            int score = 0;
            Console.WriteLine("LEVEL ONE");
            score = QuestionOne(score);
            score = QuestionTwo(score);
            score = QuestionThree(score);
            score = QuestionFour(score);
            score = QuestionFive(score);
            score = QuestionSix(score);
            score = QuestionSeven(score);
            score = QuestionEight(score);
            score = QuestionNine(score);
            score = QuestionTen(score);
            Console.Clear();
            Console.WriteLine($"Congratulations! You scored {score} points so far!\n" +
                $"Are you ready for LEVEL TWO?\n" +
                $"In this round, every question is worth 2 points.");
            Console.ReadLine();
            score = QuestionEleven(score);
            score = QuestionTwelve(score);
            score = QuestionThirteen(score);
            score = QuestionFourteen(score);
            score = QuestionFifteen(score);
            Console.Clear();
            Console.WriteLine($"GAME OVER. You score {score} points!");
            Console.ReadLine();
            one.highScore = score;
            return one;
        }
        //Player methods:
        private Player CreateNewPlayer()
        {
            Player one = new Player();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            one.highScore = 0;
            one.name = name;
            return one;
        }
        private void DisplayScores(Player[] scores)
        {
            Console.Clear();
            var orderedScores = scores.OrderByDescending(x => x.highScore);
            Console.WriteLine("HIGH SCORES!:");
            foreach(Player player in orderedScores)
            {
                if (player != null) 
                {
                    Console.WriteLine($"User:{player.name}  |  Score: {player.highScore}\n");
                }
            }
            Console.ReadLine();
        }
        // Questions:
        private int QuestionOne(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question one: How many chambers does an Alligator's heart have?\n" +
                "A. 4\n" +
                "B. 5\n" +
                "C. 3\n" +
                "D. 2");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionTwo(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question two: What is the largest planet in our solar system?\n" +
                "A. Earth\n" +
                "B. Mercury\n" +
                "C. Jupiter\n" +
                "D. Venus");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionThree(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question three: What is the most widely used language in the world?\n" +
                "A. English\n" +
                "B. Mandarin\n" +
                "C. Arabic\n" +
                "D. Spanish");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionFour(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question four: What is the most commonly used letter of the alphabet?\n" +
                "A. A\n" +
                "B. S\n" +
                "C. R\n" +
                "D. E");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionFive(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question five: How many hearts does an octopus have?\n" +
                "A. Five\n" +
                "B. Eight\n" +
                "C. One\n" +
                "D. Three");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionSix(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question six: What is the largest mammal in the world?\n" +
                "A. Whale\n" +
                "B. Elephant\n" +
                "C. Moose\n" +
                "D. Hippopatamus");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionSeven(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question seven: What is a group of hippos called?\n" +
                "A. Pack \n" +
                "B. Pod \n" +
                "C. Bloat \n" +
                "D. Family");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionEight(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question eight: What is Darth Vader's real name?\n" +
                "A. Obi Wan Kenobi\n" +
                "B. Luke Skywalker\n" +
                "C. Anakin Skywalker \n" +
                "D. Emperor Palpatine");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionNine(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question nine: Approx. how many feet are in a mile?\n" +
                "A. 3,820\n" +
                "B. 5,280\n" +
                "C. 2,580\n" +
                "D. 8,250");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "b":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionTen(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question ten: What is E.T.'s favorite candy?\n" +
                "A. Reese's Pieces\n" +
                "B. M&Ms\n" +
                "C. Skittles\n" +
                "D. Twizzler's");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 1;
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!"); 
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionEleven(int score)
        {
            Console.Clear();
            Console.WriteLine("Here is question eleven: Where is Elon Musk from? \n" +
                "A. South Africa\n" +
                "B. England\n" +
                "C. Australia\n" +
                "D. United States");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "a":
                    Console.WriteLine("That's correct!");
                    Console.ReadLine();
                    score = score + 2;
                    return score;
                case "b":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "c":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                case "d":
                    Console.WriteLine("Incorrect!");
                    Console.ReadLine();
                    return score;
                default:
                    Console.WriteLine("Invalid answer. No points awarded.");
                    Console.ReadLine();
                    return score;
            }
        }
        private int QuestionTwelve(int score)
        {
            {
                Console.Clear();
                Console.WriteLine("Here is question twelve: What was the name of the first electronic programmable computer?\n" +
                    "A. MAC\n" +
                    "B. IBM\n" +
                    "C. ENIAC \n" +
                    "D. MSDOS");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "a":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "b":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "c":
                        Console.WriteLine("That's correct!");
                        Console.ReadLine();
                        score = score + 2;
                        return score;
                    case "d":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    default:
                        Console.WriteLine("Invalid answer. No points awarded.");
                        Console.ReadLine();
                        return score;
                }
            }
        }
        private int QuestionThirteen(int score)
        {
            {
                Console.Clear();
                Console.WriteLine("Here is question thirteen: Who invented Linux?\n" +
                    "A. Steve Jobs\n" +
                    "B. Linus Torvalds\n" +
                    "C. Bill Gates\n" +
                    "D. Larry Page");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "a":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "b":
                        Console.WriteLine("That's correct!");
                        Console.ReadLine();
                        score = score + 2;
                        return score;
                    case "c":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "d":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    default:
                        Console.WriteLine("Invalid answer. No points awarded.");
                        Console.ReadLine();
                        return score;
                }
            }
        }
        private int QuestionFourteen(int score)
        {
            {
                Console.Clear();
                Console.WriteLine("Here is question fourteen: Who was credited with the invention of scissors?\n" +
                    "A. Nikola Tesla\n" +
                    "B. Benjamin Franklin\n" +
                    "C. John Rockefeller\n" +
                    "D. Leonardo da Vinci");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "a":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "b":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "c":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "d":
                        Console.WriteLine("That's correct!");
                        Console.ReadLine();
                        score = score + 2;
                        return score;
                    default:
                        Console.WriteLine("Invalid answer. No points awarded.");
                        Console.ReadLine();
                        return score;
                }
            }
        }
        private int QuestionFifteen(int score)
        {
            {
                Console.Clear();
                Console.WriteLine("Here is question fifteen: What year was the first portable laptop computer released to the public?\n" +
                    "A. 1996\n" +
                    "B. 1988\n" +
                    "C. 1993\n" +
                    "D. 1981");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "a":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "b":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "c":
                        Console.WriteLine("Incorrect!");
                        Console.ReadLine();
                        return score;
                    case "d":
                        Console.WriteLine("That's correct!");
                        Console.ReadLine();
                        score = score + 2;
                        return score;
                    default:
                        Console.WriteLine("Invalid answer. No points awarded.");
                        Console.ReadLine();
                        return score;
                }
            }
        }
            private Player[] SeedContent()
        {
            Player one = new Player(9, "Molly");
            Player two = new Player(8, "Sam");
            Player three = new Player(10, "Matthew");
            Player four = new Player(1, "Tim");
            Player[] list = { one, two, three, four };
            return list;
        }
    }
}
