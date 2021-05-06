using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CarApp
{
    public partial class Form1 : Form
    {

        Database dbObject = new Database();
        public Form1()
        {
            InitializeComponent();
            InitListView();
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
                Car car = new Car(tbxRegNr.Text, tbxMake.Text, tbxModel.Text, Convert.ToInt32(tbxYear.Text), cbxForSale.Checked);
                AddCarToListView(car);

                int result = dbObject.AddCarRow(car);
                MessageBox.Show("Du har lagt till " + Convert.ToString(result) + " antal bilar");

                ClearTextBoxes();
                btnClearAll.Enabled = true;
            }
        }

        private void AddCarToListView(Car car)
        {
            ListViewItem item = CreateListViewItem(car);
            lsvCars.Items.Add(item);
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
            int res = dbObject.RemoveCarByRegNr(lsvCars.SelectedItems[0].Text);
            MessageBox.Show("Du har tagit bort " + Convert.ToString(res) + " antal bilar från databasen");
            if(res > 0)
            {
                RemoveCarFromListView(lsvCars.SelectedItems[0]);
            }
        }

        private void RemoveCarFromListView(ListViewItem listViewitem)
        {
            if (lsvCars.SelectedItems.Count > 0)
            {
                lsvCars.Items.Remove(listViewitem);
                MessageBox.Show("Bilen med registreringsnummer " + listViewitem.Text + " är borttagen", "Borttag av bil");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxRegNr.Text))
            {
                tbxRegNr.Text = tbxRegNr.Text.ToUpper();
                PrintData(tbxRegNr.Text);
            }
            else
            {
                MessageBox.Show("Du måste ange ett registreringsnummer", "Inmatning Saknas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
