using Etiquetas_Pedidos.Model;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Etiquetas_Pedidos.Data
{
    internal class Consults
    {
        private List<Order> listOrdesOpened;
        private List<OrderItens> listItensOrder;

        public List<Order> OrdersOpened(OracleConnection connection)
        {
            if (connection == null)
            {
                MessageBox.Show("Conexão com o banco de dados não estabelecida.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            string query = @"SELECT FAPEDIDO.CD_PEDIDO, GEEMPRES.NOME_COMPLETO FROM FAPEDIDO INNER JOIN GEEMPRES ON FAPEDIDO.CD_CLIENTE = GEEMPRES.CD_EMPRESA WHERE FAPEDIDO.SITUACAO='L' OR FAPEDIDO.SITUACAO='A' ORDER BY CD_PEDIDO DESC";
            listOrdesOpened = new List<Order>();
            using (OracleCommand command = new(query, connection))
            {
                try
                {
                    if (connection.State != ConnectionState.Open) connection.Open();
                    string ordernumber, company;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Nenhum pedido aberto encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return listOrdesOpened;
                        }
                        while (reader.Read())
                        {
                            ordernumber = reader["CD_PEDIDO"].ToString();
                            company = reader["NOME_COMPLETO"].ToString();

                            listOrdesOpened.Add(new Order(ordernumber, company));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar pedidos abertos: {ex.Message}");
                }
                return listOrdesOpened;
            }
        }

        public List<OrderItens> OrderItens(string orderCode, OracleConnection connection)
        {
            if (connection == null)
            {
                MessageBox.Show("Conexão com o banco de dados não estabelecida.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string query = @"select PRO.CD_REDUZIDO, FAT.CD_ESPECIF1, PRO.DESCRICAO, FAT.DESCRICAO AS OBS, FAT.QUANTIDADE, PRO.CD_UNIDADE_MEDI, IDENT.CD_CARAC FROM FAITEMPE  FAT INNER JOIN ESMATERI PRO ON FAT.CD_MATERIAL = PRO.CD_MATERIAL LEFT join PPIDENT IDENT ON IDENT.IDENTIFICADOR = FAT.CD_ESPECIF1 WHERE FAT.CD_PEDIDO = '" + orderCode + "\'";
                listItensOrder = new List<OrderItens>();
                using (OracleCommand command = new(query, connection))
                {
                    if (connection.State != ConnectionState.Open) connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        string CodeReduced, Identificator, ProductDescription, Description, Unit, Quantity;

                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Nenhum item encontrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }

                        while (reader.Read())
                        {
                            CodeReduced = reader["CD_REDUZIDO"].ToString();
                            Identificator = reader["CD_ESPECIF1"].ToString();
                            ProductDescription = reader["DESCRICAO"].ToString();
                            ProductDescription += " " + Converteexpressão(reader["CD_CARAC"].ToString(), connection);
                            Description = reader["OBS"].ToString();
                            Quantity = reader["QUANTIDADE"].ToString();
                            Unit = reader["CD_UNIDADE_MEDI"].ToString();
                            listItensOrder.Add(new OrderItens(CodeReduced, Identificator, ProductDescription, Description, Quantity, Unit));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar itens do pedido: {ex.Message}");
                return null;
            }
            return listItensOrder;
        }
        public static String Converteexpressão(string converteexpress, OracleConnection conexao)
        {

            string[] especificacoes = converteexpress.Split(';'); //Cria um array de string com cada texto encontrado antes do ;
            string linha, retorno = "";

            for (int i = 1; i < especificacoes.Length; i++)
            {
                if (especificacoes[i].Length > 4)
                {
                    string query = $"select USRCARAC1 FROM PPCARACT WHERE CD_CARACT = \'{especificacoes[i].Substring(0, 3)}\'";
                    using (OracleCommand command = new OracleCommand(query, conexao))
                    {
                        if (conexao.State != ConnectionState.Open) conexao.Open();
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                              //  linha = string.Concat(reader["USRCARAC1"].ToString(), especificacoes[i].AsSpan(3, especificacoes[i].Length - 3));
                              //  retorno = retorno + " " + linha;
                                string query2 = $"SELECT CAR.USRCARAC1 || ' ' ||CCCAR.CAMPO21 AS CONTEUDO FROM PPCARACT CAR INNER JOIN PPCCARAC CCCAR ON CAR.CD_CARACT= CCCAR.CD_CARACT WHERE CAR.CD_CARACT=\'{especificacoes[i].Substring(0, 3)}\' AND CCCAR.CONTEUDO=\'{especificacoes[i].AsSpan(3, especificacoes[i].Length - 3)}\'";
                                using (OracleCommand command2 = new OracleCommand(query2, conexao))
                                {
                                    if (conexao.State != ConnectionState.Open) conexao.Open();
                                    using (OracleDataReader reader2 = command2.ExecuteReader())
                                    {
                                       if(!reader2.HasRows)
                                        {
                                            linha = string.Concat(reader["USRCARAC1"].ToString(), especificacoes[i].AsSpan(3, especificacoes[i].Length - 3));
                                            retorno += " " + linha;
                                            continue;
                                        }
                                        while (reader2.Read())
                                        {
                                            linha = reader2["CONTEUDO"].ToString();
                                            retorno += " "+linha;
                                        }
                                    }
                                }
                            }
                            reader.Close();
                        }
                    }
                }
                else { i = especificacoes.Length; }
            }
            return retorno = System.Text.RegularExpressions.Regex.Replace(retorno, @"\s+", " ").Trim();
        }
   
        public Order OrderCode(string orderCode, OracleConnection connection)
        {
            if (connection == null)
            {
                MessageBox.Show("Conexão com o banco de dados não estabelecida.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            Order pedido = null;
            string query = @"SELECT FAPEDIDO.CD_PEDIDO, GEEMPRES.NOME_COMPLETO FROM FAPEDIDO INNER JOIN GEEMPRES ON FAPEDIDO.CD_CLIENTE = GEEMPRES.CD_EMPRESA WHERE FAPEDIDO.CD_PEDIDO = :orderCode";
            using (OracleCommand command = new(query, connection))
            {
                command.Parameters.Add(new OracleParameter("orderCode", orderCode));
                try
                {
                    if (connection.State != ConnectionState.Open) connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Pedido não encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                        while (reader.Read())
                        {
                            string ordernumber = reader["CD_PEDIDO"].ToString();
                            string company = reader["NOME_COMPLETO"].ToString();
                            pedido = new Order(ordernumber, company);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar pedido: {ex.Message}");
                }
                return pedido;
            }
        }
    }
}
