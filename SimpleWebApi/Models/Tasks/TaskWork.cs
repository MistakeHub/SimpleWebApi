namespace SimpleWebApi.Models.Tasks
{
    public static class TaskWork
    {
       public static int Task1(int[] array)
        {
            int count = 0;
            int sum = 0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                    if (count >= 2) { sum += Math.Abs(array[i]); count = 0; }


                }

            }
            return sum;
        }

        public static bool Task2(string text)
        {
            string textwithoutspace = text.Replace(" ", "").ToLower();
            string reversed = new string(textwithoutspace.Reverse().ToArray());
            var result = textwithoutspace ==reversed;
            return result;

        } 

        public static CustomList<T> Task3<T>(T[] array) where T : IComparable<T>
        {
            CustomList<T> list = new CustomList<T>(array);
            list.Sort();
            return list;

        }
        
    }
}
