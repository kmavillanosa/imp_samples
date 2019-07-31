using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_sample
{
    public partial class SampleView : UserControl
    {
        public SampleView(IColorService service)
        {
            InitializeComponent();
            Service = service;
        }

        public IColorService Service { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorPanel.BackColor = Service.MakeRed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorPanel.BackColor = Service.MakeBlue();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorPanel.BackColor = Service.MakeGreen();
        }
    }
}
