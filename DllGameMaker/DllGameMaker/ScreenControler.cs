using System;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace DllGameMaker
{
    public class ScreenControler : GameWindow
    {
        /// <summary>
        /// create a screen with selected width and heith
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="h">heith</param>
        public ScreenControler(int w,int h) : base (w,h)
        { }
        
        /// <summary>
        /// create a screen with a default size
        /// </summary>
        public ScreenControler():this(640,400)
        { }

        /// <summary>
        /// override of event of load screen
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        /// <summary>
        /// override of refresh of screen event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        /// <summary>
        /// override of render frame event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            this.SwapBuffers();
        }
        
    }
}
