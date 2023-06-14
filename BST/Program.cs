using System;
using System.Diagnostics;



namespace BST
{
    class Program
    {
        public static void Main(string[] args)
        {
            BSTTree bst = new BSTTree();
            Random rnd = new Random();

            for (int i = 0; i < 10000000; i++)
            {
                bst.StartInsert(rnd.Next());
            }
            //bst.StartInsert(14);
            //bst.StartInsert(7);
            //bst.StartInsert(8);
            //bst.StartInsert(9);
            //bst.StartInsert(6);
            //bst.StartInsert(2);
            //bst.StartInsert(1);
            //bst.StartInsert(5);
            //bst.StartInsert(16);
            //bst.StartInsert(11);
            //bst.StartInsert(18);
            //bst.StartInsert(1);
            



            //if (bst.StartSearch(25) != null) Console.WriteLine("tak");
            //else Console.WriteLine("nie");

            //TreeNode minValueNode = bst.Min(bst.root);
            //TreeNode maxValueNode = bst.Max(bst.root);



            //Console.WriteLine("Minimalna wartość w drzewie: " + minValueNode.value);
            //Console.WriteLine("Maksymalna wartość w drzewie: " + maxValueNode.value);
            //Console.WriteLine("Korzeń: " + bst.root.value);

            //TreeNode node = bst.StartSearch(18);
            //TreeNode SuccessorValue = bst.Successor(node);
            //if (SuccessorValue != null) Console.WriteLine("Nastepnik: " + SuccessorValue.value);
            //else Console.WriteLine("Nastepnik: brak ");
            


            long t1 = TimeUtils.GetNanoseconds();
            bst.StartDelete(rnd.Next());
            long t2 = TimeUtils.GetNanoseconds();
            long dt = t2 - t1;
            Console.WriteLine("Runtime of Delete: " + dt + " ns");

             t1 = TimeUtils.GetNanoseconds();
            bst.StartInsert(rnd.Next());
             t2 = TimeUtils.GetNanoseconds();
             dt = t2 - t1;
            Console.WriteLine("Runtime of Insert: " + dt + " ns");

            t1 = TimeUtils.GetNanoseconds();
            bst.StartSearch(rnd.Next());
            t2 = TimeUtils.GetNanoseconds();
            dt = t2 - t1;
            Console.WriteLine("Runtime of Search: " + dt + " ns");


        }

    }
    }

