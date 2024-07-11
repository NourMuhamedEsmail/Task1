using System;
using System.ComponentModel.Design;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            #region Task1 Loops
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {num} = {num * i}");
            }
            #endregion


            #region Task2 Loops
            Console.WriteLine("Enter Your data:");

            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int age;
            do
            {
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Your Data Is not True , Plz Try again");
                Main();

            } while (age < 0);
            Console.WriteLine($" your id is : {id}\n your Name is :  ${name}\n your Age is : {age}\n");
            #endregion

        }

    }
}


#region  Task3 OOP



class Student
{
    int id;
    string name;
    int age;
    string phone;
    public void getDate(int Id, string Name, int Age, string Phone = "")
    {
        id = Id;
        name = Name;
        age = Age;
        phone = Phone;

    }

    public void print()
    {
        Console.WriteLine($" {id} - {name} - {age} - {phone}");
    }
}

class Progrm
{
    static void Main()
    {
        Console.WriteLine();
        Student Stud1 = new Student();
        Stud1.getDate(1, "nour", 22, "020220222");
        Stud1.print();
    }
}

#endregion
