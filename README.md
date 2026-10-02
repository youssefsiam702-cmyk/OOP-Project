# OOP Examination System

A C# console application that models a simple examination system using core object-oriented programming concepts.

## Main Requirements

- A base `Question` class containing the question header, body, mark, answer choices, and correct answer.
- Two question forms for final exams: True/False and Multiple Choice.
- Multiple Choice questions are supported for practical exams.
- An `Answer` class stores an answer identifier and its text.
- A base `Exam` class stores the exam duration and its questions.
- `FinalExam` calculates and displays the student's grade.
- `PracticalExam` displays each question together with its correct answer.
- A `Subject` can create and hold either type of examination.
- `ICloneable`, `IComparable`, constructor chaining, and `ToString()` are demonstrated.

## Example Content

The sample final exam uses original questions about object-oriented programming, including encapsulation, inheritance, and C# interfaces. The sample answer choices are also different from the reference implementation.

## Running the Project

1. Open `OOP Project.slnx` in Visual Studio.
2. Make sure the .NET 10 SDK is installed.
3. Build the solution.
4. Run the console application.

The application creates a subject, builds a final exam, adds the questions, displays the exam results, and demonstrates cloning, comparison, and string conversion.
