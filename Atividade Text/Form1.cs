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

namespace Atividade_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            txtDigitar.Text = File.ReadAllText(txtCaminho1.Text);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtCaminho1.Text, txtDigitar.Text);
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Users\\kaio.sljcampos\\kaio2009\\linux");
        }
    }
}
