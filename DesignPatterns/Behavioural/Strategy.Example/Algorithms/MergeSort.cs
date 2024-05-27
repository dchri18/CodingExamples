using Strategy.Example.Interfaces;

namespace Strategy.Example.Algorithms
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting using Merge Sort");
            MergeSortHelper(list, 0, list.Count - 1);
        }

        private void MergeSortHelper(List<int> list, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSortHelper(list, left, mid);
                MergeSortHelper(list, mid + 1, right);

                Merge(list, left, mid, right);
            }
        }

        private void Merge(List<int> list, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            List<int> L = new List<int>(n1);
            List<int> R = new List<int>(n2);

            for (int i = 0; i < n1; ++i)
                L.Add(list[left + i]);
            for (int j = 0; j < n2; ++j)
                R.Add(list[mid + 1 + j]);

            int i_index = 0, j_index = 0;

            int k = left;
            while (i_index < n1 && j_index < n2)
            {
                if (L[i_index] <= R[j_index])
                {
                    list[k] = L[i_index];
                    i_index++;
                }
                else
                {
                    list[k] = R[j_index];
                    j_index++;
                }
                k++;
            }

            while (i_index < n1)
            {
                list[k] = L[i_index];
                i_index++;
                k++;
            }

            while (j_index < n2)
            {
                list[k] = R[j_index];
                j_index++;
                k++;
            }
        }
    }
}
