using DllGameMaker;
using System;
using System.Collections.Generic;
using DllGameMaker.Tools;

namespace Test
{
    class Game
    {
        ScreenControler test = new ScreenControler();
        List<Point2D> list = new List<Point2D>();
        public Game()
        {
            test.Run();
            test.MouseUp += Test_MouseDown;
            while (true)
            {
               
            }

        }

        private void Test_MouseDown(object sender, OpenTK.Input.MouseButtonEventArgs e)
        {
            if (e.Mouse.LeftButton == OpenTK.Input.ButtonState.Pressed)
            {
                list.Add(new Point2D(e.Mouse.X, e.Mouse.Y));
                if (list.Count == 4)
                
                    GeometryTool.AddQuat(list);
            }
        }
    }
}
