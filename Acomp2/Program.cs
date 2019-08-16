using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Linq;
using Xunit;

namespace Acomp2
{
    public class Program
    {

        public class Tests
        {

            [Params(100, 1000, 10000)]
            public int N { get; set; }

            [Benchmark]
            public void BestBubbleSortTest()
            {
                (new BubbleSort()).Sort(new BestArray(N).Array, N);
            }

            [Benchmark]
            public void RandomBubbleSortTest()
            {
                (new BubbleSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstBubbleSortTest()
            {
                (new BubbleSort()).Sort(new WorstArray(N).Array, N);
            }

            [Benchmark]
            public void BestSelectionSortTest()
            {
                (new SelectionSort()).Sort(new BestArray(N).Array, N);
            }

            [Benchmark]
            public void RandomSelectionSortTest()
            {
                (new SelectionSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstSelectionSortTest()
            {
                (new SelectionSort()).Sort(new WorstArray(N).Array, N);
            }

            [Benchmark]
            public void BestInsertionSortTest()
            {
                (new InsertionSort()).Sort(new BestArray(N).Array, N);
            }

            [Benchmark]
            public void RandomInsertionSortTest()
            {
                (new InsertionSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstInsertionSortTest()
            {
                (new InsertionSort()).Sort(new WorstArray(N).Array, N);
            }

        }

        [Fact]
        public static void BubbleSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[]) A.Clone();
            new BubbleSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }

        [Fact]
        public static void SelectionSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[]) A.Clone();
            new SelectionSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }

        [Fact]
        public static void InsertionSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[]) A.Clone();
            new InsertionSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
            Console.Read();
        }
    }
}
