using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDex
{
    #region LSPex
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Apple apple = new Orange();
    //        Console.WriteLine(apple.GetColor());
    //    }
    //}
    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Red";
    //    }
    //}
    //public class Orange : Apple
    //{
    //    public override string GetColor()
    //    {
    //        return "Orange";
    //    } 
    //}
    #endregion
    /* In this above example,the base class (Apple) and derived class (Orange),both classes have GetColor() method.
     * According to this,Apple is red in color whereas Orange is in orange color.So Orange is not dependent of Apple.
       The problem is, when you create a derived class object with base class reference ,above program gives apple as Orange 
       in color (line 14,15).So this is wrong according to Liskov Substitution Principle  */
    public interface IFruit
    {
        public abstract string GetColor();
    }
    public class Apple:IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class Orange:IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
    /* In this corrected form, Interface IFruit acts as a base class whereas Apple and Orange classes are
     * derived classes.So, In this case,we can create a child object with parent class reference variable is given in
     Execution.cs file*/
}
