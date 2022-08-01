using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //int colIdex = 0;
        private void populateGride(List<Bank> lstBk)
        {
            int rowIndex = 0;
            //dgvbank2.DataSource = lstBk;


            foreach (Bank bk in lstBk)
            {
                dgvBank.Rows.Add(1);
                dgvBank[0, rowIndex].Value = bk.accountNo;
                dgvBank[1, rowIndex].Value = bk.firstName;
                dgvBank[2, rowIndex].Value = bk.lastName;
                dgvBank[3, rowIndex].Value = bk.cuurentBalance;
                rowIndex++;
            }


        }

        Bank bk;
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            bk = new Bank();
            bk.accountNo = int.Parse(txtAccountNo.Text);
            bk.firstName =  txtFirstName.Text;
            bk.lastName = txtLastname.Text;
            
            bk.cuurentBalance = double.Parse(txtInitialBalance.Text);
            bk.amount = double.Parse(txtAmount.Text);

            Bank.addCUstomer(bk);

            List<Bank> lstCustomer = Bank.getAllCustomer();

            populateGride(lstCustomer);
            MessageBox.Show("Bank Account Save Successfully !");
            setEmpty();
        }


        private void setEmpty()
        {
            txtAccountNo.Clear();
            txtFirstName.Clear();
            txtLastname.Clear();
            txtAmount.Clear();
            txtInitialBalance.Clear();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            Bank bank = Bank.getCustomerByAccountNo(int.Parse(txtAccountNo.Text));
            bank.deposite(double.Parse(txtAmount.Text));
            MessageBox.Show("Amount Deposited Successfully !");
            populateGride(Bank.getAllCustomer());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Bank bank = Bank.getCustomerByAccountNo(int.Parse(txtAccountNo.Text));
            bank.withDraw(double.Parse(txtAmount.Text));
            MessageBox.Show("Amount withdraw Successfully !");
            populateGride(Bank.getAllCustomer());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Bank bank = Bank.getCustomerByAccountNo(int.Parse(txtAccountNo.Text));
            if(bank == null)
            {
                MessageBox.Show("Account Not Found !");
            }
            else
            {
                txtAccountNo.Text = bank.accountNo.ToString();
                txtFirstName.Text = bank.firstName;
                txtLastname.Text = bank.lastName;
                txtInitialBalance.Text = bank.cuurentBalance.ToString();
                txtAmount.Text = bank.amount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank bk = new Bank();
            bk.accountNo = 123456;
            MessageBox.Show("Inside Form1 Class : " + bk.accountNo);
            Bank bk1 = bk.addBankObj();// bk === this
        }
    }
}
