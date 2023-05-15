using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDex
{
    public class Execution
    {
        public static void Main(string[] args)
        {
            #region SRPex
            //UserService user = new UserService();
            ////user.register("Surya T", "1234", "12@gmail.com");
            //user.register(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()); 
            #endregion
            //Single Resposibility Principle
            #region OCPex 
            //Circle circle = new Circle();
            //Console.WriteLine("Enter Radius:");
            //circle.radius=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Circle:{0}", circle.Area());
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("Enter Height:");
            //rectangle.Height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Width:");
            //rectangle.Width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Rectangle:{0}",rectangle.Area());
            //Square square = new Square();
            //Console.WriteLine("Enter Side:");
            //square.Side = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Square:{0}", square.Area());
            //Triangle triangle = new Triangle();
            //Console.WriteLine("Enter Breadth:");
            //triangle.Breadth = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Height:");
            //triangle.Height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Area of Triangle:{0}",triangle.Area());
            //Console.WriteLine("Area Total:"+(circle.Area()+rectangle.Area()+square.Area()+triangle.Area()));
            //AreaCalculator total = new AreaCalculator();
            //Shape[] shapes = {circle,rectangle,square,triangle}; 
            //Console.WriteLine("Total area is {0}",total.result(shapes)); 
            #endregion
            //Open Closed Principle
            #region LSPex
            //IFruit fruit = new Apple();
            //Console.WriteLine("Color of the Apple is "+fruit.GetColor());
            //fruit = new Orange();
            //Console.WriteLine("Color of the Orange is "+fruit.GetColor()); 
            #endregion
            //Liskov Substitution Principle
            #region ISPex
            //Manager manager = new Manager();
            //manager.CreateSubTasks();
            //manager.AssignTasks();
            //TeamLead teamLead = new TeamLead();
            //teamLead.CreateSubTasks();
            //teamLead.AssignTasks();
            //Programmer programmer = new Programmer();
            //programmer.WorkOnTasks(); 
            #endregion
            //Inteerface Segregation Principle
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });
            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
        }
    }
}
