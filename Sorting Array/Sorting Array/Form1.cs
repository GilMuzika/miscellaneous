using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Array
{
    public partial class Form1 : Form
    {
        private SortArray CurrentSorting { get; set; } = new SortArray();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            CurrentSorting.TheArrayLength = Convert.ToInt32(numTheArrayLength.Value);
            
            rtbRawArray.Text = string.Empty;
            foreach (int s in CurrentSorting.arrayCreator()) rtbRawArray.Text += s.ToString() + " ";
        }



        private void btnSortTheArray_Click(object sender, EventArgs e)
        {


            rtbSortedArray.Text = string.Empty;

            if (CurrentSorting.TheArray != null)
            {
                CurrentSorting.sortArray();
                foreach (int s in CurrentSorting.TheArray) rtbSortedArray.Text += s.ToString() + " ";
            }
            else rtbSortedArray.Text = "No input array!";

        }



        
    }


}
