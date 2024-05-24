using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoLote
{
    public partial class Impressao : Form
    {
        public List<string>? lista { get; set; }
        public Impressao()
        {
            InitializeComponent();
        }
    }
}
