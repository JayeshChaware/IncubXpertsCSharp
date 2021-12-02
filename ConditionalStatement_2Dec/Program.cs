using System;

namespace ConditionalStatement_2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Student[] Students = new Student[10];
            for (i = 0; i < Students.Length; i++)
            {
                Students[i]=new Student();
                Students[i].Name = RandomName();
                Students[i].Maths = RandomMarks();
                Students[i].Science = RandomMarks();
                Students[i].English = RandomMarks();
                Students[i].Computers = RandomMarks();

            }
            for (i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("{0} got {1} marks in Maths, {2} marks in Science, {3} marks in English, {4} marks in Computers", Students[i].Name, Students[i].Maths, Students[i].Science, Students[i].English, Students[i].Computers);
                Console.WriteLine("{0} in Maths",Status(IsPass(Students[i].Maths)));
                Console.WriteLine("{0} in Science", Status(IsPass(Students[i].Science)));
                Console.WriteLine("{0} in English", Status(IsPass(Students[i].English)));
                Console.WriteLine("{0} in Computers\n", Status(IsPass(Students[i].Computers)));

            }

            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0,allSubCount=0;
             
            for (i = 0; i < Students.Length; i++)
            {
                sum1 = sum1 + Students[i].Maths;
                if (IsPass(Students[i].Maths)) { count1++; }

                sum2 = sum2 + Students[i].Science;
                if (IsPass(Students[i].Science)) { count2++; }

                sum3 = sum3 + Students[i].English;
                if (IsPass(Students[i].English)) { count3++; }

                sum4 = sum4 + Students[i].Computers;
                if (IsPass(Students[i].Computers)) { count4++; }

                if (IsPass(Students[i].Maths) && IsPass(Students[i].Science) && IsPass(Students[i].English) && IsPass(Students[i].Computers))
                { allSubCount++; }

            }
            Console.WriteLine("\nAverage score in Maths: {0}", GetAverage(sum1));
            Console.WriteLine("{0}% students pass in Maths",count1*10);

            Console.WriteLine("\nAverage score in Science: {0}", GetAverage(sum2));
            Console.WriteLine("{0}% students pass in Science", count2 * 10);

            Console.WriteLine("\nAverage score in English: {0}", GetAverage(sum3));
            Console.WriteLine("{0}% students pass in English", count3 * 10);

            Console.WriteLine("\nAverage score in Computers: {0}", GetAverage(sum4));
            Console.WriteLine("{0}% students pass in Computers", count4 * 10);

            Console.WriteLine("\n{0}% students pass in all subjects", allSubCount * 10);



        }
        public static readonly Random _random = new Random();

              
        public static int RandomMarks()
        {
            return _random.Next(0, 100);
        }

        public static string RandomName()
        {
            return char.ConvertFromUtf32(_random.Next('a', 'z'));
        }

        public static float GetAverage(int total)
        {
            float average=total/10;
            return average;
        }
        public static bool IsPass(int marks)
        {
            bool isPass;
            isPass = marks >= 40 ? true : false;
            return isPass;
        }

        public static string Status(bool status)
        {
            switch (status)
            {
                case true:
                    return "pass";
                    
                case false:
                    return "fail";
                    

            }
        }
    }
    class Student : Marks
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Marks
    {
        public int Maths { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public int Computers { get; set; }
    }

   
}
