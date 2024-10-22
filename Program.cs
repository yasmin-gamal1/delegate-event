//namespace delegates
//{

#region define deleate
//public delegate int operation(int x, int y);
//class Program
//{
//    static int Addition(int a, int b) {
//        return a + b;
//    }
//    static void Main()
//    {
//        operation obj = new operation(Program.Addition);
//        Console.WriteLine("Addition i={0}", obj(23, 27)); 

//    }
//}
#endregion

//#region 2.Array of Delegates
//public class operation
//{
//    public static void Add(int a, int b)
//    {
//        Console.WriteLine("Addition = {0}", a + b);
//    }
//    public static void Multiply(int a, int b)
//    {
//        Console.WriteLine("Multiply = {0}", a * b);
//    }
//}

//class program
//{
//    delegate void Delop(int x, int y);
//    public static void Main(string[] args)
//    {
//        Delop[] obj = { 
//            new Delop(operation.Add), new Delop(operation.Multiply)
//        };


//        for (int i = 0; i < obj.Length; i++)
//        {
//            obj[i](2, 5);
//            obj[i](3, 6);
//            obj[i](4, 7);
//        }
//    }




//}


//#endregion

#region 3.Anonymous Methods

//class Program
//{
//    // Delegate Definition
//    delegate void operation();
//    static void Main(string[] args)
//    {
//        // Delegate instantiation
//        operation obj = delegate
//        {
//            Console.WriteLine("Anonymous method");
//        };
//        obj();
//        Console.ReadLine();
//    }
//}
#endregion

#region 4.Multicast Delegate


//public class Operation
//{
//    public static void Add(int a)
//    {
//        Console.WriteLine("Addition={0}", a + 10);
//    }
//    public static void Square(int a)
//    {
//        Console.WriteLine("Multiple={0}", a * a);
//    }
//}
//class Program
//{
//    delegate void DelOp(int x);
//    static void Main(string[] args)
//    {
//        // Delegate instantiation
//        DelOp obj = Operation.Add;
//        obj += Operation.Square;
//        obj(2);
//        obj(8);
//        Console.ReadLine();
//    }
//}



//public class Operation
//{
//    public static void One()
//    {
//        Console.WriteLine("one display");
//        throw new Exception("Error");
//    }
//    public static void Two()
//    {
//        Console.WriteLine("Two display");
//    }
//}
//class Program
//{
//    delegate void DelOp();
//    static void Main(string[] args)
//    {
//        // Delegate instantiation
//        DelOp obj = Operation.One;
//        obj += Operation.Two;
//        Delegate[] del = obj.GetInvocationList();
//        foreach (DelOp d in del)
//        {
//            try
//            {
//                d();
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Error caught");
//            }
//        }
//        Console.ReadLine();
//    }
//}





#endregion

#region 5. Events

//public delegate void DelEventHandler ();
//class program
//{
//    public static event DelEventHandler add;
//    static void Main(string[] args) {
//        add += new DelEventHandler(USA);
//        add += new DelEventHandler(India);
//        add += new DelEventHandler(England);
//        add.Invoke();
//        Console.ReadLine();

//    }
//    static void USA()
//    {
//        Console.WriteLine("USA");
//    }
//    static void India() {
//        Console.WriteLine("India");
//    }
//    static void England() {
//    Console.WriteLine("England");
//    }

//}

//public delegate void EventHandler(string a);
//public class operation
//{
//    public event EventHandler xyz;
//    public void Action(string a)
//    {
//        if (xyz != null)
//        {
//            xyz(a);
//            Console.WriteLine(a);
//        }
//        else
//        {
//            Console.WriteLine("Not Registered");
//        }
//    }
//}

//class program
//{
//    public static void CatchEvent(string s)
//    {
//        Console.WriteLine("Method Calling");
//    }
//    static void Main(string[] args) {
//        operation o = new operation();
//      o.Action("Event Calling");
//       o.xyz += new EventHandler(CatchEvent);
//        Console.ReadLine();





//    }



//}


#endregion



//}





#region form applying delegates and Events 

using System;
namespace Delegates
{
    public delegate void EventHandler(string a);
    public class Operation
    {
        public event EventHandler xyz;
        public void Action(string a)
        {
            if (xyz != null)
            {
                xyz(a);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Not Registered");
            }
        }
    }
    class Program
    {
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        static void Main(string[] args)
        {
            Operation o = new Operation();
            o.Action("Event Calling");
            o.xyz += new EventHandler(CatchEvent);
            Console.ReadLine();
        }
    }
}






#endregion
