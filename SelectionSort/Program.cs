using System;

namespace SelectionSort
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Create an array of students with names and ages
            Student[] students = new Student[]
            {
            new Student { Name = "Alice", Age = 16 },
            new Student { Name = "Bob", Age = 17 },
            new Student { Name = "Charlie", Age = 18},
            new Student { Name = "David", Age = 19 },
            new Student { Name = "Eve", Age = 20 }
            };

            Console.WriteLine("Original List of Students:");
            PrintStudents(students);

            // Sort the array of students based on age using Selection Sort
            SelectionSort(students);

            Console.WriteLine("\nSorted List of Students (by Age):");
            PrintStudents(students);
        }

        static void SelectionSort(Student[] students)
        {
            int n = students.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    // Compare students based on age
                    if (students[j].Age < students[minIndex].Age)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    // Swap the students if they are in the wrong order
                    Student temp = students[i];
                    students[i] = students[minIndex];
                    students[minIndex] = temp;
                }
            }
        }

        static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}");
            }
        }
    }
}
