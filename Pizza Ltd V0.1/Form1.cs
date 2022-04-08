using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ltd_V0._1
{
    public class Pizza
    {
        public Pizza(int inches, int cost, int pieces)
        {
            this.inches = inches;
            this.cost = cost;
            this.pieces = pieces;
        }
        public int inches, cost, pieces;
    }
    public partial class MainForm : Form
    {
        List<Pizza> pz = new List<Pizza>();

        public MainForm()
        {
            InitializeComponent();
            LoadData();

            txtNoOfPpl.Value = 5;
            txtPieces.Value = 2;

            Calc();
        }

        /// <summary>
        /// THis will load data to table
        /// </summary>
        public void LoadData()
        {

            pz.Add(new Pizza(5, 3, 4));
            pz.Add(new Pizza(7, 5, 6));
            pz.Add(new Pizza(10, 8, 10));
            pz.Add(new Pizza(15, 12,15 ));
            pz.Add(new Pizza(24,18 ,24 ));
        }

        public Pizza Calc()
        {
            decimal noOfPpl = txtNoOfPpl.Value;
            decimal pieces = txtPieces.Value;

            int total = (int)noOfPpl * (int)pieces;
            Pizza ret = new Pizza(0,0,0);

            foreach (Pizza item in pz)
            {
                if (item.pieces >= total)
                {
                    ret = item;
                    break;
                }
            }

            MessageBox.Show("Cost:"+ Convert.ToString(ret.cost));
            return ret;
        }
    }
}
