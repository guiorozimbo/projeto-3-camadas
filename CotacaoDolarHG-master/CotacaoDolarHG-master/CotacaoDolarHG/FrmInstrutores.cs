using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;

namespace ApiInstrutorSenai
{
    public partial class FrmInstrutores : Form
    {
        public FrmInstrutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strURL = "http://localhost:3333/instructor";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(strURL).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Instructors senai = JsonConvert.DeserializeObject<Instructors>(result);
                        string value = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", senai.Instrutor.Name);
                        MessageBox.Show(senai.ToString());
                        
                        //lblBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        //lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        //lblVar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    }
                    else
                    {
                        //lblBuy.Text = "-";
                        //lblSell.Text = "-";
                        //lblVar.Text = "-";
                    }
                }
                catch (Exception ex)
                {
                    //lblBuy.Text = "-";
                    //lblSell.Text = "-";
                    //lblVar.Text = "-";

                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
