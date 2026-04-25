using System.Collections;

namespace GenericsAndLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generics used for type safety
            // with a place holder or datatype so they work with any type while maintaing type safety.
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Swapnil");
            //no type safety runtime error


            //generic example
            List<int> numbers = new List<int>();    
            numbers.Add(10);
            numbers.Add(20);
            // numbers.Add("Swapnil");     //Error
            // compile time checking, strict type check, no need to require type conversion

            MyClass<int> obj = new MyClass<int>();
            obj.Data = 100;

            MyClass<string> obj1 = new MyClass<string>();
            obj1.Data = "Swapnil";

            Console.WriteLine(obj.Data);

            Console.WriteLine(obj1.Data);

            // we introduce generics for typesafety for classes, functions , and collections


            // Lambda Expression
            // Lambda expression is a short way to write anonomous methods using the arrow => operator 
            // syntax : (parameters) => expression
            // Examples:-

            // Lambda Expression with list
            List<int> numbers1 = new List<int>();
            numbers1.Add(10);
            numbers1.Add(20);
            numbers1.Add(30);
            numbers1.Add(13);

            var even = (numbers1.Where(n => n % 2 == 0));

            foreach (var no in even)
            {
                Console.WriteLine(no);
            }

            // async sync in C#
            // two types of programming in C# 
             //1. Synchronous programming  - Task exicutes one by one (one af)
             //2. Asynchronous programming

        }
    }

    class MyClass<T>
    {
        public T Data;
        public void fun()
        {
            Console.WriteLine(Data);
        }

    }


}

// Activities 24/02/2026
// write 2 Ex with Generics
// where we use generics in company level
// lambda Expression in C#


// write 2 Ex of lambda expression 
// where lambda is used in company
// create a generic class to store two values 
// what is generics, why generic is better than ArrayList
// what is constraint in generics 
// what  is lambda ex
// dffrence between lambda and delegate

