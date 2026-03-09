// using System;

// // step1: Declare a delegate
// class Button
// {
//     public delegate void ClickHandler();

//     // step2: Declare an event
//     public event ClickHandler Clicked; // Clicked is the name of the event

//     // step3: Method that raises the event
//     public void Click()
//     {
//         Clicked?.Invoke();
//     }

//     public void display()
//     {
        
//     }

// }

// class Events
// {
//     public static void Main()
//     {
//         Button btn = new Button();

//         // step4: Subscribe to the event
//         btn.Clicked += () => Console.WriteLine("Button was clicked!");

//         // step5: Trigger the event
//         btn.Click();
//     }
// }
// =================//========================//==============================//======================


// using System;

// class Button
// {
//     // Delegates
//     public delegate void ClickHandler();
//     public delegate void HoverHandler();

//     // Multiple events
//     public event ClickHandler Clicked;
//     public event HoverHandler Hovered;

//     // Methods to raise events
//     public void OnClick()
//     {
//         Clicked?.Invoke();
//     }

//     public void OnHover()
//     {
//         Hovered?.Invoke();
//     }
// }

// class Events
// {
//     public static void Main()
//     {
//         Button btn = new Button();

//         // Subscribe events
//         btn.Clicked += () => Console.WriteLine("Button clicked");
//         btn.Hovered += () => Console.WriteLine("Button hovered");

//         // Trigger events
//         btn.OnClick();
//         btn.OnHover();
//     }
// }

// ==========================//==========================//=====================================//=============================
