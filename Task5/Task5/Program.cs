using System;
using Task5.FileManagment;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CreateObjects

            var student1 = new Student()
            {
                LastName = "Gaidukevich",
                Test = new Test()
                {
                    Name = "Test 1",
                    Time = new DateTime(2002, 07, 24),
                    Grade = 8
                }
            };

            var student2 = new Student()
            {
                LastName = "Stupen",
                Test = new Test()
                {
                    Name = "Test 1",
                    Time = new DateTime(2002, 07, 25),
                    Grade = 9
                }
            };

            var student3 = new Student()
            {
                LastName = "Borodin",
                Test = new Test()
                {
                    Name = "Test 2",
                    Time = new DateTime(2002, 07, 26),
                    Grade = 10
                }
            };

            #endregion

            var tree = new Tree<Student>
            {
                student1,
                student2,
                student3
            };

            Console.WriteLine(tree.Head.Value.LastName);
            Console.WriteLine("--------------------------");

            tree.Head.Balance();

            Console.WriteLine(tree.Head.Value.LastName);
            Console.WriteLine(tree.Head.Left.Value.LastName);
            Console.WriteLine(tree.Head.Right.Value.LastName);

            var path = @"E:\Portfolio\Task5\file.xml";
            var fileWorker = new XmlTreeWorker();
            fileWorker.SaveTreeFileXml(path, tree);
        }
    }
}
