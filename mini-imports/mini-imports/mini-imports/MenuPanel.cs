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
    public partial class MenuPanel : Form
    {

        private Button btnAtual;
        private Form formAtual;
        public MenuPanel()
        {
            InitializeComponent();
        }

        private void MenuPanel_Load(object sender, EventArgs e)
        {

        }


        private void AbrirForm(Form formSel, Object btnSender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            AtivarBtn(btnSender);
            formAtual = formSel;
            formSel.TopLevel = false; //nivel de controle
            formSel.FormBorderStyle = FormBorderStyle.None;//caixa de controle desativada
            formSel.Dock = DockStyle.Fill; // Posicionamento
            this.panelContainer.Controls.Add(formSel); //adicionar o form ao painel
            this.panelContainer.Tag = formSel;
            formSel.BringToFront();//Traz o controle para frente na ordem Z
            formSel.Show();// Chama o Form
            panel1.Text = formSel.Text;

        }

        private void Resetar()
        {
            DesativarBtn();
            panel1.Text = "HOME";
            btnHome.Visible = false;
        }


        private void AtivarBtn(Object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != (Button)btnSender)
                {
                    btnHome.Visible = true;
                    DesativarBtn();
                    btnAtual = (Button)btnSender;
                    btnAtual.BackColor = Color.FromArgb(00, 120, 215);
                    btnAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DesativarBtn()
        {
            foreach (Control antBtn in panelMenu.Controls)
            {
                if (antBtn.GetType() == typeof(Button))
                {
                    antBtn.BackColor = Color.FromArgb(255, 255, 255);
                    antBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new cadfun(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new cadprod(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new feedback(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formAtual != null)
            {
                formAtual.Close();
                Resetar();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new MenuPanel(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new cadfun(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new cadprod(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new caixa(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(new pesquisarfor(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu frl = new menu();
            this.Hide();
            frl.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForm(new caixa(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            AbrirForm(new backup(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm(new cadfor(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            AbrirForm(new encomend(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirForm(new encomend(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirForm(new feedback(), sender);
            button1.BackColor = Color.FromArgb(00, 120, 215);
            button1.Font = new System.Drawing.Font("BankGothic Md BT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MenuPanel frl = new MenuPanel();
            this.Hide();
            frl.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu frl = new menu();
            this.Hide();
            frl.ShowDialog();

            
        }
    }
}
