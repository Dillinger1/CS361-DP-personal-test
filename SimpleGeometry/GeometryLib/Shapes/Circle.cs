using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
/// <summary>
    /// Круг
    /// </summary>
    /// 
    
public class Circle : Shape
{
    public double Radius { get; set; }  

    public Circle(double radius)
    {
        Debug.Assert(radius > 0, "radius > 0");
        Radius = radius;
    }

    public override double Area()
        {           
            return this.Radius * this.Radius * Math.PI;        
        }

    public override string Print()
        {
            return String.Format("Circle: radius = {0}, area = {1}",
               this.Radius, this.Area());
        }
    
}

}
