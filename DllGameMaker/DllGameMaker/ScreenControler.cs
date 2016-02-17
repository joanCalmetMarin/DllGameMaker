using System;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.Collections.Generic;
using System.Linq;

namespace DllGameMaker
{
    public class ScreenControler : GameWindow
    {
        private List<Object> _inDoc;

        /// <summary>
        /// create a screen with selected width and heith
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="h">heith</param>
        public ScreenControler(int w, int h) : base(w, h)
        {
            _inDoc=new List<Object>();
        }
        
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
            GL.Begin(PrimitiveType.Polygon);
            foreach (var obj in _inDoc)
            {
                obj.Draw();
            }
            GL.End();
            this.SwapBuffers();
        }

        /// <summary>
        /// Add a objet to the actual document
        /// </summary>
        /// <param name="newobj">new object to add</param>
        /// <returns>add the object on document and return the guid</returns>
        public Guid AddToDoc(Object newobj)
        {
            var guid = new Guid();
            newobj.Id = guid;
            _inDoc.Add(newobj);
            return guid;
        }

        /// <summary>
        /// Delete object with the Guid
        /// </summary>
        /// <param name="id">Guid of the object to delete</param>
        /// <returns>true if the object can be deleted</returns>
        public bool DeleteObject(Guid id)
        {
            int i;
            for (i = 0; i < _inDoc.Count; i++)
            {
                if (_inDoc[i].Id == id) break;
            }
            if (i == _inDoc.Count) return false;
            _inDoc.RemoveAt(i);
            return true;
        }

        /// <summary>
        /// Hide the object from the Id
        /// </summary>
        /// <param name="id">Guid from object to hide</param>
        /// <returns>true if the object can be hided</returns>
        public bool Hide(Guid id)
        {
            int i;
            for (i = 0; i < _inDoc.Count; i++)
            {
                if (_inDoc[i].Id == id) break;
            }
            if (i == _inDoc.Count) return false;
            _inDoc[i].Visible = false;
            return true;
        }

        /// <summary>
        /// Show the object from the Id
        /// </summary>
        /// <param name="id">Guid from object to show</param>
        /// <returns>true if the object can be showed</returns>
        public bool Show(Guid id)
        {
            int i;
            for (i = 0; i < _inDoc.Count; i++)
            {
                if (_inDoc[i].Id == id) break;
            }
            if (i == _inDoc.Count) return false;
            _inDoc[i].Visible = true;
            return true;
        }

        /// <summary>
        /// Try to find the object from the id
        /// </summary>
        /// <param name="id">id from object</param>
        /// <returns>Object from the id</returns>
        public Object Find(Guid id)
        {
            return _inDoc.FirstOrDefault(t => t.Id == id);
        }
    }
}
