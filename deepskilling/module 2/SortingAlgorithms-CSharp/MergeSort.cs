using System;

class MergeSort
{

    static void Merge(int[] arr,int left,int mid,int right)
    {

        int n1 = mid-left+1;

        int n2 = right-mid;


        int[] L = new int[n1];

        int[] R = new int[n2];


        for(int i=0;i<n1;i++)
        {
            L[i]=arr[left+i];
        }


        for(int j=0;j<n2;j++)
        {
            R[j]=arr[mid+1+j];
        }


        int a=0;

        int b=0;

        int k=left;


        while(a<n1 && b<n2)
        {

            if(L[a]<=R[b])
            {
                arr[k]=L[a];

                a++;
            }
            else
            {
                arr[k]=R[b];

                b++;
            }

            k++;
        }


        while(a<n1)
        {
            arr[k]=L[a];

            a++;
            k++;
        }


        while(b<n2)
        {
            arr[k]=R[b];

            b++;
            k++;
        }

    }



    static void MergeSortMethod(int[] arr,int left,int right)
    {

        if(left<right)
        {

            int mid=(left+right)/2;


            MergeSortMethod(arr,left,mid);

            MergeSortMethod(arr,mid+1,right);


            Merge(arr,left,mid,right);

        }

    }



    static void Main()
    {

        int[] arr={5,3,8,1,2};


        MergeSortMethod(arr,0,arr.Length-1);


        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }

    }

}