using System;

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

            /*var Oak = new Tree<int>();
                          //                             10                              10                                             
            Oak.Add(10);  //                            /   \                           /   \
            Oak.Add(3);   //                           /     \                         /     \
            Oak.Add(2);   //                          3      12      ====>            3       15
            Oak.Add(4);   //                         / \     / \                     / \      / \
            Oak.Add(12);  //                        2   4  null 15                  2   4    12  25
            Oak.Add(15);  //                                      \              
            Oak.Add(11);  //                                       25
            Oak.Add(25);  //

            foreach (var item in Oak)
            {
                Console.WriteLine(item);
            }*/

            var Oak = new Tree<Student>();
            
            Oak.Add(student1);
            Oak.Add(student2);
            Oak.Add(student3);

            Oak.Head.Right.CompareTo(Oak.Head.Value);

        }
    }
}
