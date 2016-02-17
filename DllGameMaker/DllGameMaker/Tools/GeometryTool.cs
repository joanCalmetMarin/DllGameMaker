using System;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.Collections.Generic;

namespace DllGameMaker.Tools
{
    public static class GeometryTool
    {
        public static void AddQuat(List<Point2D> points)
        {
            GL.Begin(PrimitiveType.Quads);
            for(int i = 0; i<points.Count;i++)
            {
                GL.Vertex2(points[i].X, points[i].Y);
            }

            GL.End();
        }
    }
}
