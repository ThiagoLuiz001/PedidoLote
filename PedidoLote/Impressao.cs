using MyRH_DP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportAppServer.ReportDefModel;
using CrystalDecisions.Web;

namespace PedidoLote
{
    public partial class Impressao : Form
    {
        public Impressao()
        {
            InitializeComponent();
        }
        public void GerarGrade(string[,] Valores, int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                if (Valores[i, 2] == "1")
                {
                    GradeDados.Rows.Add(Valores[i, 0], Valores[i, 1], true);
                }
                else
                {
                    GradeDados.Rows.Add(Valores[i, 0], Valores[i, 1], false);
                    CBNaoEmitido.Items.Add($"{Valores[i, 0]} {Valores[i, 1]}");
                }
            }


        }

        private void GerarRelatorio()
        {
            string origem = @"C:\Relarorio\OP MODELO NOVO.rpt";
            
            for (int i = 0; i < GradeDados.Rows.Count; i++)
            {
                string destino = @"C:\Destino\" + GradeDados.Rows[i].Cells[0].Value.ToString + ".png";
                CrystalDecisions.CrystalReports.Engine.ReportDocument documento = new();
                try
                {
                    documento.Load(origem);
                     // Configura os parâmetros do relatório, se houver
                documento.SetParameterValue("Auftrags-Nr", $"{GradeDados.Rows[i].Cells[0].Value.ToString}");

                // Configura as credenciais de conexão com o banco de dados, se necessário
                 TableLogOnInfos logOnInfos = new TableLogOnInfos();
                TableLogOnInfo logOnInfo = new TableLogOnInfo();
                ConnectionInfo connectionInfo = new ConnectionInfo();
                connectionInfo.ServerName = "BALDISAP";
                connectionInfo.DatabaseName = "SBO_BALDI_PRD";
                connectionInfo.UserID = "baldi";
                connectionInfo.Password = "b4ldi@2023";
                logOnInfo.ConnectionInfo = connectionInfo;
                foreach (Table table in documento.Database.Tables)
                {
                    table.ApplyLogOnInfo(logOnInfo);
                }
                    documento.ExportToDisk(ExportFormatType.PortableDocFormat, destino);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao exportar o relatório: " + ex.Message);
                }
                finally
                {
                    documento.Close();
                    documento.Dispose();
                }
            }
        }

        private void BtnImpressao_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}
