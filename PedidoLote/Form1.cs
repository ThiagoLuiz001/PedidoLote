using System;
using System.Data;
using System.Windows.Forms;

namespace PedidoLote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TxtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GradePedido.Rows.Add(TxtPedido.Text);
                TxtPedido.Text = "";
                TxtPedido.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GradePedido.Rows.Clear();
        }

        private void GradePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GradePedido.Columns["clApagar"].Index && e.RowIndex >= 0)
            {
                // Remova a linha correspondente
                if (GradePedido.Rows[e.RowIndex].DataBoundItem is DataRowView dataRowView)
                {
                    dataRowView.Row.Delete();
                }
                else
                {
                    GradePedido.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {
            List<string> pedidos = new List<string>();
            Impressao impressao = new Impressao();  
            for(int i = 0; i < GradePedido.Rows.Count; i++)
            {
                pedidos.Add(GradePedido.Rows[i].Cells[0].Value.ToString());
            }
            impressao.lista = pedidos;
            
        }
    }
} 
