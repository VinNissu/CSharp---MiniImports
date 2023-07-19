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
    public partial class pesquisarEncomend : Form
    {
        public pesquisarEncomend()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            encomend outroform = new encomend();
            this.Hide();
            outroform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void encomendados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.produtosEncomendados'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }


            produtosEncomendadosBindingSource.Filter = string.Format("encom_id={0}", textBox1.Text); 
        }


        private void button6_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
            {
                pesquisarEncomend frl = new pesquisarEncomend();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                produtosEncomendadosBindingSource.Filter = string.Format("encom_Prod like'%{0}%'", textBox2.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            alterarEncomend frl = new alterarEncomend();
            this.Hide();
            frl.ShowDialog();
        
          
        }



        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                produtosEncomendadosBindingSource.RemoveCurrent();
                produtosEncomendadosTableAdapter.Update(mini_imports_realDataSet.produtosEncomendados); //salvar
                this.produtosEncomendadosTableAdapter.Fill(this.mini_imports_realDataSet.produtosEncomendados);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
           
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                pesquisarEncomend frl = new pesquisarEncomend();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                produtosEncomendadosBindingSource.Filter = string.Format("encom_id={0}", textBox1.Text);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
