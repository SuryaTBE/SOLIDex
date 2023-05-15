using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDex
{
    #region
    //public class Rectangle
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }
    //}
    //public class AreaCalculator
    //{
    //    public double TotalArea(Rectangle[] arrRectangles)
    //    {
    //        double area=0;
    //        foreach (var objRectangle in arrRectangles)
    //        {
    //            area += objRectangle.Height * objRectangle.Width;
    //        }
    //        return area;
    //    }
    //}
    #endregion
    //This design is as per SRP this works well also but when we need to find the area of the circle,
    //the calculation for circle differs from that of rectangle. so, we have to seperate the area calculation irrespective of shape which is given by
    #region
    //public class Rectangle
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }
    //}
    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}
    //public class AreaCalculator
    //{
    //    public double TotalArea(object arrObject)
    //    {
    //        double area = 0;
    //        Rectangle objRectangle;
    //        Circle objCircle;
    //            if (arrObject is Rectangle)
    //            {
    //                objRectangle = (Rectangle)arrObject;
    //                area += objRectangle.Height * objRectangle.Width;
    //            }
    //            else
    //            {
    //                objCircle = (Circle)arrObject;
    //                area += objCircle.Radius * objCircle.Radius * Math.PI;
    //            }
    //        return area;
    //    }
    //}
    #endregion
    //This also works fine but when we adding shapes like triangle square everytime ,we need to alter the
    //AreaCalculator class everytime for that by usin OCP we declare one base class Shape,when we adding every shape
    //we need to inherit the Shape class which is "Open for execution" and alter the AreaCalculator class which is
    //"Closed for modification"
    public abstract class Shape//base class
    {
        public abstract double Area();
    }
    public class Circle:Shape
    {
        public double radius { get; set; }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle:Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double Area()
        {
            return Side * Side;
        }
    }
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Breadth { get; set; }
        public override double Area()
        {
            return (Breadth * Height) / 2;
        }
    }
    public class AreaCalculator//Total area of all shapes
    {
        public double result(Shape[] arrShapes)
        {
            double area = 0;
            foreach(var obj in arrShapes)
            {
                area += obj.Area();
            }
            return area;
        }
    }
}
