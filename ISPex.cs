using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDex
{
    #region ISPex
    //public interface ILead
    //{
    //    void CreateSubTask();
    //    void AssignTask();
    //    void WorkOnTask();
    //}
    //public class TeamLead : ILead
    //{
    //    public void AssignTask()
    //    {
    //        //Code to assign a task.
    //    }
    //    public void CreateSubTask()
    //    {
    //        //Code to create a sub task
    //    }
    //    public void WorkOnTask()
    //    {
    //        //Code to implement perform assigned task.
    //    }
    //} 
    #endregion
    /* In this code,team lead breaks the bug tasks into smaller ones and assigns them to programmers who workson them.
     * This design looks good,later when we add another role like Manager,who assigns task to the team lead and 
     * will not work on the tasks.we can implement this as below*/
    #region WrongManager
    //public class Manager : ILead
    //{
    //    public void AssignTask()
    //    {
    //        //Code to assign a task.
    //    }
    //    public void CreateSubTask()
    //    {
    //        //Code to create a sub task.
    //    }
    //    public void WorkOnTask()
    //    {
    //        throw new Exception("Manager can't work on Task");
    //    }
    //} 
    #endregion
    /* Since the manager can't work on the tasks,no one can assign the tasks to the Manager.So,this WorkOnTask() method
     is need not to be present in the Manager class.But we're implementing this Manager class from ILead interface.Here
    we forcing the Manager class to implement the WorkOnTask() method without a purpose.This is wrong,this violates the ISP
    corrected one is as follow*/
    /* Here we're creating the seperate interfaces for the each role and their respective methods. */
    public interface IProgrammer
    {
        public void WorkOnTasks();
    }
    public interface ILead
    {
        public void CreateSubTasks();
        public void AssignTasks();
    }
    public class Programmer:IProgrammer
    {
        public void WorkOnTasks()
        {
            Console.WriteLine("Working On the Tasks.");
        }
    }
    public class Manager:ILead
    {
        public void CreateSubTasks()
        {
            Console.WriteLine("Sub Tasks created.");
        }
        public void AssignTasks()
        {
            Console.WriteLine("Tasks Assigned to the TeamLeads");
        }
    }
    public class TeamLead:ILead,IProgrammer//In C# multiple inheritance is only supported for the interface
    {
        public void WorkOnTasks()
        {
            Console.WriteLine("Working On the Tasks.");
        }
        public void CreateSubTasks()
        {
            Console.WriteLine("Sub Tasks created.");
        }
        public void AssignTasks()
        {
            Console.WriteLine("Tasks Assigned to the programmers");
        }
    }
}
