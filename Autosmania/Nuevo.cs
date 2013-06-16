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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.codigo.Add(textBox1.Text);
            Program.marca.Add(textBox2.Text);
            Program.modelo.Add(textBox3.Text);
            Program.year.Add(textBox4.Text);
            Program.motor.Add(textBox5.Text);
            Program.combustible.Add(textBox6.Text);

            this.Close();
        }
    }
}
