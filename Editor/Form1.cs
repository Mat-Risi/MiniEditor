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
using Newtonsoft.Json;
using System.Diagnostics;

namespace Editor
{
    public partial class Form1 : Form
    {
        private string caminhoArquivoAtual = null;
        int cont = 1;
        int x;
        private string tabPage;

        public Form1()
        {
            InitializeComponent();
        }

        [Serializable]
        public class PaginaDocumento
        {
            public string NomeAba { get; set; }
            public string ConteudoRTF { get; set; }
        }

        private RichTextBox GetCurrentRichTextBox()
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

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                if (rtb != null && fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar tipo de letra: " + ex.Message);
            }
        }

        private void tamanhoDaLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                if (rtb.SelectionLength > 0)
                {
                    x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Qual o tamanho que deseja"));
                    rtb.SelectionFont = new Font("Arial", x);
                }
                else
                {
                    MessageBox.Show("Selecione um texto primeiro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar tamanho: " + ex.Message);
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            x = 8;
        }
        private void tipoDeLetraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDialog1.Font;
            }
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
                rtb.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
                rtb.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
                rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void inserirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                if (rtb != null && openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    Clipboard.SetImage(img);
                    rtb.Paste();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir imagem: " + ex.Message);
            }
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null && colorDialog1.ShowDialog() == DialogResult.OK)
                rtb.SelectionColor = colorDialog1.Color;
            
        }

        private void tamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                rtb.ContextMenuStrip = contextMenuStrip1;
                if (rtb.SelectionLength > 0)
                {
                    x = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Qual o tamanho que deseja"));
                    rtb.SelectionFont = new Font("Arial", x);
                }
                else
                {
                    MessageBox.Show("Selecione um texto primeiro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar tamanho: " + ex.Message);
            }
        }

        private void centroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
            {
                rtb.ContextMenuStrip = contextMenuStrip1;
                rtb.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void esquerdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
            {
                rtb.ContextMenuStrip = contextMenuStrip1;
                rtb.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void direitaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null)
            {
                rtb.ContextMenuStrip = contextMenuStrip1;
                rtb.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void tipoDeLetraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                rtb.ContextMenuStrip = contextMenuStrip1;
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar fonte: " + ex.Message);
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pacote do Editor (*.rtfpack)|*.rtfpack";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<PaginaDocumento> paginas = new List<PaginaDocumento>();

                    foreach (TabPage pagina in tabControl1.TabPages)
                    {
                        foreach (Control ctrl in pagina.Controls)
                        {
                            if (ctrl is RichTextBox rtb)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    rtb.SaveFile(ms, RichTextBoxStreamType.RichText);
                                    string rtfText = Encoding.UTF8.GetString(ms.ToArray());

                                    paginas.Add(new PaginaDocumento
                                    {
                                        NomeAba = pagina.Text,
                                        ConteudoRTF = rtfText
                                    });
                                }
                            }
                        }
                    }

                    string json = JsonConvert.SerializeObject(paginas);
                    File.WriteAllText(saveFileDialog1.FileName, json);
                    caminhoArquivoAtual = saveFileDialog1.FileName;
                    MessageBox.Show("Arquivo salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

        private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pacote do Editor (*.rtfpack)|*.rtfpack    ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFileDialog1.FileName);
                    List<PaginaDocumento> paginas = JsonConvert.DeserializeObject<List<PaginaDocumento>>(json);
                    tabControl1.TabPages.Clear();
                    cont = 0;
                    caminhoArquivoAtual = openFileDialog1.FileName;

                    foreach (var pagina in paginas)
                    {
                        cont++;
                        TabPage novaTabPage = new TabPage(pagina.NomeAba);
                        RichTextBox novoRichTextBox = new RichTextBox();
                        novoRichTextBox.Dock = DockStyle.Fill;
                        novoRichTextBox.ContextMenuStrip = contextMenuStrip1;

                        using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(pagina.ConteudoRTF)))
                        {
                            novoRichTextBox.LoadFile(ms, RichTextBoxStreamType.RichText);
                        }

                        novaTabPage.Controls.Add(novoRichTextBox);
                        tabControl1.TabPages.Add(novaTabPage);
                    }

                    MessageBox.Show("Documento carregado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar: " + ex.Message);
                }
            }
        }

        private void copiarCtrlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                if (rtb?.SelectionLength > 0)
                    rtb.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao copiar: " + ex.Message);
            }
        }

        private void colarCtrlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox rtb = GetCurrentRichTextBox();
                if (rtb != null && Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf))
                {
                    rtb.Paste();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao colar: " + ex.Message);
            }
        }

        private void ToggleDarkMode(bool isDarkMode)
        {
            Color backColor = isDarkMode ? Color.Black : Color.White;
            Color foreColor = isDarkMode ? Color.White : Color.Black;

            this.BackColor = backColor;
            this.ForeColor = foreColor;

            // Alterar as cores da Form
            foreach (Control control in this.Controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;
            }

            // Alterar as cores de cada TabPage
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = backColor;
                tabPage.ForeColor = foreColor;

                // Alterar as cores de cada RichTextBox dentro da TabPage
                foreach (Control ctrl in tabPage.Controls)
                {
                    if (ctrl is RichTextBox rtb)
                    {
                        rtb.BackColor = backColor;
                        rtb.ForeColor = foreColor;
                    }
                }
            }
        }

        private void modoEscuroClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isDarkMode = this.BackColor == Color.Black;
            ToggleDarkMode(!isDarkMode);
        }

        private void novaPaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont++;
            TabPage novaTabPage = new TabPage("Página " + cont);
            RichTextBox richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ContextMenuStrip = contextMenuStrip1
            };
            novaTabPage.Controls.Add(richTextBox);
            tabControl1.TabPages.Add(novaTabPage);
        }

        private void renomearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = tabControl1.SelectedIndex;
                if (index >= 0)
                {
                    string novoNome = Microsoft.VisualBasic.Interaction.InputBox("Qual o nome?");
                    if (!string.IsNullOrWhiteSpace(novoNome))
                        tabControl1.TabPages[index].Text = novoNome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao renomear: " + ex.Message);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(caminhoArquivoAtual))
            {
                MessageBox.Show("Nenhum arquivo foi carregado ou salvo anteriormente.");
                return;
            }

            try
            {
                List<PaginaDocumento> paginas = new List<PaginaDocumento>();

                foreach (TabPage pagina in tabControl1.TabPages)
                {
                    foreach (Control ctrl in pagina.Controls)
                    {
                        if (ctrl is RichTextBox richTextBox)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                richTextBox.SaveFile(ms, RichTextBoxStreamType.RichText);
                                string rtfText = Encoding.UTF8.GetString(ms.ToArray());

                                paginas.Add(new PaginaDocumento
                                {
                                    NomeAba = pagina.Text,
                                    ConteudoRTF = rtfText
                                });
                            }
                        }
                    }
                }

                string json = JsonConvert.SerializeObject(paginas);
                File.WriteAllText(caminhoArquivoAtual, json);

                MessageBox.Show("Arquivo salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: "
                    + ex.Message);
            }
        }


        private void corDoFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null && colorDialog1.ShowDialog() == DialogResult.OK)
                rtb.BackColor = colorDialog1.Color;
        }

        private void sombreadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RichTextBox rtb = GetCurrentRichTextBox();
            if (rtb != null && colorDialog1.ShowDialog() == DialogResult.OK)
                rtb.SelectionBackColor = colorDialog1.Color;
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo processo
            Process paintProcess = new Process();

            // Define o nome do aplicativo a ser iniciado
            paintProcess.StartInfo.FileName = "mspaint.exe";

            // Inicia o processo
            paintProcess.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo processo
            Process calculadora = new Process();

            // Define o nome do aplicativo a ser iniciado
            calculadora.StartInfo.FileName = "calc.exe";

            // Inicia o processo
            calculadora.Start();
        }
    }
}
