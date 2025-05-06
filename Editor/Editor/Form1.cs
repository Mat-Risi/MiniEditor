using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Editor
{
    public partial class Form1 : Form
    {
        int conta = 1;
        int x;
        private string tabPage;

        public Form1()
        {
            InitializeComponent();
        }

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDialog1.Font;
            }
        }


        private void tamanhoDaLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                int tamanho = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Qual o tamanho que deseja"));
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, tamanho);
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 8;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void inserirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox rtb = GetRichTextBoxAtual();
                if (rtb != null && rtb.SelectionLength > 0)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    MessageBox.Show("Selecione um texto primeiro");
                }
            }  
        }

        private void tamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                int tamanho = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Qual o tamanho que deseja"));
                rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, tamanho);
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void centroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void esquerdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void direitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && rtb.SelectionLength > 0)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Right;
            }
            else
            {
                MessageBox.Show("Selecione um texto primeiro");
            }
        }

        private void tipoDeLetraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb != null && fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDialog1.Font;
            }
        }

        private void tipoDeLetraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox rtb = GetRichTextBoxAtual();
                if (rtb != null && rtb.SelectionLength > 0)
                {
                    rtb.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    MessageBox.Show("Selecione um texto primeiro");
                }
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Salva apenas a aba atualmente selecionada, com formatação
                TabPage paginaAtual = tabControl1.SelectedTab;
                foreach (Control ctrl in paginaAtual.Controls)
                {
                    if (ctrl is RichTextBox richTextBox)
                    {
                        richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Página salva com formatação.");
                        return;
                    }
                }
            }
        }

        private RichTextBox GetRichTextBoxAtual()
        {
            if (tabControl1.SelectedTab != null)
            {
                foreach (Control ctrl in tabControl1.SelectedTab.Controls)
                {
                    if (ctrl is RichTextBox rtb)
                        return rtb;
                }
            }
            return null;
        }


        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Documento do Word|*.doc|Rich Text Format (*.rtf)|*.rtf|Todos os ficheiros (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Abrir Ficheiro";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string extensao = Path.GetExtension(openFileDialog1.FileName).ToLower();
                string conteudo = "";

                if (extensao == ".rtf")
                {
                    RichTextBox temp = new RichTextBox();
                    temp.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    conteudo = temp.Text;
                }
                else if (extensao == ".doc" || extensao == ".txt")
                {
                    conteudo = File.ReadAllText(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Formato não suportado.");
                    return;
                }

                // Limpa as abas existentes
                tabControl1.TabPages.Clear();
                conta = 0;

                string[] paginas = conteudo.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string pagina in paginas)
                {
                    conta++;
                    TabPage novaTabPage = new TabPage("Página " + conta);
                    RichTextBox novoRichTextBox = new RichTextBox();
                    novoRichTextBox.Dock = DockStyle.Fill;
                    novoRichTextBox.Name = "richTextBox" + conta;
                    novoRichTextBox.Text = pagina.Trim();
                    novaTabPage.Controls.Add(novoRichTextBox);
                    tabControl1.TabPages.Add(novaTabPage);
                }

                MessageBox.Show("Documento carregado com sucesso!");
            }
        }



        private void copiarCtrlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetRichTextBoxAtual();
            if (rtb.SelectionLength > 0) {
                if (rtb != null && rtb.SelectionLength > 0)
                {
                    rtb.Copy();
                }
                else
                {
                    MessageBox.Show("Selecione um texto primeiro");
                }
            }  
        }

        private void colarCtrlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                // Determine if any text is selected in the text box.
                if (richTextBox1.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                richTextBox1.Paste();
            }
        }
        private void ToggleDarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                foreach (Control control in this.Controls)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                foreach (Control control in this.Controls)
                {
                    control.BackColor = Color.White;
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void modoEscuroClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                bool isDarkMode = this.BackColor == Color.Black;
                ToggleDarkMode(!isDarkMode);
            }
        }
        private void novaPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conta++;
            TabPage novaTabPage = new TabPage("Página " + conta);
            RichTextBox novoRichTextBox = new RichTextBox();
            novoRichTextBox.Name = "richTextBox" + conta;
            novoRichTextBox.Dock = DockStyle.Fill;
            novaTabPage.Controls.Add(novoRichTextBox);
            tabControl1.TabPages.Add(novaTabPage);
        }



        private void renomearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int x=tabControl1.SelectedIndex;
            if(tabControl1.SelectedIndex == x)
            {
                tabControl1.TabPages[x].Text = Microsoft.VisualBasic.Interaction.InputBox("Qual o nome?");
            }
                
        }

    }
}
