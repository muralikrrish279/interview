using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Recursion;
using CrackingBook.Stack;
using CrackingBook.Utils;
using CrackingBook;
using System.Threading;

namespace CrackingBook
{
    class Program
    {


        
        //static void Main(string[] args)
        //{

        #region " Others " 
        // ******************** Strings and Arrays *******************************
        //var uni = new UniquesCharacters(Console.ReadLine());
        //Console.WriteLine(uni.IsUniqueCharacters());

        //string s1 = Console.ReadLine();
        //string s2 = Console.ReadLine();
        //var ana = new Anagram();
        //Console.WriteLine(ana.IsAnagram(s1,s2));

        //var uni = new ReplaceSpace();
        //Console.WriteLine(uni.ReplaceSpaceInString(" ABDFSD asdfasd Aasd ASD asD A

        //var test = new Fibonacci();
        //test.BuildSeries(100);

        //var test = new Permutations();
        //var result = test.BuildPermutations("abcd");
        //Console.WriteLine(String.Join(",", result.ToArray()));

        //var result = new ReverseString();
        //result.reverse("abcdefg");

        //var result = new CountCompression();
        //result.Compress("aaaaccdcabbbbbb");

        //var result = new RotateMatrix();
        //result.Run();

        //var result = new ArrayLeftRotation();
        //result.rotateArray(6, 2, new int[] { 1, 2, 3, 4, 5, 6 });

        //var result = new Staircase();
        //result.build()
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int a0 = 0; a0 < n; a0++)
        //{
        //    int grade = Convert.ToInt32(Console.ReadLine());
        //    if (grade < 38)
        //    {
        //        Console.WriteLine(38);
        //        return;
        //    }
        //    int den = grade / 5;
        //    int rem = grade % 5;
        //    if ((5 * (den + 1)) - grade < 3)
        //        Console.WriteLine(5 * (den + 1));
        //    else
        //    {
        //        Console.WriteLine(grade);
        //    }
        //}

        //var result = new Minseries();
        //result.test2();

        //var result = new TallestCandles();
        //result.FindTallestCandle();

        //var result = new IcecreamParlor();
        //result.print();

        //var result = new ReducedString();
        //result.print();

        //var result = new MaxStack();
        //result.test();

        //strings
        //var allinone = new AllInOne();
        //result.reducedstring();
        //allinone.CheckIfHacker()
        //allinone.MaximumSubArray();
        //allinone.WordBreak("leetcode");



        //stack
        //var allinonestack = new AllInOne_Stack();
        //string folderPath = "";
        //var directoryInfo = new DirectoryInfo(folderPath);
        //var names = new Dictionary<string,int>();
        //var dupes = new List<string>();
        //double filecount = 1;
        //foreach (var file in directoryInfo.EnumerateFiles())
        //{
        //    if (names.ContainsKey(file.Name))
        //    {
        //        dupes.Add(file.Name);
        //    }
        //    else {
        //        filecount++;
        //        names.Add(file.Name,file.FullName);
        //    }
        //}

        //if (dupes.Count == 0)
        //{
        //    Console.WriteLine("No duplicate files found");
        //}
        //else if (dupes.Count == filecount)
        //{
        //    Console.WriteLine("All files in the directory are duplicates");
        //}
        //else {
        //    foreach (var item in dupes)
        //    {
        //        Console.WriteLine("Duplicate files are " + item);
        //    }
        //}

        #endregion

        #region " Amazon "
        //var arrObj = new AMZ_ARR_ALL();
        ////arrObj.findDuplicates(new int[] { 1, 2, 3, 6, 3, 2, 1, 7, 6 }, 9);
        ////arrObj.LongestSequence("0 0 0 1 1 0 1 1 1 1 0 0 0 0 0 0 1 0 0 0 0 0 0 0 0 0 0");
        //arrObj.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,12,80,450 }, 450);

        //var obj = new AMZ_LNK_LST_ALL();
        //var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //list.head.Next = new SinglyLinkedListNode<int>(2);
        //list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //list.head.Next.Next.Next = new SinglyLinkedListNode<int>(4);
        //list.Print(list.head);
        //var node = obj.Reverse(list.head);
        //list.Print(node);
        //obj.FindMiddle(list.head);
        #endregion

        #region " Microsoft "

        #region " String " 
        //var msstring = new MS_String();
        //Console.WriteLine(msstring.BinaryToDecimal("1100", 2));
        //Console.WriteLine(msstring.Reverse("ABCDE"));
        //Console.WriteLine(msstring.OneWayEdit("pale","paless"));
        //Console.WriteLine(msstring.IsUniqueCharacters("paale"));
        //Console.WriteLine(msstring.IsPalindromePermutation("ababd"));
        //Console.WriteLine(msstring.ZerosAndOnes("11001100110000"));
        //Console.WriteLine(msstring.ZerosAndOnesWithNext("1100110011000100000001"));
        //msstring.CountStrings("This is my new book. This is also my favorite book !", "This");
        //var output = msstring.Anagrams(new string[] { "xxy", "cab", "bac", "cab", "abc", "dash", "shad" });
        //foreach (var item in output)
        //{
        //    foreach (var i in item)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region "  Array "
        //var msArr = new Ms_Array();
        //var oup = msArr.Reverse<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
        //msArr.printArray<int>(oup);
        #endregion

        #region "  Stack & Queues "

        //var sck = new Utils.Stack<int>();
        //sck.Push(1);
        //sck.Push(2);
        //sck.Push(3);
        //sck.Push(5);
        //sck.Pop();
        //sck.Push(4);
        //sck.Print();

        //var que = new Utils.Queue<int>();
        //que.EnQueue(1);
        //que.EnQueue(2);
        //que.EnQueue(3);
        //que.EnQueue(5);
        //que.DeQueue();
        //que.EnQueue(4);
        //que.Print();
        #endregion

        #region "  LinkedList "
        //var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //list.head.Next = new SinglyLinkedListNode<int>(2);
        //list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //list.head.Next.Next.Next = new SinglyLinkedListNode<int>(4);
        //list.Print(list.head);
        //var msLinkedList = new MS_LINKED_LIST();
        //msLinkedList.DeleteNode(list.head, 4);
        //list.Print(list.head);

        //var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //list.head.Next = new SinglyLinkedListNode<int>(2);
        //list.head.Next.Next = new SinglyLinkedListNode<int>(2);
        //list.head.Next.Next.Next = new SinglyLinkedListNode<int>(3);
        //list.Print(list.head);
        //var msLinkedList = new MS_LINKED_LIST();
        //msLinkedList.RemoveDuplicates(list.head);
        //list.Print(list.head);

        //var list = new MyLinkedList<int>(new SinglyLinkedListNode<int>(1));
        //list.head.Next = new SinglyLinkedListNode<int>(2);
        //list.head.Next.Next = new SinglyLinkedListNode<int>(3);
        //list.head.Next.Next.Next = new SinglyLinkedListNode<int>(4);
        //list.head.Next.Next.Next.Next = new SinglyLinkedListNode<int>(5);
        //list.Print(list.head);
        //var msLinkedList = new MS_LINKED_LIST();
        //list.Print(msLinkedList.FindKThElementToLast(list.head,2));

        //var list = new MyLinkedList<string>(new SinglyLinkedListNode<string>("p"));
        //list.head.Next = new SinglyLinkedListNode<string>("o");
        //list.head.Next.Next = new SinglyLinkedListNode<string>("o");
        //list.head.Next.Next.Next = new SinglyLinkedListNode<string>("w");
        ////list.head.Next.Next.Next.Next = new SinglyLinkedListNode<string>("l");
        //list.Print(list.head);
        //var msLinkedList = new MS_LINKED_LIST();
        //Console.WriteLine(msLinkedList.IsPalinDrome(list.head));
        #endregion

        #region "  Trees & Graphs "
        //var msTree = new MS_Tree();
        //var root = new TreeNode<int>(1);
        //root.left = new TreeNode<int>(2);
        //root.right = new TreeNode<int>(3);
        //root.right.right = new TreeNode<int>(4);
        //root.right.right.right = new TreeNode<int>(5);
        //Console.WriteLine(msTree.IsBalanced(root));
        //var msTree = new MS_Tree();
        //var root = new TreeNode<int>(1);
        //root.left = new TreeNode<int>(2);
        //root.right = new TreeNode<int>(3);
        //root.left.left = new TreeNode<int>(4);
        //root.left.right = new TreeNode<int>(5);
        //root.right.left = new TreeNode<int>(6);
        //root.right.right = new TreeNode<int>(7);
        //msTree.Traverse(root, Traversals.PreOrder);
        //var msTree = new MS_Tree();
        //var root = new TreeNode<int>(5);
        //root.left = new TreeNode<int>(3);
        //root.right = new TreeNode<int>(7);
        //root.left.left = new TreeNode<int>(2);
        //root.right.left = new TreeNode<int>(6);
        //root.right.right = new TreeNode<int>(8);
        ////root = msTree.Insert(root, 4);
        ////msTree.DFSTraverse(root, Traversals.InOrder);
        //msTree.BFSTraverse(root);
        //var node = msTree.MinimalTree(new int[] { 1, 2, 3, 4, 5, 6, 7 });
        //msTree.DFSTraverse(node, Traversals.InOrder);
        //var root = new TreeNode<int>(4);
        //root.left = new TreeNode<int>(2);
        //root.right = new TreeNode<int>(7);
        //root.left.left = new TreeNode<int>(1);
        //root.left.right = new TreeNode<int>(3);
        //root.right.left = new TreeNode<int>(6);
        //root.right.right = new TreeNode<int>(9);
        ////var reversed = msTree.InvertBinaryTree(root);
        ////msTree.BFSTraverse(reversed);
        //Console.WriteLine(msTree.MinimalDepth(root));

        #endregion

        #region " Graph "
        //var msGraph = new MS_Graph();
        //var node1 = new GraphNode<int>(1);
        //var node2 = new GraphNode<int>(2);
        //var node3 = new GraphNode<int>(3);
        //var node4 = new GraphNode<int>(4);
        //var node5 = new GraphNode<int>(5);
        //var node0 = new GraphNode<int>(0);
        //node0.adjacent.Add(node1);
        //node0.adjacent.Add(node4);
        //node0.adjacent.Add(node5);
        //node1.adjacent.Add(node4);
        //node1.adjacent.Add(node3);
        //node3.adjacent.Add(node2);
        //node3.adjacent.Add(node3);
        //node2.adjacent.Add(node1);
        //var grph = new Utils.Graph<int>();
        //grph.nodes.Add(node0);
        //Console.WriteLine(msGraph.RouteBetweenNode(grph, node2, node5));
    }
    #endregion

    #region " Dynamice Prog "
    //Dynamic Programming
    //var dyn = new Microsoft.MS_Dyn_Prog();
    //Console.WriteLine(dyn.MagicIndex(new int[] {-12,-8,0,1,2,3,6,7,9,10 }, true));
    #endregion


    #endregion




    //}
}

