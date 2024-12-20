namespace BinarySearch
{
    internal class Program
    {
        static int binarySearch(int[] arr, int item)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if(arr[mid] == item) return mid;
                if (arr[mid] < item) left = mid + 1;
                else right = mid - 1; 
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"This is target {binarySearch([1, 3, 6], 6)}");
        }
    }
}
