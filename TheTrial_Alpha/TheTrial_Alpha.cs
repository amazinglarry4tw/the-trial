using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TheTrial_Alpha
{
    public partial class TheTrial_Alpha : Form
    {
        MainGame _mainGame;

        public TheTrial_Alpha()
        {
            InitializeComponent();
            Application.Idle += HandleApplicationIdle;
            _mainGame = new MainGame(textbox_story);
        }

        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                UpdateGame();
                Render();
            }
        }

        void UpdateGame()
        {
        }

        void Render()
        {
        }

        bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);

        private void handle_input_submission()
        {
            if (textbox_input.Text != "")
            {
                _mainGame.HandleUserInput(textbox_input.Text);
                textbox_input.Clear();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            handle_input_submission();
        }
    }
}
