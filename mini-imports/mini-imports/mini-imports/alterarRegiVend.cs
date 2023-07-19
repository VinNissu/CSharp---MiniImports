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
    public partial class alterarRegiVend : Form
    {
        public alterarRegiVend()
        {
            InitializeComponent();
        }

        private void alterarRegiVend_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mini_imports_realDataSet.registroVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet.registroVendas);
            registroVendasBindingSource.AddNew();

            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet.registroVendas);
            if (Class1.codigo == "")//
            { registroVendasBindingSource.AddNew(); }//
            else//
            { registroVendasBindingSource.Filter = string.Format("regiVend_id={0}", Class1.codigo); }// textBox1.Text); } 

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            registroVendasBindingSource.EndEdit();
            registroVendasTableAdapter.Update(mini_imports_realDataSet.registroVendas);
            this.registroVendasTableAdapter.Fill(this.mini_imports_realDataSet.registroVendas);
            registroVendasBindingSource.MoveLast();
            registroVendasBindingSource.AddNew();
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisarRegivend frl = new pesquisarRegivend();
            this.Hide();
            frl.ShowDialog();
        }
    }
}
