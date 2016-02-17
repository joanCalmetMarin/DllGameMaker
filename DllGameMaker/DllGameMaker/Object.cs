using System;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;

namespace DllGameMaker
{
    public class Object
    {
        public List<Point2D> Vertex { get; set; }
        public double Red { get; set; }
        public double Blue { get; set; }
        public double Green { get; set; }
        internal Guid Id { get; set; }
        internal bool Visible { get; set; }
        public Object()
        {
            Vertex= new List<Point2D>();
        }

        public void Draw()
        {
            if (!Visible)return;
            foreach (var point2D in Vertex)
            {
                GL.Color3(Red, Green, Blue);
                GL.Vertex2(point2D.X, point2D.Y);
            }
        }
    }
}
