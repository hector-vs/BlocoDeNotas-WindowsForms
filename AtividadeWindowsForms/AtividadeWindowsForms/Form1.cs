using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            titulo_app.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            titulo_app.ForeColor = Color.White;
        }

        private void enviartitulo_Click(object sender, EventArgs e)
        {
            titulo_app.Text = textotitulo.Text;
            
        }

        private void butazul_CheckedChanged(object sender, EventArgs e)
        {
            titulo_app.ForeColor = Color.Blue;
        }

        private void butamarelo_CheckedChanged(object sender, EventArgs e)
        {
            titulo_app.ForeColor = Color.Yellow;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.emoji2;
        }

        private void emfofo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.emoji1;
        }

        private void emfeliz_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.emoji3;
        }

        private void empalha_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.emoji4;
        }

        private void emamor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.emoji5;
        }

        private void emnada_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void butclaro_Click(object sender, EventArgs e)
        {
            tela_aplicativo.BackColor = Color.GhostWhite;
        }

        private void butescuro_Click(object sender, EventArgs e)
        {
            tela_aplicativo.BackColor = Color.DimGray;
        }

        private void temaescuro_CheckedChanged(object sender, EventArgs e)
        {
            if (temaescuro.Checked)
            {
                tela_aplicativo.BackColor = Color.DimGray;
                texto_app.ForeColor = Color.White;
                nome_app.ForeColor = Color.White;
            }
            else {
                tela_aplicativo.BackColor = Color.GhostWhite;
                texto_app.ForeColor = Color.Black;
                nome_app.ForeColor = Color.Black;
            }
        }

        private void botao_conteudo_Click(object sender, EventArgs e)
        {
            texto_app.Text = texto_conteudo.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome_app.Text = nome_box.Text;
        }

        private void visionname_CheckedChanged(object sender, EventArgs e)
        {
            if (visionname.Checked)
            {
                nome_app.Visible = false;
            }
            else {
                nome_app.Visible = true;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quer mesmo sair do programa?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (resultado == System.Windows.Forms.DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}
