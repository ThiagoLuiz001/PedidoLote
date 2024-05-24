using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace MyRH_DP
{
    internal class Conexao
    {
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
                    connectionString = $"Server=np:{source};Database={catalog};User Id={usuario};Password={senha}";
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



    }
}
