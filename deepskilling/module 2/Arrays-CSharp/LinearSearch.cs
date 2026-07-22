using System;

class LinearSearch
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        int target = 30;

        int index = -1;


        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==target)
            {
                index=i;
                break;
            }
        }


        Console.WriteLine(index);
    }
}