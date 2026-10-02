namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject =
                new Subject(205, "Object Oriented Programming");

            Console.WriteLine(subject);

            // Create Final Exam
            subject.CreateExam(
                ExamType.Final,
                TimeSpan.FromMinutes(75));

            // Question 1: True/False
            Question q1 = new TFQuestion(
                "[True Or False] Question 1",
                "Encapsulation helps protect an object's internal data from direct access.",
                2,
                true);

            q1.StudentAnswerID = 1;

            // Question 2: MCQ
            Answer[] answers2 =
            {
                new Answer(1, "Inheritance"),
                new Answer(2, "Compilation"),
                new Answer(3, "Debugging"),
                new Answer(4, "Deployment")
            };

            Question q2 = new MCQQuestion(
                "[MCQ] Question 2",
                "Which OOP concept allows a class to reuse members from another class?",
                3,
                answers2,
                1);

            q2.StudentAnswerID = 1;

            // Question 3: MCQ
            Answer[] answers3 =
            {
                new Answer(1, "interface"),
                new Answer(2, "namespace"),
                new Answer(3, "using"),
                new Answer(4, "return")
            };

            Question q3 = new MCQQuestion(
                "[MCQ] Question 3",
                "Which C# keyword is used to declare a contract that classes can implement?",
                5,
                answers3,
                1);

            q3.StudentAnswerID = 3;

            // Add questions to exam
            subject.Exam!.AddQuestion(q1);
            subject.Exam.AddQuestion(q2);
            subject.Exam.AddQuestion(q3);

            // Display exam
            subject.Exam.ShowExam();

            // Demonstrate ICloneable
            Question copiedQuestion =
                (Question)q2.Clone();

            Console.WriteLine("Cloned Question:");
            Console.WriteLine(copiedQuestion);

            // Demonstrate IComparable
            Console.WriteLine(
                $"Compare Q1 and Q2 by marks: " +
                q1.CompareTo(q2));

            Console.WriteLine(
                $"Compare Answer 1 and Answer 2 by ID: " +
                answers2[0].CompareTo(answers2[1]));

            // Demonstrate ToString
            Console.WriteLine(subject.ToString());
        }
    }
}
