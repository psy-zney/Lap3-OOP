using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3_OOP
{
    public abstract class Point
        {
            public abstract double CalcDist(Point other);
        

    }
    public class Point2D : Point
        {  
        public string name {  get; set; }
        public float x {  get; set; }
        public float y { get; set; }
        public override double CalcDist(Point other)
        {
            Point2D other2D = other as Point2D;
            if (other2D == null)
            {
                throw new ArgumentException("Other point must be a Point2D");
            }

            double dx = x - other2D.x;
            double dy = y - other2D.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        
    }
    } 

