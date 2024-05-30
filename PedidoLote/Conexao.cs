using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using PedidoLote;

namespace MyRH_DP
{
    internal class Conexao
    {
        //Variaveis 
        private string connectionString;


        public Conexao() //procura o arquivo no computador, lê e atribui os valores do arquivo encontrado na string de conexão
        {
            string caminhoJson = "conexao.json";
            if (File.Exists(caminhoJson))
            {
                string conteudoJson = File.ReadAllText(caminhoJson);
                var config = JsonConvert.DeserializeObject<Dictionary<string, string>>(conteudoJson);

                if (config.TryGetValue("Server", out string? source) && config.TryGetValue("Database", out string? catalog))
                {
                    string usuario = config["User Id"];
                    string senha = config["Password"];
                    connectionString = $"Server={source};Database={catalog};User Id={usuario};Password={senha};Trustservercertificate=true";
                }
                else
                {
                    throw new Exception("Arquivo de configuração de conexão inválido.");
                }
            }
            else
            {
                throw new Exception("Arquivo de configuração de conexão não encontrado.");
            }
        }


        public void DadosGrade(List<string> Lista, int Tam)
        {
            foreach (string teste in Lista)
            {
               MessageBox.Show(teste);
            }
            string[,] valores = new string[Tam ,3];
            string sql;
            int i = 0;
            foreach (string ped in Lista)
            {
                
                sql = "Select docentry, cardname FROM ORDR WHERE docentry = @pedido";

                using (SqlConnection conexao = new(connectionString))
                {
                    conexao.Open();
                    using (SqlCommand comando = new(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@pedido", ped);

                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                valores[i,0] = leitor.GetInt32(0).ToString();
                                valores[i,1] = leitor.GetString(1);
                                valores[i,2] = "1";
                            
                            }
                            else
                            {
                                valores[i,0] = ped;
                                valores[i,1] = "Não Existe";
                                valores[i,2] = "0";
                            }
                        }
                    }
                    i++;
                }
               
            }
            Impressao impressao = new();
            impressao.GerarGrade(valores, Tam);
            impressao.Show();
           
        }


    }
}
