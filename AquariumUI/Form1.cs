using Aquarium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumUI
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimeSpan timeSpan = TimeSpan.FromSeconds(3);

            MessageBox.Show(timeSpan.Seconds.ToString());

            Child child = new();

            MessageBox.Show(child.Word);
        }
    }
}
