using System;

class InsertionSort
{
    static void Main()
    {
        int[] arr = {5,3,8,1,2};


        for(int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];

            int j = i - 1;


            while(j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];

                j--;
            }


            arr[j + 1] = key;
        }


        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }
    }
}