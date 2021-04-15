using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxRegNr.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxRegNr.Text) || string.IsNullOrEmpty(tbxMake.Text))
            {
                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else
            {
                ListViewItem item = CreateListViewItem(tbxRegNr.Text, tbxMake.Text, cbxForSale.Checked);
                lsvCars.Items.Add(item);
                ClearTextBoxes();
                btnClearAll.Enabled = true;
            }
        }

        private void tbxRegNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxForSale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lsvCars.Items.Clear();
            tbxRegNr.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lsvCars.SelectedItems.Count > 0)
            {
                var item = lsvCars.SelectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("Bilen med registeringsnummer " + item.Text + " är borttagen", "Borttag av bil");
            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort", "Borttag av bil");
            }
            btnClearAll.Enabled = (lsvCars.Items.Count > 0);
        }

        private void lsvCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lsvCars.SelectedItems.Count > 0);
        }

        private ListViewItem CreateListViewItem(string regNr, string make, bool forSale)
        {
            ListViewItem item = new ListViewItem(regNr);
            item.SubItems.Add(make);
            item.SubItems.Add(forSale ? "Yes" : "No");
            return item;
        }

        private void ClearTextBoxes()
        {
            tbxRegNr.Clear();
            tbxMake.Clear();
            tbxModel.Clear();
            tbxYear.Clear();
            cbxForSale.Checked = false;
            tbxRegNr.Focus();
        }
    }
}
