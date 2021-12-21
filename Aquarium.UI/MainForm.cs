using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium.UI
{
    public partial class MainForm : Form
    {
        private List<Fish> _fishes = new();
        private List<Algae> _algaes = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddFish_Click(object sender, EventArgs e)
        {
            var fish = new Fish() 
            {
                
            };
        }

        private void btnDeleteFish_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAlgae_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAlgae_Click(object sender, EventArgs e)
        {

        }
    }
}
