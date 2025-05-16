using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AttachMenuHandlers();
        }

        private void AttachMenuHandlers()
        {
            parallelogramToolStripMenuItem.Click += ParallelogramToolStripMenuItem_Click;
            rhombusToolStripMenuItem.Click += RhombusToolStripMenuItem_Click;
            rectangleToolStripMenuItem.Click += RectangleToolStripMenuItem_Click;
            squareToolStripMenuItem.Click += SquareToolStripMenuItem_Click;
        }

        private void ParallelogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigure<Parallelogram>("Parallelogram");
        }

        private void RhombusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigure<Rhombus>("Rhombus");
        }

        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigure<Rectangle>("Rectangle");
        }

        private void SquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFigure<Square>("Square");
        }

        private void CreateFigure<T>(string figureName) where T : class, IFigure
        {
            using (var form = new InputForm(figureName))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    T figure = null;

                    if (typeof(T) == typeof(Parallelogram))
                        figure = new Parallelogram(form.Value1, form.Value2, form.Value3) as T;
                    else if (typeof(T) == typeof(Rhombus))
                        figure = new Rhombus(form.Value1, form.Value3) as T;
                    else if (typeof(T) == typeof(Rectangle))
                        figure = new Rectangle(form.Value1, form.Value2) as T;
                    else if (typeof(T) == typeof(Square))
                        figure = new Square(form.Value1) as T;

                    if (figure != null)
                        richTextBox1.AppendText($"{figure}\n");
                }
            }
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = DemoRunner.RunDemo();
            richTextBox1.AppendText(result + "\n");
        }
    }
}
