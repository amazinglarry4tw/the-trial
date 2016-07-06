using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTrial_Alpha
{
    class Display
    {
        public Display()
        {
        }

        public void RenderText(string text, TextBox pane)
        {
            pane.AppendText(text);
            pane.AppendText("\r\n");
            EatLines(pane);
        }

        public void EatLines(TextBox pane)
        {
            int numOfLines = pane.Lines.Length - 500;
            var lines = pane.Lines;
            var newLines = lines.Skip(numOfLines);
            pane.Lines = newLines.ToArray();
        }
    }
}
