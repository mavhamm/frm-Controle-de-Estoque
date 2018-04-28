using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadProdutos : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        public override void Atualiza_Grid()
        {
            try
            {
                //this.Text = lblTitulo.Text = "Produtos";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void CarregaValores()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;

            return bSalvar;
        }

        public override bool Excluir()
        {
            bool bExcluir = false;


            return bExcluir;
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads dat into the 'dataSet_Dados_Do_Banco.Categoria' table.
            //this.categoriaTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Categoria);
        }
    }
}
