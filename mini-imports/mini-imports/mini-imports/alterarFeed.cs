using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_imports
{
    public partial class alterarFeed : Form
    {
        public alterarFeed()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void alterarFeed_Load(object sender, EventArgs e)
        {
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);
            


            if (Class1.codigo == "")//
            { 
                feedbackClientesBindingSource.AddNew(); 
            }
            else
            { 
                feedbackClientesBindingSource.Filter = string.Format("feedback_id={0}", Class1.codigo); 
            }// textBox1.Text); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            feedbackClientesBindingSource.EndEdit();
            feedbackClientesTableAdapter.Update(mini_imports_realDataSet.feedbackClientes);
            this.feedbackClientesTableAdapter.Fill(this.mini_imports_realDataSet.feedbackClientes);
            feedbackClientesBindingSource.MoveLast();
            feedbackClientesBindingSource.AddNew();

            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarFeed2 frl = new pesquisarFeed2();
            this.Hide();
            frl.ShowDialog();
        }
    }
}
