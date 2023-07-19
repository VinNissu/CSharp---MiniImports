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
    public partial class alterarEncomend : Form
    {
        public alterarEncomend()
        {
            InitializeComponent();
        }

        private void alterarEncomend_Load(object sender, EventArgs e)
        {
            this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);
            if (Class1.codigo == "")//
            { produtosEncomendadosBindingSource.AddNew(); }//
            else//
            { produtosEncomendadosBindingSource.Filter = string.Format("encom_id={0}", Class1.codigo); }// textBox1.Text); }
                                                                                                          

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            produtosEncomendadosBindingSource.EndEdit();
            produtosEncomendadosTableAdapter.Update(mini_imports_realDataSet.produtosEncomendados);
            this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);
            produtosEncomendadosBindingSource.MoveLast();

            textBox2.Focus();


            //aparece a mensagem quando der certo
            MessageBox.Show("Pessoa alterada com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarEncomend frl = new pesquisarEncomend();
            this.Hide();
            frl.ShowDialog();
        }
    }
}
