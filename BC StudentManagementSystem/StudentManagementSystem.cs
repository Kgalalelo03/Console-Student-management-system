using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_StudentManagementSystem
{
    internal class StudentManagementSystem 
    {
        //call method and create an array or list
        private List<Student> students;

        public StudentManagementSystem()
        {
            students = new List<Student>();
        }

        //Menu method to run program
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Belgium Campus Student Management System");
                Console.WriteLine("1. Register a Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter the number of the function you want to run: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            RegisterStudent();
                            break;
                        case 2:
                            DisplayAllStudents();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Input not recognised. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input not recognised. Please try again.");
                }

                Console.WriteLine();
            }
        }

        //method to register students
        private void RegisterStudent()
        {
            Console.WriteLine("===== Register Student Below =====");
            Console.Write("Student ID: ");
            int studentID = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Email address: ");
            string email = Console.ReadLine();

            Console.Write("Date of Birth (yyyy-mm-dd): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Qualification (Degree/Diploma): ");
            string qualification = Console.ReadLine();
            //object from student class
            Student student = new Student(studentID, studentName, surname, gender, email, dob, phoneNumber, qualification);
            Console.WriteLine($"Discount: R{student.Discount}");

            students.Add(student);
            Console.WriteLine("Student successfully enrolled!");
        }

        //method to display students
        private void DisplayAllStudents()
        {
            Console.WriteLine("Enrolled students");
            if (students.Count == 0)
            {
                Console.WriteLine("There are no enrolled students yet.");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Student ID: {student.StudentID}");
                    Console.WriteLine($"Name: {student.StudentName} {student.Surname}");
                    Console.WriteLine($"Gender: {student.Gender}");
                    Console.WriteLine($"Email: {student.Email}");
                    Console.WriteLine($"Date of Birth: {student.DOB:yyyy-MM-dd}");
                    Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                    Console.WriteLine($"Qualification: {student.Qualification}");
                    Console.WriteLine($"Discount: R{student.Discount}");
                    
                    Console.WriteLine("------------------------------------");
                }
            }
        }

    }
}
