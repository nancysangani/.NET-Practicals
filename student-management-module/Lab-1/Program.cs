using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class StudentManagement
    {
        public int AdmissionNumber;
        public string Name;
        public string Course;
        public int Semester;
        public string Stream;

        private int Fees;
        private string ScholarshipStatus;

        private const double Scholarship = 0.25;

        public StudentManagement(int admissionNum, string name, string course, int semester, int fees, 
            string stream)
        {
            AdmissionNumber = admissionNum;
            Name = name;
            Course = course;
            Semester = semester;
            Fees = fees;
            ScholarshipStatus = "No";
            Stream = stream;
        }

        public void StudentDetails()
        {
            Console.WriteLine("\n---Student Details---");
            Console.WriteLine($"Admission Number: {AdmissionNumber}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Fees to be paid: {Fees}");
            Console.WriteLine($"Stream of the student: {Stream}");
            Console.WriteLine($"Is student eligible for scholarship? {ScholarshipStatus}");
        }

        public void ScholarshipEligibility(int percentage)
        {
            if (Stream.Equals("Science", StringComparison.OrdinalIgnoreCase))
            {
                if (percentage >= 80)
                {
                    ScholarshipStatus = "Yes";
                    Fees -= (int)(Fees * Scholarship);
                }
                else
                {
                    ScholarshipStatus = "No";
                }
            }
            else if (Stream.Equals("Commerce", StringComparison.OrdinalIgnoreCase))
            {
                if (percentage >= 85)
                {
                    ScholarshipStatus = "Yes";
                    Fees -= (int)(Fees * Scholarship);
                }
                else
                {
                    ScholarshipStatus = "No";
                }
            }
            else if (Stream.Equals("Arts", StringComparison.OrdinalIgnoreCase))
            {
                if (percentage >= 90)
                {
                    ScholarshipStatus = "Yes";
                    Fees -= (int)(Fees * Scholarship);
                }
                else
                {
                    ScholarshipStatus = "No";
                }
            }
            else
            {
                Console.WriteLine("Invalid stream entered.");
                ScholarshipStatus = "No";
            }
        }
    }

    class StudentMarks
    {
        public int marks1, marks2, marks3, marks4, marks5;
        public int GetPercentage()
        {
            return (marks1 + marks2 + marks3 + marks4 + marks5) / 5;
        }
        public void ShowMarks()
        {
            int total = marks1 + marks2 + marks3 + marks4 + marks5;
            int percentage = GetPercentage();

            Console.WriteLine("Total: " + total);
            Console.WriteLine("Percentage: " + percentage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student details
            Console.Write("Enter Admission Number: ");
            int admissionNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Fees: ");
            int fees = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Stream: ");
            string stream = Console.ReadLine();

            // Marks details
            StudentMarks marks = new StudentMarks();
            Console.WriteLine("\nEnter the marks of 5 subjects:");
            Console.Write("Enter marks of Subject 1: ");
            marks.marks1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of Subject 2: ");
            marks.marks2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of Subject 3: ");
            marks.marks3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of Subject 4: ");
            marks.marks4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks of Subject 5: ");
            marks.marks5 = Convert.ToInt32(Console.ReadLine());

            marks.ShowMarks();

            int percentage = marks.GetPercentage();

            StudentManagement student = new StudentManagement(admissionNo, name, course, semester, fees, stream);

            student.ScholarshipEligibility(percentage);
            student.StudentDetails();
        }
    }
}
