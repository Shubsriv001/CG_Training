// using System;
// namespace Christmas
// {
    
// class Employee
// {
//      int Eno;
//      double Salary;
//      string Ename,job,Location;

//     public Employee(int Eno, double Salary, string Ename, string job, string Location)
//     {
//         this.Eno=Eno;
//         this.Ename=Ename;
//         this.job=job;
//         this.Location=Location;
//         this.Salary=Salary;
//     }

// // Below is the example of Indexer Creation
// // [ Modifiers <datatype> this[<data type> parameter] ]
// // object data type allow all the data type to access

// // 1)Below is the example of Accessing the data using the index

//     public Object this[int index]{
// //get is Using to access the data
//     get{
//                 if (index == 0)
//                 {
//                     return Eno;
//                 }
//                 else if(index == 1)
//                 {
//                     return Salary;
//                 }
//                 else if(index == 2)
//                 {
//                     return Ename;
//                 }
//                 else if(index == 3)
//                 {
//                     return job;
//                 }
//                 else if(index == 4)
//                 {
//                     return Location;
//                 }
//                 else
//                 {
//                     return null;
//                 }
//     }
//     //set is used to initialise the data the member data

//             set
//             {
//                 if (index == 0)
//                 {
//                     //value is the implicit value that is assigned to the instance member
//                     Eno=(int)value;
//                     //Unboxing method is use to convert object into data value
//                 }

//                 else if (index == 1)
//                 {
//                     Salary=(double)value;
//                 }
//                 else if (index == 2)
//                 {
//                     Ename=(string)value;
//                 }
//                 else if (index == 3)
//                 {
//                     job=(string)value;
//                 }
//                 else if (index == 4)
//                 {
//                     Location=(string)value;
//                 }
//             }


            
//     }



//     // 2)------------------------------Access And Update Using Name-------------------------------------------------

//     public Object this[string name]{
// //get is Using to access the data
//     get{
//                 if (name.ToUpper() =="ENO" )
//                 {
//                     return Eno;
//                 }
//                 else if(name.ToUpper() == "SALARY")
//                 {
//                     return Salary;
//                 }
//                 else if(name.ToUpper() =="ENAME" )
//                 {
//                     return Ename;
//                 }
//                 else if(name.ToUpper() == "JOB")
//                 {
//                     return job;
//                 }
//                 else if(name.ToUpper() == "LOCATION")
//                 {
//                     return Location;
//                 }
//                 else
//                 {
//                     return null;
//                 }
//     }
//     //set is used to initialise the data the member data

//             set
//             {
//                 if (name.ToUpper() == "ENO")
//                 {
//                     //value is the implicit value that is assigned to the instance member
//                     Eno=(int)value;
//                     //Unboxing method is use to convert object into data value
//                 }

//                 else if (name.ToUpper() == "SALARY")
//                 {
//                     Salary=(double)value;
//                 }
//                 else if (name.ToUpper() == "ENAME")
//                 {
//                     Ename=(string)value;
//                 }
//                 else if (name.ToUpper() == "JOB")
//                 {
//                     job=(string)value;
//                 }
//                 else if (name.ToUpper() == "LOCATION")
//                 {
//                     Location=(string)value;
//                 }
//             }



//     }
// }
// }