// using System;
// using System.ComponentModel.DataAnnotations.Schema;
// class Arrays
// {
//     public static void Main(string[] args)
//     {
        // Array declararion.
        // int [] numbers;

        //Array initialization with size.
        // int []numbers =new int[5];

        //Array initialization with value
        // int[]numbers={1,2,3,4,5,6,7,8,9,10};

        // foreach(int num in numbers)
        // {
        //     Console.Write(num+" ");
        // }
        // int i=0;
        // double sum=0;
        // double avg;
        // while (i < numbers.Length)
        // {
        
        //     Console.Write(numbers[i]+" ");
        //     sum+=numbers[i];
        //     i++;
        // }
        //     avg=sum/numbers.Length;
        //     Console.Write(avg);


// -------------------------------------------------------------------------------

// 2D Array


// int [,]matrix=new int [2,2];

// int[,] matrix =
//         {
//             {1,2,5},
//             {3,4,8}
//         };

//this below code will access the value

// Console.WriteLine(matrix[1,1]);

        // This loop represent the number of rows
        // for(int i = 0; i < 2;i++)
        // {
        // // This loop represent the number of column
        //     for(int j = 0; j < 3;j++)
        //     {
        //         Console.Write(matrix[i,j]+" ");
        //     }
        // }



// ----------------------------------------------------------------------------

//---------------------------------------------Jagged Array---------------------

// Declaration

// int [][]jagged=new int[2][];

// Initialization

//here 0 and 1 represent the rows
// jagged[0]=new int[]{1,2};
// jagged[1]=new int[]{3,4,5,};


//Accessing values

// jagged[rowIndex][ColimnIndex];

// Console.WriteLine(jagged[1][2]);

//Printing all the element of the jagged array


// Outer loop → goes through each row

// for(int i = 0; i < jagged.Length; i++)
//         {
// // Inner loop → goes through elements of that row
//          for(int j = 0; j<jagged[i].Length; j++)
//             {
                
// Console.Write(jagged[i][j]+"  ");
//             }
//         }



// ------------------------------------System.Array Methods-----------------------

// int[] arr = {1,2,3,4,5,6,7,8,9,10};

// -------------------------------------------------------------------------------

// foreach (int i in arr)
// {
//     Console.Write(i + " ");
// }
// -------------------------------------------------------------------------------

//Name of the array, startIndex and Length of the array.

// Array.Clear(arr, 2, arr.Length-2);
// Array.Clear(arr, 0,2);
// Console.WriteLine();

// foreach (int i in arr)
// {
//     Console.Write(i + " ");
// }

// -------------------------------------------------------------------------------

// ----------------------------Copy Array--------------------------------------

// int[] arr = {1,2,3,4,5,6,7,8,9,10};
// int[] arr = {1,2,3,4,5,6,7,8,9,10};
// int[]dest=new int[3];


// // Src Array, dest Array, length of the destination that how much you want to add or copy.
// Array.Copy(arr,dest,3); //1,2,3
// Array.Copy(arr,dest,2); //1,2,0
// Array.Copy(arr,dest,1); //1,0,0

// foreach(int a in dest)
//         {
//             Console.WriteLine(a+" ");
//         }



//-----------------------------Resize Array--------------------------

// int[] arr = {1,2,3,4,5,6,7,8,9,10};
// int[] nums1 = {1,2,3,4,5,6,7,8,9,10};

// Console.Write(arr.Length); //10

// // Ref for passing the addredss of the array then the 
// Array.Resize(ref arr, 11);
// Console.Write(arr.Length);//11


// ---------------------------Index Of--------------------------------------------

// int[] arr = {1,2,3,4,5,6,7,8,9,10};


// Console.Write(Array.IndexOf(arr, 2));


// ---------------------------Array.Exists()--------------------------------------------
// Check wheather the condition is met by any of the element of the  array and return the value as boolean

// int[] arr = {1,2,3,4,5,6,7,8,9,10};

// Console.Write(Array.Exists(arr, x => x >= 10));

//     }
// }