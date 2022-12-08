using System;
using System.Windows.Forms;

namespace Sistema_Financiero
{
    public partial class conectarsql : Form
    {
        public conectarsql()
        {
            InitializeComponent();
        }

        private void conectarsql_Load(object sender, EventArgs e)
        {
            conectarbd conexion = new conectarbd();
            conexion.abrir();
            Console.ReadLine();
        }
    }

   
}
