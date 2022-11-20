using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using MLHousePrice.BLL;
using MLHousePrice.DAL;

namespace MLHousePrice
{
    public partial class FrmPrediction : Form
    {
        public float Cena { get; set; }
        public FrmPrediction()
        {
            InitializeComponent();
          
        }

        public void test()
        {

        }
        
        public void test1()
        {

           
        }
      

   

        private void btnPredictPrice_Click(object sender, EventArgs e)
        {

            HouseData houseData = new HouseData()
            {
                Price = float.Parse(tbSize.Text),
                YearBuilt = float.Parse(tbYear.Text),
                RoofStyle = cbMaterial.SelectedItem.ToString()
            };

            Dal_HouseData dal_HouseData = new Dal_HouseData();
            float price = dal_HouseData.HouseMLModel(houseData);

            Cena = price;
            lblCreditAmount1.Text = Cena.ToString();
          //  MessageBox.Show($"Predicted price for size sq ft= {}k");
        }


        private void btnbtnPredictInstallment_Click(object sender, EventArgs e)
        {
            Dal_Credit dal_Credit = new Dal_Credit();
            float rata = dal_Credit.CreditMLModel(Cena);


            MessageBox.Show($"{Math.Abs(rata)}");
        }
    }
}
