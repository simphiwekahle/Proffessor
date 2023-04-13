using Professor;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var student = new Cstudent();

        student.Name = "Sphephelo";
        student.RegNo = "0007";
        Console.WriteLine("Year Mark: ");
        student.YearMark = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Last Year Mark: ");
        student.LastExamMark = Convert.ToDouble(Console.ReadLine());
        student.FinalMark = 0;
        /*student.Grade = student.CalcGrade();*/ // this was the issue

        //Console.WriteLine("Name: ");
        //name = Console.ReadLine();
        //Console.WriteLine("Registration No.: ");
        //regNo = Console.ReadLine();
        //Console.WriteLine("Year Mark: ");
        //yrMark = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Last Year Mark: ");
        //examMark = Convert.ToDouble(Console.ReadLine());

        student.FinalMark = student.CalculateFinal(student.YearMark, student.LastExamMark);

        switch (student.FinalMark)
        {
            case < 50:
                student.Grade = "F";
                break;

            case < 60:
                student.Grade = "D";
                break;

            case < 70:
                student.Grade = "C";
                break;

            case < 75:
                student.Grade = "B";
                break;

            case >= 75:
                student.Grade = "A";
                break;
        }

        Console.WriteLine();

        Console.WriteLine("Name is " + student.Name);
        Console.WriteLine("Registration Number is " + student.RegNo);
        Console.WriteLine("Year Mark is " + student.YearMark);
        Console.WriteLine("Last Examination Mark is " + student.LastExamMark);
        Console.WriteLine();
        Console.WriteLine("Final Mark is " + student.FinalMark);
        Console.WriteLine("Grade = " + student.Grade);
    }
}

