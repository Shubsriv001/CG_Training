using System;
class Collections{

public static void Main(string[] args)
    {



// NOTE:

// Here we are using 'Count' for accessing the length of the Collections not the Length:- Length is only used in array,string 
// ------------------------------------List-------------------------------

List<int> numbers = new List<int> { 1, 2, 3 };
numbers.Add(4);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



// --------------------------------Dictionary---------------------------------
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



    }
}