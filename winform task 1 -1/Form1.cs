using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_task_1__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.Dispose();
                Button button = new Button();
               
                Random random = new Random();
                int randomW = random.Next(this.Size.Width - 100);
                int randomH = random.Next(this.Size.Height - 100);
                button.Size = new Size(120, 30);
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.Magenta;
                button.Location = new Point(randomW, randomH);
                button.Text = "Start";
                button.MouseEnter += button1_Click;

                this.Controls.Add(button);

            }
        }
    }
}
