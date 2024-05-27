using Strategy.Example.Algorithms;

namespace Strategy.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortContext context = new SortContext();

            List<int> list = new List<int> { 34, 7, 23, 32, 5, 62 };

            context.SetSortStrategy(new BubbleSort());
            context.Sort(list);
            Console.WriteLine(string.Join(", ", list));

            list = new List<int> { 34, 7, 23, 32, 5, 62 };
            context.SetSortStrategy(new QuickSort());
            context.Sort(list);
            Console.WriteLine(string.Join(", ", list));

            list = new List<int> { 34, 7, 23, 32, 5, 62 };
            context.SetSortStrategy(new MergeSort());
            context.Sort(list);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
