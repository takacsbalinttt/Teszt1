using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Hotcakes.Web;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Orders;
using Hotcakes.CommerceDTO.v1;
using System.Security.Cryptography;
using ApiSample;

namespace inprogress_winforms_app
{
    public partial class Form1 : Form
    {
        List<Termek> termeklista = new List<Termek>();
        public Form1()
        {
            InitializeComponent();

            var snaps = proxy.ProductsFindAll();
            for (int i = 0; i < snaps.Content.Count; i++)
            {
                var prodinv = proxy.ProductInventoryFindForProduct(snaps.Content[i].Bvin);
                listBox1.Items.Add(snaps.Content[i].ProductName);
                Termek t = new Termek();
                t.id = i + 1;
                t.nev = snaps.Content[i].ProductName;
                //if (prodinv.Content != null && prodinv.Content.Any())
                //{
                //    t.keszlet = prodinv.Content[0].QuantityOnHand;
                //}
                //else
                //{
                //    continue;
                //     Kezelés, ha nincs elérhető adat
                //}
                t.keszlet = prodinv.Content[0].QuantityOnHand;
                t.inventory_id = prodinv.Content[0].Bvin;
                termeklista.Add(t);
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z + 1;
            textBox_mennyiseg.Text = z.ToString();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            var z = int.Parse(textBox_mennyiseg.Text);
            z = z - 1;
            textBox_mennyiseg.Text = z.ToString();
        }

        static string url = "http://20.234.113.211:8098/";
        static string key = "1-1714a294-76e0-4eef-b184-ae31488ac0f0";

        Api proxy = new Api(url, key);

        private void textBox_kereses_TextChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void Szures()
        {
            List<string> szures = new List<string>();
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].nev.ToLower().StartsWith(textBox_kereses.Text.ToLower()))
                {
                    szures.Add(termeklista[i].nev);
                }
            }

            listBox1.DataSource = szures;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex + 1;
            textBox_mennyiseg.Text = (termeklista[index].keszlet).ToString();
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex + 1;
            var curproduct = termeklista[index];
            var inv = proxy.ProductInventoryFind(curproduct.inventory_id).Content;
            inv.QuantityOnHand = int.Parse(textBox_mennyiseg.Text);
            var response = proxy.ProductInventoryUpdate(inv);

            if (response != null)
            {
                termeklista[index].keszlet = inv.QuantityOnHand;

                textBox_mennyiseg.Text = inv.QuantityOnHand.ToString();
            };
        }

        private void button_megse_Click(object sender, EventArgs e)
        {
            textBox_mennyiseg.Text = termeklista[listBox1.SelectedIndex + 1].keszlet.ToString();
        }
    }
}