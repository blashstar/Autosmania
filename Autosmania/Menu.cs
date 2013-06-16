using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosmania
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerTodos vt = new VerTodos();
            vt.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo n = new Nuevo();
           n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editar ed = new Editar();
            ed.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambiarEstado ce = new CambiarEstado();
            ce.Show();
        }
    }
}
