using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingInvoice
{
    public partial class BillingSystem : Form
    {
        public BillingSystem()
        {
            InitializeComponent();
        }

        private void radioGents_CheckedChanged(object sender, EventArgs e)
        {
            radioGents.ForeColor = System.Drawing.Color.Green;
            radioLadies.ForeColor = System.Drawing.Color.Red;

            cmbItems.Items.Clear();
            cmbItems.Items.Add("Shirts");
            cmbItems.Items.Add("Pants");
            cmbItems.Items.Add("T-Shirts");
            cmbItems.Items.Add("Tracks");
            cmbItems.Items.Add("Shorts");
            cmbItems.Items.Add("Inners");

        }

        private void radioLadies_CheckedChanged(object sender, EventArgs e)
        {
            radioGents.ForeColor = System.Drawing.Color.Red;
            radioLadies.ForeColor = System.Drawing.Color.Green;
            cmbItems.Items.Clear();
            cmbItems.Items.Add("Sarees");
            cmbItems.Items.Add("Half Sarees");
            cmbItems.Items.Add("Wedding Clothes");
            cmbItems.Items.Add("Tops");
            cmbItems.Items.Add("Dress");
            cmbItems.Items.Add("Thong");

        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbItems.SelectedItem.ToString()=="Shirts")
            {
                txtPrice.Text = "350";
            }
            else if (cmbItems.SelectedItem.ToString() == "Pants")
            {
                txtPrice.Text = "700";
            }
            else if (cmbItems.SelectedItem.ToString() == "T-Shirts")
            {
                txtPrice.Text = "250";
            }
            else if (cmbItems.SelectedItem.ToString() == "Tracks")
            {
                txtPrice.Text = "300";
            }
            else if (cmbItems.SelectedItem.ToString() == "Shorts")
            {
                txtPrice.Text = "150";
            }
            else if (cmbItems.SelectedItem.ToString() == "Inners")
            {
                txtPrice.Text = "100";
            }
            else if (cmbItems.SelectedItem.ToString() == "Sarees")
            {
                txtPrice.Text = "500";
            }
            else if (cmbItems.SelectedItem.ToString() == "Half Sarees")
            {
                txtPrice.Text = "1500";
            }
            else if (cmbItems.SelectedItem.ToString() == "Wedding Clothes")
            {
                txtPrice.Text = "2500";
            }
            else if (cmbItems.SelectedItem.ToString() == "Tops")
            {
                txtPrice.Text = "300";
            }
            else if (cmbItems.SelectedItem.ToString() == "Thong")
            {
                txtPrice.Text = "150";
            }
            else if (cmbItems.SelectedItem.ToString() == "Shirts")
            {
                txtPrice.Text = "50";
            }
            else
            {
                txtPrice.Text = "0";
            }
            txtQty.Text = "";
            txtTotal.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQty.Text)).ToString();
            }
        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            string[] arr = new string[8];
            arr[0] = cmbItems.SelectedItem.ToString();
            arr[1] = txtPrice.Text;
            arr[2] = txtQty.Text;
            arr[3] = txtTotal.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            txtSub.Text = (Convert.ToInt32(txtSub.Text) + Convert.ToInt32(txtTotal.Text)).ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtDiscount.Text.Length>0)
            {
                txtNet.Text = (Convert.ToInt32(txtSub.Text) - Convert.ToInt32(txtDiscount.Text)).ToString();
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if(txtPaid.Text.Length>0)
            {
                txtBalance.Text = (Convert.ToInt32(txtNet.Text) - Convert.ToInt32(txtPaid.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txtSub.Text = (Convert.ToInt32(txtSub.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();


                    }
                }
            }
        }
    }
}
