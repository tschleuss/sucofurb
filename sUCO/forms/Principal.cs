using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using sUCO.forms;


namespace sUCO
{
    public partial class Principal : Form
    {
       // private CasoDeUso diagrama;
        enum tiposArquivos 
        { 
            Nenhum
           ,CasoUso
           ,Imagem
        }

        private tiposArquivos tipoArquivo = tiposArquivos.Nenhum;
        private bool dataGridViewAlterado = false;

        CasoUso casoDeUso = new CasoUso("", new Diagrama(), "");

        public Principal()
        {
            InitializeComponent();
            
            //containerFluxoUC.Panel2Collapsed = true;
        }


        private TabPage GetTabPage()
        {

            UserControlCasoUso ucCasoUso = new UserControlCasoUso();

            TabPage tab = new TabPage();

            tab.SuspendLayout();

            ucCasoUso.Dock = DockStyle.Fill;

            tab.BackColor = System.Drawing.Color.Transparent;
            tab.Controls.Add(ucCasoUso);
            //this.tabPage2.Location = new System.Drawing.Point(10, 22);
            // this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage2.Size = new System.Drawing.Size(906, 485);
            //this.tabPage2.TabIndex = 1;
            tab.Text = "Caso de Uso";

            tab.ResumeLayout(false);

            return tab;
        }


        private void abrirArquivoDialog_FileOk(object sender, CancelEventArgs e)
        {
            switch (tipoArquivo)
            {
                case tiposArquivos.CasoUso:
                    casoDeUso = Serializador.abrirArquivo(abrirArquivoDialog.FileName);
                    //casoDeUso.Diagrama.doCarregarDatagridView(dgCasosUso);
                    txt_NomeProjeto.Text = casoDeUso.Nome;

                    //cb_Cenarios.Items.Clear();

                    dataGridViewAlterado = false;
                    //validarBotoesCenario();

                    break;
            }
        }

        private void menuItemInternoSalvar_Click(object sender, EventArgs e)
        {
            btSalvar_Click(sender, e);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlterado)
            {
                if (casoDeUso.FileName == "")
                {
                    salvarArquivoDialog.ShowDialog();
                    casoDeUso.FileName = salvarArquivoDialog.FileName;
                }

                Serializador.salvarArquivo(casoDeUso);
                dataGridViewAlterado = false;
            }
        }


        private void menuItemInternoAbrir_Click(object sender, EventArgs e)
        {
            btAbrir_Click(sender, e);
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {                
                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);

                tipoArquivo = tiposArquivos.CasoUso;
                abrirArquivoDialog.Filter = " Arquivos de casos de uso (*.xml)|*.xml";
                this.abrirArquivoDialog.ShowDialog();
            }
        }


        private void menuItemInternoNovo_Click(object sender, EventArgs e)
        {
            btNovo_Click(sender, e);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {
                casoDeUso = new CasoUso("", new Diagrama(), "");
                //cb_Cenarios.Items.Clear();

                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);
            }
        }


        private bool verificaSalvar()
        {
            if (dataGridViewAlterado)
            {
                DialogResult result = MessageBox.Show("O conteúdo do arquivo foi alterado.\nDeseja Salvar as alterações?", "Arquivo alterado", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    return salvar();
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }

            }
            return true;
        }

        private bool salvar()
        {
            if (dataGridViewAlterado)
            {
                string fileName = "";
                if (casoDeUso == null)
                {
                    if (salvarArquivoDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = salvarArquivoDialog.FileName;
                    }
                }
                else
                {
                    fileName = casoDeUso.FileName;
                }

                if (fileName != "")
                {
                    Serializador.salvarArquivo(casoDeUso);

                    dataGridViewAlterado = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void btUCAdd_Click(object sender, EventArgs e)
        {
            //cria a tab
            TabPage tab = this.GetTabPage();


            //adiciona a tab
            this.tabControl.Controls.Add(tab);

            //seleciona a tab
            this.tabControl.SelectedTab = tab;
        }

        private void btUCDel_Click(object sender, EventArgs e)
        {

        }

    }
}
