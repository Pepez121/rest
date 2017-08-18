using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendors
{
    public partial class VendorsForm : Form
    {
        List<Vendor> vendorsList = new List<Vendor>();
        bool wasFound = false;
        public VendorsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtVendorEmail.Text != "") && (txtVendorName.Text != ""))
            {
                vendorsList.Add(new Vendor() { Name = txtVendorName.Text, Email = txtVendorEmail.Text });
                Clear();
                var bindingList = new BindingList<Vendor>(vendorsList);
                var source = new BindingSource(bindingList, null);
                dgvVendors.DataSource = source;
            }

        }

        private void Clear()
        {
            txtVendorEmail.Clear();
            txtVendorName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFindVendor_Click(object sender, EventArgs e)
        {
            if (lblFindVendor.Text != "")
            {
                string findStr = txtFindVendor.Text;
                Vendor vFound = new Vendor();
                foreach (Vendor v in vendorsList)
                {
                    if (v.Name == findStr)
                    {
                        DialogResult dialogResult = MessageBox.Show("We have found the vendor, would you like to erase it?", "Erase Vendor", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            vFound = v;
                            wasFound = true;
                            break;
                        }
                    }
                }
                

                if (wasFound) { 
                    vendorsList.Remove(vFound);
                    var bindingList = new BindingList<Vendor>(vendorsList);
                    var source = new BindingSource(bindingList, null);
                    dgvVendors.DataSource = source;
                }
                txtFindVendor.Clear();
            }
        }
    }
}
