using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        private string Ficheiro = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFicheiroNovo_Click(object sender, EventArgs e)
        {

            rbTexto.ResetText();
            rbTexto.Modified = false;
            Ficheiro = null;
        }

        private void menuFicheiroAbrir_Click(object sender, EventArgs e)
        {
           

            openFileDialog1.Filter = "Ficheiros RFT| *.rft | Ficheiros TXT| *.txt | Todos | *.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Ficheiro = openFileDialog1.FileName;
                rbTexto = LoadFile(Ficheiro);
                rbTexto.Modified = false;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (Ficheiro != "")
            {
                rbTexto.SaveFile(Ficheiro);
                rbTexto.Modified = false;
            }
            else
            {
                GuardarFicheiro();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private  void VerificarAlteracoes()
        {
            if (rbTexto.Modified == true)
            {
                DialogResult resposta = MessageBox.Show("Deseja guardar o texto atual?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resposta == DialogResult.Yes)
                {
                    if (Ficheiro != "")
                    {
                        rbTexto.SaveFile(Ficheiro);
                        rbTexto.Modified = false;
                    }
                    else
                    {
                        GuardarFicheiro();
                    }
                }
            }
        }

        private void GuardarFicheiro()
        {
            saveFileDialog1.Filter = "Ficheiros RFT | *.rft | Ficheiros TXT | *.txt";

            saveFileDialog1.FileName = " ";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Ficheiro = saveFileDialog1.FileName;
                rbTexto.SaveFile(Ficheiro);
                rbTexto.Modified = false;
            }
        }

        private void menuEditarCortar_Click(object sender, EventArgs e)
        {
            rbTexto.Cut();
        }

        private void menuEditarCopiar_Click(object sender, EventArgs e)
        {
            rbTexto.Copy();
        }

        private void menuEditarColar_Click(object sender, EventArgs e)
        {
            rbTexto.Paste();
        }

        private void menuEditarSelecionar_Click(object sender, EventArgs e)
        {
            rbTexto.SelectAll();
        }

        private void menuFormatarLetra_Click(object sender, EventArgs e)
        {
            if (rbTexto.SelectionFont !=null)
            {
                fontDialog1.Font = rbTexto.SelectionFont;
            }
            else
            {
                fontDialog1.Font = null;
            }

            fontDialog1.ShowDialog();
            rbTexto.SelectionFont = fontDialog1.Font;
        }

        private void menuFormatarCoresLetra_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionColor = colorDialog1.Color;
        }

        private void menuFormatarCoresFundo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionBackColor = colorDialog1.Color;
        }

        private void menuFormatarAlinhamentoEsquerda_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuFormatarAlinhamentoCentro_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void menuFormatarAlinhamentoDireito_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
