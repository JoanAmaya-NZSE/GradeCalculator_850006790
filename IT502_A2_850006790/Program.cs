using System;
/* START

    DECLARE marks for maths, physics, chemistry, computerScience as INT
    DECLARE average as DOUBLE IN function CalculateAverage()
    DECLARE grade as CHAR IN function CalculateGrade()

    DISPLAY "Enter Maths marks: "
    INPUT maths
    DISPLAY "Enter Physics marks: "
    INPUT physics
    DISPLAY "Enter Chemistry marks: "
    INPUT chemistry
    DISPLAY "Enter Computer Science marks: "
    INPUT computerScience

    CALL function CalculateAverage
        RETURN (maths + physics + chemistry + computerScience) / 4.0;
    STORE result in average

    CALL function CalculateGrade
    IF (average >= 80) THEN
            RETURN 'A';
       ELSE IF (average >= 70) THEN
            RETURN 'B';
       ELSE IF (average >= 60) THEN
            RETURN 'C';
       ELSE IF (average >= 50) THEN
            RETURN 'D';
       ELSE THEN
            RETURN 'F';
    STORE result in grade

    DISPLAY ""Average Marks: "{average}"
    DISPLAY ""Grade: "{grade}"

    SWITCH grade
        CASE A: DISPLAY "Excellent! Your grade is A!"
        CASE B: DISPLAY "Good! Your grade is B!"
        CASE C: DISPLAY "Satisfactory. Your grade is C..."
        CASE D: DISPLAY "Pass. Your grade is D..."
        CASE F: DISPLAY "Fail. Your grade is F..."
    END SWITCH

    CATCH
    ERROR EXCEPTION DISPLAY "Invalid input. Please enter numeric values only."

END*/


namespace GradeCalculatorApp
{
    // Class that contains all grade-related logic
    class StudentGrade
    {
        // Function to calculate average marks
        public static double CalculateAverage(int maths, int physics, int chemistry, int computerScience)
        {
            return (maths + physics + chemistry + computerScience) / 4.0;
        }

        // Function to determine grade based on average
        public static char CalculateGrade(double average)
        {
            if (average >= 80)
                return 'A';
            else if (average >= 70)
                return 'B';
            else if (average >= 60)
                return 'C';
            else if (average >= 50)
                return 'D';
            else
                return 'F';
        }
    }


    class Program
    {
        static void Main()
        {
            try
            {
                // Declare variables
                int maths, physics, chemistry, computerScience;
                double average;
                char grade;

                // Accept user input
                Console.Write("Enter Maths marks: ");
                maths = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Physics marks: ");
                physics = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Chemistry marks: ");
                chemistry = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Computer Science marks: ");
                computerScience = Convert.ToInt32(Console.ReadLine());

                // Calculate average using class function
                average = StudentGrade.CalculateAverage(maths, physics, chemistry, computerScience);

                // Calculate grade using class function
                grade = StudentGrade.CalculateGrade(average);

                // Display results
                Console.WriteLine("\nAverage Marks: " + average.ToString("F2")); 
                Console.WriteLine("Grade: " + grade);

                // Switch statement for remarks
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent! Your grade is A!");
                        break;
                    case 'B':
                        Console.WriteLine("Good! Your grade is B!");
                        break;
                    case 'C':
                        Console.WriteLine("Satisfactory. Your grade is C...");
                        break;
                    case 'D':
                        Console.WriteLine("Pass. Your grade is D...");
                        break;
                    case 'F':
                        Console.WriteLine("Fail. Your grade is F...");
                        break;
                }
            }

            catch (Exception ex)
            {
                // Exception handling
                Console.WriteLine("Invalid input. Please enter numeric values only.");
            }
        }
    }
}


