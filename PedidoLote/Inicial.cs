using MyRH_DP;
using System;
using System.Data;
using System.Windows.Forms;

namespace PedidoLote
{
    public partial class Inicial : Form
    {
        public Inicial()
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
            Conexao conexao = new();
            List<string> pedidos = new List<string>();
            Impressao impressao = new();
            if (GradePedido.Rows.Count > 0)
            {
                for (int i = 0; i < GradePedido.Rows.Count; i++)
                {
                    pedidos.Add(GradePedido.Rows[i].Cells[0].Value.ToString());
                }
                if (pedidos.Count > 0)
                {
                    conexao.DadosGrade(pedidos, pedidos.Count);
                }
                else
                {
                    MessageBox.Show("Grade esta sem valor");
                }
            }
            else
            {
                MessageBox.Show("Não há pedidos solicitados");
            }
        }
    }
} 
