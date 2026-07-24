using System;

class QuickSort
{


    static int Partition(int[] arr,int low,int high)
    {

        int pivot=arr[high];


        int i=low-1;


        for(int j=low;j<high;j++)
        {

            if(arr[j]<pivot)
            {

                i++;


                int temp=arr[i];

                arr[i]=arr[j];

                arr[j]=temp;

            }

        }


        int temp2=arr[i+1];

        arr[i+1]=arr[high];

        arr[high]=temp2;


        return i+1;

    }




    static void QuickSortMethod(int[] arr,int low,int high)
    {

        if(low<high)
        {

            int pi=Partition(arr,low,high);


            QuickSortMethod(arr,low,pi-1);


            QuickSortMethod(arr,pi+1,high);

        }

    }



    static void Main()
    {

        int[] arr={5,3,8,1,2};


        QuickSortMethod(arr,0,arr.Length-1);


        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }

    }

}