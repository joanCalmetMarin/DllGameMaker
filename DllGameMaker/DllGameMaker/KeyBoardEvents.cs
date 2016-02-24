using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Input;

namespace DllGameMaker
{
    public class KeyBoardEvents
    {
        private GameWindow _wind;

        public Dictionary<Key,AsyncCallback> EventKeysDown;

        public KeyBoardEvents(GameWindow window)
        {
            _wind = window;
            _wind.KeyDown += _wind_KeyDown;
            _wind.MouseDown += _wind_MouseDown;
            _wind.MouseWheel += _wind_MouseWheel;
            _wind.MouseEnter += _wind_MouseEnter;
            _wind.MouseLeave += _wind_MouseLeave;
            _wind.MouseUp += _wind_MouseUp;
            _wind.MouseMove += _wind_MouseMove;
            EventKeysDown = new Dictionary<Key, AsyncCallback>();
        }

        private void _wind_MouseMove(object sender, MouseMoveEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_MouseUp(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_MouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _wind_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (EventKeysDown.ContainsKey(e.Key))
            {
                EventKeysDown[e.Key].Invoke(null);
            }
        }
    }
}
