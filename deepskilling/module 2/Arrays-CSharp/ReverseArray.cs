using System;

class ReverseArray
{
    static void Main()
    {
        int[] arr={10,20,30,40,50};


        int start=0;

        int end=arr.Length-1;



        while(start<end)
        {

            int temp=arr[start];

            arr[start]=arr[end];

            arr[end]=temp;


            start++;

            end--;

        }



        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }

    }
}