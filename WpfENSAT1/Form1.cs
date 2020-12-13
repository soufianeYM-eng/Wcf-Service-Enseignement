using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfENSAT1
{
    public partial class Form1 : Form
    {
        ServiceReferenceEnseignement.ServiceEnseignementClient d = new ServiceReferenceEnseignement.ServiceEnseignementClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btChercher_Click(object sender, EventArgs e)
        {
            if (d.getByCNE(textCNE.Text).Count() == 0)
            {
                dataGridView1.DataSource = d.getByCNE(textCNE.Text);
                message.Text = "No body";
            }
            else
            {
                dataGridView1.DataSource = d.getByCNE(textCNE.Text);
                message.Text = "You are lucky ";
            }
        }
    }
}
