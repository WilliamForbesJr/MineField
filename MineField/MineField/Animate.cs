using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace MineField
{
    class Animate
    {
        public static void BlinkMine(Label boxSelected)
        {
            int sleep = 75;

            for (int i = 0; i < 6; i++)
            {
                boxSelected.BackColor = Color.White;
                boxSelected.Refresh();
                System.Threading.Thread.Sleep(sleep);

                boxSelected.BackColor = Color.Red;
                boxSelected.Refresh();
                System.Threading.Thread.Sleep(sleep);
            }
            boxSelected.Text = "*Mine";
        }

        public static void BlinkSquares(TableLayoutPanel panel)
        {
            int sleep = 75;

            foreach (Label box in panel.Controls.OfType<Label>())
            {
                box.Enabled = true;
                box.BackColor = Color.White;
                box.Refresh();
                System.Threading.Thread.Sleep(sleep);

                box.BackColor = Color.Blue;
                box.Refresh();
                System.Threading.Thread.Sleep(sleep);
            }
        }
    }
}
