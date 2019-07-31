using Autofac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeDependency();
        }
        IContainer DependencyContainer { get; set; }
        public void InitializeDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SampleView>().SingleInstance();
            builder.RegisterType<ColorService>().As<IColorService>().SingleInstance();
            DependencyContainer = builder.Build();

            Control_panel.Controls.Clear();
            var control = DependencyContainer.Resolve<SampleView>();
            Control_panel.Controls.Add(control);
            

        }
    }
}
