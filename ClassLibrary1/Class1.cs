namespace ClassLibrary1

{

    public class Class1

    {

        public static int Name(int[,] arr)

        {

            int res = 0;

            int minSum = 2147483647;

            for (int j = 0; j < arr.GetLength(1); j++)

            {

                int sum = 0;

                for (int i = 0; i < arr.GetLength(0); i++)

                {

                    sum += arr[i, j];

                }

                if (minSum > sum) { minSum = sum; res = j; }

            }

            return res;

        }

    }

}
