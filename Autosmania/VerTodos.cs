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
    public partial class VerTodos : Form
    {
        public VerTodos()
        {
            InitializeComponent();
        }

        private void VerTodos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.codigo.Count; i++)
            {
                listBox1.Items.Add(Program.codigo[i]);
                listBox2.Items.Add(Program.marca[i]);
                listBox3.Items.Add(Program.modelo[i]);
                listBox4.Items.Add(Program.year[i]);
                listBox5.Items.Add(Program.motor[i]);
                listBox6.Items.Add(Program.combustible[i]);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
