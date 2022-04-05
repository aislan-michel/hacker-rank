namespace Arrays_DS
{
    public static class Result
    {
        public static List<int> ReverseArray(List<int> arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (!arr.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(arr));
            }

            var reversedArray = new List<int>() { Capacity = arr.Length() };
            
            for (int i = arr.Length(); i >= 0; i--)
            {
                reversedArray.Add(arr[i]);
            }

            return reversedArray;
        }

        private static int Length(this List<int> list)
        {
            return list.Count - 1;
        }
    }
}