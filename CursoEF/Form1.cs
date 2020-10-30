using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var uno = new Modelo())
            {
                var dos = from u in uno.Tabla_1
                          select u;
            }
        }
    }
}
