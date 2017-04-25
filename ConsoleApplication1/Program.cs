using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test321 = GetPrime(10);
            char[] c = new char[10];
            String s = new string(c);
            var ddddds = FirstReverse("Babin Saha");

                        var noDup = FindAllDupsInArray(new int[] { 1, 1, 2, 4, 5, 6, 7, 4, 4, 4, 3 });
            var dup = printRepeating(new int[] { 100, 1, 2, 4, 5, 6, 7, 4, 4, 4, 3 });

            int[] array = new int[] { 5, 1, 2, 6, 8, 3 };
            var testInsertionSort = InsertionSort(array);
            var strPal = GetLongestPalindrome("bananas");
            int romi = 1;
            int babin = 2;

            QueueBS q = new QueueBS(10);

            for (int i = 11; i < 200; i += 10)
            {
                if (!q.IsFull())
                {
                    q.Enqueue(i);
                }

            }

            var v = q.Dequeue();
            v = q.Dequeue();
            q.Enqueue(201);
            v = q.Dequeue();



            CTestDerived cd = new CTestDerived("AA");
            cd.Method1();
            var name = "babin";
            var title = "saha";
            var val = $"{name} and title {title}";

            Array ar = Array.CreateInstance(typeof(int), 10);
            ar.Initialize();



            TestB ba = new TestA();
            Console.WriteLine(ba.Method1());

            TestA a = new TestA();
            Console.WriteLine(a.Method1());
            TestB b = new TestB();
            Console.WriteLine(b.Method1());

            Console.ReadLine();
        }

        static void MethodA(string a)
        {
            Console.WriteLine(a);
        }

        static void MethodB(ref string a)
        {
            a = "Method B";
        }

        private static List<int[]> AllTwoSumValues(List<int> targetArray, int sumValue)
        {
            List<int[]> lstResult = new List<int[]>();

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int i = 0;
            targetArray.ForEach(x => { dic.Add(i, x); i++; });

            var hs = new HashSet<int>();
            targetArray.ForEach(x => hs.Add(x));


            foreach (int j in targetArray)
            {
                int[] indexArray = new int[2];
                int diff = sumValue - j;
                var test = dic.Where(k => k.Value == diff);
                var test2 = dic.Where(k => k.Value == diff).Select(r => new int[] { dic[r.Key], j }).FirstOrDefault();
                if (test2 != null && test2.Count() > 0 && !lstResult.Any(s => s.Contains(j)))
                {
                    lstResult.Add(test2.ToArray());
                }
            }

            return lstResult;
        }

        public static string FirstReverse(string str)
        {

            // code goes here  
            /* Note: In C# the return type of a function and the 
               parameter types being passed are defined, so this return 
               call must match the return type of the function.
               You are free to modify the return type. */
            char[] ca = new char[str.Length];
            Console.WriteLine("test");
            int iCounter = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
                ca[iCounter] = str[i];
                iCounter++;
            }

            return new string(ca);

        }
        static List<int> GetPrime(int limit)
        {

            List<int> lstPrimeNumber = new List<int>();
            bool isPrime;

            for (int i = 2; i <= limit; i++)
            {
                isPrime = true;
                for (int j = 2; j <= limit; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                    lstPrimeNumber.Add(i);
            }


            return lstPrimeNumber;
        }
        //2 3 4 5 2 10, -2, 4, 5 6 4

        //1 1 2 4 5 6 7 4 4 4 3
        static List<int> FindAllDupsInArray(int[] array)
        {
            List<int> result = new List<int>();
            List<int> final = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {

                if (!result.Contains(array[i]))
                    result.Add(array[i]);
                else
                    final.Add(array[i]);



            }

            return final;
        }
        static List<int> printRepeating(int[] arr)
        {
            List<int> final = new List<int>();
            HashSet<int> hSet = new HashSet<int>(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {


            }
            return final;
        }



        private static string GetLongestPalindrome(string input)
        {
            int rightIndex = 0, leftIndex = 0;
            var x = "";
            string currentPalindrome = string.Empty;
            string longestPalindrome = string.Empty;
            for (int currentIndex = 1; currentIndex < input.Length - 1; currentIndex++)
            {
                leftIndex = currentIndex - 1;
                rightIndex = currentIndex + 1;
                while (leftIndex >= 0 && rightIndex < input.Length)
                {
                    if (input[leftIndex] != input[rightIndex])
                    {
                        break;
                    }
                    currentPalindrome = input.Substring(leftIndex, rightIndex - leftIndex + 1);
                    if (currentPalindrome.Length > x.Length)
                        x = currentPalindrome;
                    leftIndex--;
                    rightIndex++;
                }
            }
            return x;
        }
        

        //{5, 1, 6, 2, 4, 3}

        static int[] InsertionSort(int[] array)
        {

            int key, i, j;

            for (i = 1; i <= array.Length - 1; i++)
            {
                key = array[i]; //i2 v6
                j = i - 1; //j1
                //for (j = 0; j <= array.Length - 1; j++)
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            return array;
        }


        static int[] BubbleSort(int[] inputArray)
        {
            //int[] sortedArray = new int[inputArray.Length];

            for (int main = 0; main < inputArray.Length; main++)
            {
                for (int sub = 0; sub < inputArray.Length - 1 - main; sub++)
                {
                    if (inputArray[sub] > inputArray[sub + 1])
                    {
                        int temp = inputArray[sub];
                        inputArray[sub] = inputArray[sub + 1];
                        inputArray[sub + 1] = temp;
                    }
                }
            }

            return inputArray;
        }
    }





    [Serializable]
    public class CTestBase
    {
        public CTestBase(string name)
        {
            Console.WriteLine("BAse class's Name " + name);
        }
        public void Method1()
        {
            Console.WriteLine("Method 1 form Base class");
        }

        [System.Runtime.Serialization.DataMember]
        public string name { get; set; }
    }
    public class CTestDerived : CTestBase
    {
        public CTestDerived(string name) : base(name)
        {

            Console.WriteLine("Derived class's Name " + name);
        }
        public void Method1()
        {
            Console.WriteLine("Method 1 form Derived class");
        }
    }

    public class TestB
    {
        public virtual string Method1() { return "TestB Method 1 " + this.GetType().Name; }

        //public async Task<string> GetJobAsync()
        //{
        //    return "";
        //}
    }

    public class TestA : TestB
    {
        public override string Method1()
        {
            return "TestA new Method 1 " + this.GetType().Name;

        }
    }



    public class Test : ITest
    {

        public void MyJob(int i) { }
        private int MyJob(double i) { return (int)i; }
        public void test()
        {
            (this as ITest).test();
            Console.WriteLine("I am from Test class 1");
        }
        void ITest.test()
        {
            Console.WriteLine("I am from Test class implementing ITest 2");
        }
    }

    public interface ITest
    {
        void test();
    }
}
