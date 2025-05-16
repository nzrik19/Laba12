using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba11
{
    public partial class InputForm : Form
    {
        public double Value1 { get; private set; }
        public double Value2 { get; private set; }
        public double Value3 { get; private set; }
        public double Value4 { get; private set; }

        public InputForm(string shapeType)
        {
            InitializeComponent();
            this.Text = $"Create {shapeType}";
            ConfigureForm(shapeType);
        }

        private void ConfigureForm(string shapeType)
        {
            if (shapeType == "Square")
            {
                label2.Visible = numericUpDown2.Visible = false;
                label3.Visible = numericUpDown3.Visible = false;
                this.Height = 150;
            }
            else if (shapeType == "Rectangle")
            {
                label3.Visible = numericUpDown3.Visible = false;
                this.Height = 180;
            }
            else if (shapeType == "Rhombus")
            {
                label2.Visible = numericUpDown2.Visible = false;
                this.Height = 180;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Value1 = (double)numericUpDown1.Value;
            Value2 = numericUpDown2.Visible ? (double)numericUpDown2.Value : 0;
            Value3 = numericUpDown3.Visible ? (double)numericUpDown3.Value : 0;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
