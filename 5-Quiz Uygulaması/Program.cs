using System;

namespace _5_Quiz_Uygulaması
{
    class Question
    {
        public Question(string text, string[] choices, string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }

        public string Text { get; set; }
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }

    }
    class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void displayQuestion()
        {
            Question question = this.GetQuestion();
            this.displayProgress();
            Console.WriteLine($"Soru {this.QuestionIndex + 1}: {question.Text}");

            foreach (var c in question.Choices)
            {
                Console.WriteLine($"-{c}");
            }

            Console.Write("Cevap: ");
            var cevap = Console.ReadLine();
            this.answer(cevap);
        }

        private void answer(string answer)
        {
            var question = this.GetQuestion();
            if(question.checkAnswer(answer))
                this.Score++;
            this.QuestionIndex++;
            if (this.Questions.Length == this.QuestionIndex)
            {
                this.displayScore();
            }
            else
            {
                this.displayQuestion();
            }

        }

         private void displayScore()
         {
             Console.WriteLine($"Skor: {this.Score}");
         }

         private void displayProgress()
         {
             int totalQuestion = this.Questions.Length;
             int questionNumber = this.QuestionIndex+1;
             if (totalQuestion>=questionNumber)
             {
                 Console.WriteLine($"{questionNumber} of {totalQuestion}");
             }
             
         }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Phyton", "Java", "C++" }, "C#");
            var q2 = new Question("En iyi programlama dili hangisidir?", new string[] { "C#", "Phyton", "Java", "C++" }, "C#");
            var q3 = new Question("En bilinen programlama dili hangisidir?", new string[] { "C#", "Java", "Phyton", "C++" }, "C#");

            Question[] questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);

            quiz.displayQuestion();

            // Console.WriteLine(quiz.GetQuestion().Text);
            // quiz.QuestionIndex++;
            // Console.WriteLine(quiz.GetQuestion().Text);
            // quiz.QuestionIndex++;
            // Console.WriteLine(quiz.GetQuestion().Text);

            // int index = 1;
            // foreach (var q in questions)
            // {
            //     Console.WriteLine($"{index}.soru: {q.Text}");
            //     index++;
            //     foreach (var c in q.Choices)
            //     {
            //         Console.WriteLine($"-{c} ");
            //     }

            //     Console.Write("Cevap: ");
            //     string cevap = Console.ReadLine();

            //     Console.WriteLine(q.checkAnswer(cevap));
            // }

        }
    }
}
