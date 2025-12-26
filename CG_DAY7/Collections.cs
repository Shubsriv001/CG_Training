using System;
using System.Collections;
using System.Collections.Generic;
class Collections{

public static void Main(string[] args)
    {



// NOTE:

// Here we are using 'Count' for accessing the length of the Collections not the Length:- Length is only used in array,string 
// ------------------------------------List-------------------------------


//=================================Some Inbuild Methods============================
// ------------------------------------(1)-Add(T item)-----------------------------------------

//  – Adds an item to the end of the list.

// List<int> numbers = new List<int>();
// numbers.Add(1);  // Adds 1
// ------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ------------------------------------(2)-Remove(T item)-----------------------------------------
//  – Removes the first occurrence of a specific item.

// numbers.Remove(1);  // Removes 1

// ------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ------------------------------------(2)-RemoveAt(int index)-----------------------------------------

//  – Removes an item at a specific index.

// numbers.RemoveAt(0);  // Removes the item at index 0

// ------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ------------------------------------(3)- Contains(T item)-----------------------------------------


// – Checks if the list contains a specific item.

// bool hasNumber = numbers.Contains(1);  // Returns true if 1 exists

// ------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ------------------------------------(4)- IndexOf(T item) -----------------------------------------


// – Returns the index of the first occurrence of an item.

// int index = numbers.IndexOf(1);  // Returns the index of 1

// ------------------------------------------------------------------------------

//==============================//===================//===========================//==================



// ------------------------------------(5)- Clear() -----------------------------------------
//  – Removes all items from the list.

// numbers.Clear();  // Clears the entire list

// ------------------------------------------------------------------------------



//==============================//===================//===========================//==================



// ------------------------------------(6)- Count -----------------------------------------
// – Returns the number of elements in the list.

// int count = numbers.Count;  // Returns the count of items


// ---------------------------------------List Implementation---------------------------------------------------

// List<int> numbers = new List<int> { 1, 2, 3 };
// numbers.Add(4);

// for (int i = 0; i < numbers.Count; i++)
// {
//     Console.WriteLine(numbers[i]);
// }


// ==================================================================================================


// ---------------------------------------(1) Add(TKey key, TValue value)---------------------------------------------------


//  – Adds a key-value pair to the dictionary.

// Dictionary<int, string> dict = new Dictionary<int, string>();
// dict.Add(1, "One");  // Adds key-value pair (1, "One")


// ------------------------------------------------------------------------------------------------------------------


//==============================//===================//===========================//==================


// ---------------------------------------(2) Remove(TKey key)---------------------------------------------------

// – Removes a key-value pair by the key.

// dict.Remove(1);  // Removes the pair with key 1

// ------------------------------------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ---------------------------------------(3) ContainsKey(TKey key)---------------------------------------------------

// ContainsKey(TKey key) – Checks if the dictionary contains a specific key.

// bool hasKey = dict.ContainsKey(1);  // Returns true if the key exists

// ------------------------------------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ---------------------------------------(4) TryGetValue(TKey key, out TValue value)---------------------------------------------------

//  – Attempts to get the value for a given key.

// if (dict.TryGetValue(1, out string value)) {
//     Console.WriteLine(value);  // "One"
// }

// ------------------------------------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ---------------------------------------(6) Keys---------------------------------------------------

//  – Gets a collection of all the keys.

// var keys = dict.Keys;  // Gets all keys in the dictionary


// ------------------------------------------------------------------------------------------------------------

//==============================//===================//===========================//==================

// ---------------------------------------(7) Values---------------------------------------------------

//  – Gets a collection of all the values.

// var values = dict.Values;  // Gets all values in the dictionary

// ------------------------------------------------------------------------------------------------------------


//==============================//===================//===========================//==================




// --------------------------------Dictionary Implementation---------------------------------
//this will store the data in the form of key value form

// Dictionary<int, string> students = new Dictionary<int, string>();
// students.Add(1, "Ram");
// students[2] = "Shyam";

// Console.WriteLine(students[1]); // Ram



// -------------------------------------------Sorted List-------------------------------------------------




// SortedList<int, string> marks = new SortedList<int, string>();
// marks.Add(3, "C");
// marks.Add(1, "A");
// marks.Add(2, "B");

// foreach (var item in marks)
//     Console.WriteLine(item.Key + " " + item.Value);


// -------------------------------------------Stack----------------------------

// Stack<int> stack = new Stack<int>();
// stack.Push(1);
// stack.Push(2);

// Console.WriteLine(stack.Pop());  // 2
// Console.WriteLine(stack.Peek()); // 1


// -----------------------------------------------Queue----------------------------


// Queue<int> queue = new Queue<int>();
// queue.Enqueue(1);
// queue.Enqueue(2);

// Console.WriteLine(queue.Dequeue()); // 1


// -----------------------------------------------Array List----------------------------


// ArrayList list = new ArrayList();
// list.Add(10);
// list.Add("Hello");
// list.Add(5.5);

// foreach (var item in list)
//     Console.WriteLine(item);


// -------------------------ArrayList--------------------------

// ArrayList list1= new ArrayList();
// list1.Add(10);
// list1.Add(20);
// list1.Add(30);
// for(int i=0;i<list1.Count;i++)
//         {
            
//             Console.WriteLine(list1[i]);
//         }
        
// -----------------------------Hash Table----------------------

// Hashtable ht = new Hashtable() ;

// ht.Add(1, "Admin");
//  ht.Add(2," User") ;

// Console.WriteLine(ht[1]);



// ---------------------------------------------------------------


// Below thi is using the System.Collections which is older version and have pronbelmm as It can add any data type value int_string etc;
// -----------------------------Stack----------------------



// Stackstack = new Stack();
// stack.Push(10);
// stack.Push(20);

// Console.WriteLine(stack.Pop());

// -----------------------------Queue----------------------


// Queue queue =new Queue();
// queue.Enqueue(10);
// queue.Enqueue(20);

// Console.WriteLine(queue.Dequeue());


// -------------------------------------------
//================//===============//===============//===============


//Below is the code comes under the System.Collection.Generic

// Dictionary<int, string> users = new Dictionary<int, string>();

// users.Add(1, "Shubhanshu");
// Console.WriteLine(users[1]); 


//================//===============//===============//===============



// -----------------------------------Hash Set--------------------------


// HashSet<int> hasSet=new HashSet<int>();
// hasSet.Add(1);
// hasSet.Add(1);// Duplicate value get Ignore and not be adden in the HashSet..
// hasSet.Add(2);

// foreach(int i in hasSet)
//         {
            
// Console.WriteLine(i);
//         }
    }
}