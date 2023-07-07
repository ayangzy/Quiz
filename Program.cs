using System;

namespace MyQuiz
{
   class Program
    {
        public static void Main(string[] args)
        {

            Question[] questions = new Question[]
             {
                new Question
                {
                    Text = "What is the capital of France?",
                    Options = new string[] { "London", "Paris", "Berlin", "Madrid" },
                    CorrectOption = 1
                },
                new Question
                {
                    Text = "What is the chemical symbol for the element Gold?",
                    Options = new string[] { "Au", "Ag", "Cu", "Fe" },
                    CorrectOption = 0
                },
                new Question
                {
                    Text = "Who painted the Mona Lisa?",
                    Options = new string[] { "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh", "Michelangelo" },
                    CorrectOption = 0
                },
                new Question
                {
                    Text = "Which is the largest ocean on Earth?",
                    Options = new string[] { "Pacific Ocean", "Atlantic Ocean", "Indian Ocean", "Arctic Ocean" },
                    CorrectOption = 0
                },
                new Question
                {
                    Text = "What is the capital of Australia?",
                    Options = new string[] { "Sydney", "Melbourne", "Canberra", "Perth" },
                    CorrectOption = 2
                },
             };



            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Question currentQuestion = questions[i];

                Console.WriteLine($"Question {i + 1}: {currentQuestion.Text}");

                for (int j = 0; j < currentQuestion.Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {currentQuestion.Options[j]}");
                }

                Console.Write("Enter your choice: ");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == currentQuestion.CorrectOption + 1)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Quiz complete! Your score: {score}/{questions.Length}");


        }
    }
}
