using Aquarium;
using Aquarium.Enities;
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

	public partial class MainForm : Form
	{
		private List<Fish> _fishes = new();
		private List<Algae> _algaes = new();
		public MainForm()
		{
			InitializeComponent();
		}
	}
}
