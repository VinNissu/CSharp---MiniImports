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
    public partial class pesquisarRegivend : Form
    {
        public pesquisarRegivend()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "")
            {
                pesquisarRegivend frl = new pesquisarRegivend();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                registroVendasBindingSource.Filter = string.Format("regiVend_id={0}", textBox1.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                pesquisarRegivend frl = new pesquisarRegivend();
                this.Visible = false;
                frl.Show();
            }
            else
            {
                registroVendasBindingSource.Filter = string.Format("regiVend_nmCompra like'%{0}%'", textBox2.Text);
            } 
         }

        private void pesquisarRegivend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet1.registroVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet1.registroVendas);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            regivend frl = new regivend();
            this.Hide();
            frl.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            alterarRegiVend frl = new alterarRegiVend();
            this.Hide();
            frl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                //string codigo;
                //codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                registroVendasBindingSource.RemoveCurrent();
                registroVendasTableAdapter.Update(mini_imports_realDataSet1.registroVendas); //salvar
                this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet1.registroVendas);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                //throw;
            }
           
        }
    }
}
