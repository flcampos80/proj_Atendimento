using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Controllers;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Views
{
    public partial class Atendimento : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Atendimento()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            numGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(textGuiche.Text) - 1;
            guiches.ListaGuiches[index].chamar(senhas.FilaSenhas);
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            listBoxSenhas.Items.Clear();
            senhas.FilaSenhas.ToList().ForEach(i => listBoxSenhas.Items.Add(i.dadosParciais()));
        }

        private void btnListarAtend_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(textGuiche.Text) - 1;
            listBoxGuiche.Items.Clear();
            guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => listBoxGuiche.Items.Add(i.dadosCompletos()));
        }

        private void Atendimento_Load(object sender, EventArgs e)
        {

        }
    }

    
}
