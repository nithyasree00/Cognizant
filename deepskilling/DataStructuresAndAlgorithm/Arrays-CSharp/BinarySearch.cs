using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};

        int target = 40;


        int low=0;

        int high=arr.Length-1;


        while(low<=high)
        {

            int mid=(low+high)/2;


            if(arr[mid]==target)
            {
                Console.WriteLine(mid);
                break;
            }


            else if(arr[mid]<target)
            {
                low=mid+1;
            }


            else
            {
                high=mid-1;
            }

        }
    }
}