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
            int res = dbObject.RemoveAllCars();
            if (res == lsvCars.Items.Count)
            {
                lsvCars.Items.Clear();
            }
            else
            {
                lsvCars.Items.Clear();
                InitListView();
            }
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

        private ListViewItem CreateListViewItem(Car car)
        {
            ListViewItem item = new ListViewItem(car.GetRegNr());
            item.SubItems.Add(car.GetMake());
            item.SubItems.Add(car.GetModel());
            item.SubItems.Add(car.GetYear().ToString());
            item.SubItems.Add(car.GetForSale() ? "Yes" : "No");
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

        private void PrintData(string regNr)
        {


            string token = "ZYdERdMQ1BLgQ9DP6hwZpO7ScLeXcJUm";
            string call = String.Format($"https://api.biluppgifter.se/api/v1/vehicle/regno/{regNr}?api_token={token}");



            try
            {
                // Skapa objekt för att skicka en fråga till bilregistret
                WebRequest request = HttpWebRequest.Create(call);



                // Skapa ett svarsobjekt
                WebResponse response = request.GetResponse();



                // Läs av "the stream" som är i responsen
                StreamReader reader = new StreamReader(response.GetResponseStream());



                string carJSON = reader.ReadToEnd();

                JObject jsonCar = JObject.Parse(carJSON);



                tbxMake.Text = jsonCar["data"]["basic"]["data"]["make"].ToString();
                tbxModel.Text = jsonCar["data"]["basic"]["data"]["model"].ToString();
                tbxYear.Text = jsonCar["data"]["basic"]["data"]["model_year"].ToString();



            }
            catch (Exception e)
            {
                MessageBox.Show($"Bil med registreringsnummer {regNr} kunde inte hittas\n\nMeddelande: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void InitListView()
        {
            List<Car> listOfCars = dbObject.GetRowsFromCar();
            foreach (var item in listOfCars)
            {
                AddCarToListView(item);
            }
        }

    }
}
