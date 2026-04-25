namespace Delegates
{
    internal class Program
    {
        public void fun1()
        {
            Console.WriteLine("fun1 calling");
        }

        public void fun2()
        {
            Console.WriteLine("fun2 calling");
        }

        public void fun3()
        {
            Console.WriteLine("fun3 calling");
        }

        public delegate void myDel();

        static void Main(string[] args)
        {

            Program prog1 = new Program();
            myDel del = new myDel(prog1.fun1);
            del += prog1.fun2;      // adding function in delegate
            del += prog1.fun3;      // adding function in delegate

            del -= prog1.fun2;      // removing function from delegate


            del();                  // calling delegate

            

        }
    }

}

/* VVIMP topic
 * method address and reference 
 * delegates is a type safe reference to a method it means delegaates can store address of a method and call it later.
 * delegates is a variable that points to a function.
 * 
 * Why we use
 * used in event handling programms.
 * when we call one function repetadely then it may cause low performance then we use deligates.
 * delegate is a mediator between function and object
 * 
 * 
 * single cast delegate :-
 *  - 
 * 
 * multicast delegate
 * 
 * 
 * 
 * 
 * 
 * 
 * 
*/