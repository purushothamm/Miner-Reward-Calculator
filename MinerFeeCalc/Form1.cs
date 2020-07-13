using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinerFeeCalc
{
    public partial class Main : Form
    {
        List<Transaction> Trans = new List<Transaction>();
        List<Transaction> SelectTrans;
        int Blocksize = 500000;
        double BlockReward = 12.5;
        double TotalReward = 0;
        public Main()
        {
            InitializeComponent();
            InitialValues();
            var bindingList = new BindingList<Transaction>(Trans);
            BindingSource dvgBindingSource = new BindingSource(bindingList, null);
            //dvgBindingSource.DataSource = Trans;
            dgvTransactions.DataSource = dvgBindingSource;
        }

        public void InitialValues()
        {
            txtBlockSize.Text = Blocksize.ToString();
            txtBlockReward.Text = BlockReward.ToString();
            txtTotalReward.Text = TotalReward.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txtBytes.Text.Length > 0 && txtFee.Text.Length > 0)
            {
                int bytes = int.Parse(txtBytes.Text);
                float fee = float.Parse(txtFee.Text);
                Transaction Tr = new Transaction(bytes, fee, (fee / bytes) * 100);
                Trans.Add(Tr);
                dgvTransactions.DataSource = Trans.ToList();
                txtBytes.Text = string.Empty;
                txtFee.Text = string.Empty;
            }
            else
            {
                DialogResult da = MessageBox.Show("Please enter Bytes and Fee..", "Opps!..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtBytes.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SelectTrans = new List<Transaction>();
            double tempBlocksize = 0;
            double tempFee = 0;

            //Sort the transactions by Fee per Bytes
            List<Transaction> sortedlist = Trans.OrderByDescending(fpb => fpb.FeePerByte).ToList();
            foreach(Transaction trans in sortedlist)
            {
                if (tempBlocksize <= Blocksize)
                {
                    double tempBytes = tempBlocksize + trans.Bytes;
                    //if (tempBytes > Blocksize)
                    //{
                    //    continue;
                    //}
                    if (tempBytes <= Blocksize)
                    {
                        tempBlocksize = tempBlocksize + trans.Bytes;
                        tempFee = tempFee + trans.Fee;
                        SelectTrans.Add(trans);
                    }
                }
            }
            dgvSelectedTrans.DataSource = SelectTrans.ToList();
            txtTotalReward.Text = (BlockReward + tempFee).ToString();
        }

        private void txtBytes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult da = MessageBox.Show("Number or Digit only..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && txtFee.Text.IndexOf('.') != -1)
            { 
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                DialogResult da = MessageBox.Show("Number or Digit only..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBytes.Text = string.Empty;
            txtFee.Text = string.Empty;
            InitialValues();
            dgvTransactions.DataSource = null;
            dgvSelectedTrans.DataSource = null;
            Trans = new List<Transaction>();
            SelectTrans = null;
        }
    }
}
