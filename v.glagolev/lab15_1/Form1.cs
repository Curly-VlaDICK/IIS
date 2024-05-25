using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAb15
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double rezultU = 1;
			float inputX = float.Parse(textBoxX.Text);
			float inputT = float.Parse(textBoxT.Text);
			float inputZ = float.Parse(textBoxZ.Text);
			int inputN = int.Parse(textBoxN.Text);
			for(var indexer = 1; indexer <= inputN; indexer++)
			{
				double stcossin = 0;
				if (indexer % 2 == 0) 
				{
					stcossin = - Math.Pow(Math.Cos(inputX * inputT) / (inputN + 1), inputN + 1);
				} else
				{
					stcossin = -Math.Pow(Math.Sin(inputX * inputZ) / (inputN + 1), inputN + 1);
				}
				rezultU += stcossin;
			}
			labelU.Text = rezultU.ToString();

		}
	}
}
