using bpac;
using Etiquetas_Pedidos.Data;
using Etiquetas_Pedidos.Model;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Text;
using System.Linq;

namespace Etiquetas_Pedidos.Services
{
    internal class Print
    {
        private string order, company;
        private void HeaderLabel(ComboBox combo)
        {
            if (combo.SelectedItem is Order pedidoSelecionado)
            {
                var pedido = pedidoSelecionado;
                order = pedido.OrderCode;
                company = pedido.Company;
            }
            else if (combo.Text.Length > 0)
            {
                var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);

                IConfiguration config = builder.Build();

                string connectionString = config.GetConnectionString("ConexaoOracle");
                try

                {
                    using (var connection = new OracleConnection(connectionString))
                    {
                        string code = combo.Text.Split('-')[0].Trim();
                        Consults consults = new();
                        var pedido = consults.OrderCode(combo.Text, connection);
                        order = pedido.OrderCode;
                        company = pedido.Company;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
        public void PrintAmostra(string client, string description)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);
            IConfiguration config = builder.Build();

            const string templateFilePath = "amostra.lbx";
            const string templateAtualizadoFilePath = "amostragerado.lbx";
            string? printerName = config["Printers:PrinterLabel"];
            if (string.IsNullOrWhiteSpace(printerName))
            {
                MessageBox.Show("Impressora não configurada.");
                return;
            }

            bpac.Document doc = null;
            try
            {
                doc = new bpac.Document();
                doc.Open(templateFilePath);
                doc.SetPrinter(printerName, true);
                doc.GetObject("$CLIENTE").Text = client;
                doc.GetObject("$DESCRICAO").Text = description;
                doc.SaveAs(ExportType.bexLbx, templateAtualizadoFilePath);
                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir etiquetas: " + ex.Message);
            }
        }
        public void PrintBrotherQL(ComboBox combo, ListView itens)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) 
            .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);
            IConfiguration config = builder.Build();

            const string templateFilePath = "embalagem.lbx";
            const string templateAtualizadoFilePath = "embalagemgerado.lbx";

            string? printerName = config["Printers:PrinterLabel"];
            if (string.IsNullOrWhiteSpace(printerName))
            {
                MessageBox.Show("Impressora não configurada.");
                return;
            }
            HeaderLabel(combo);
            bpac.Document doc = null;
            try
            {
                doc = new bpac.Document();
                doc.Open(templateFilePath);
                doc.SetPrinter(printerName, true);
                doc.GetObject("$PEDIDO").Text = order;
                doc.GetObject("$CLIENTE").Text = company;

                foreach (ListViewGroup group in itens.Groups.Cast<ListViewGroup>())
                {
                    if (group.Items.Count <= 1)
                    {
                        continue;
                    }
                    var description = MountDescription(group, out string esteira);
                   
                    doc.GetObject("$ESTEIRA").Text = esteira;
                    doc.GetObject("$DESCRICAO").Text = description;
                    doc.SaveAs(ExportType.bexLbx, templateAtualizadoFilePath);
                    doc.StartPrint("", PrintOptionConstants.bpoDefault);
                    doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                    doc.EndPrint();
                }
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir etiquetas: " + ex.Message);
            }
        }
        private string MountDescription(ListViewGroup group, out string esteira)
        {
            var sb = new StringBuilder();
            var esteiras = new List<string>();

            foreach (ListViewItem item in group.Items.Cast<ListViewItem>().Skip(1))
            {
                var itemText = item.Text?.Trim();
                if (string.IsNullOrWhiteSpace(itemText)) continue;

                if (sb.Length > 0)
                {
                    sb.AppendLine(); // linha em branco entre itens
                }

                var qtd = item.SubItems.Count > 1 ? item.SubItems[1].Text?.Trim() ?? string.Empty : string.Empty;
                var casas = item.SubItems.Count > 2 && !string.IsNullOrWhiteSpace(item.SubItems[2].Text) ? $"({item.SubItems[2].Text.Trim()})" : string.Empty;
                var itemEsteira = item.SubItems.Count > 3 ? item.SubItems[3].Text?.Trim() ?? string.Empty : string.Empty;

                if (!string.IsNullOrEmpty(itemEsteira))
                {
                    esteiras.Add(itemEsteira);
                    sb.AppendLine($"({itemEsteira}) - {itemText}");
                }
                else
                {
                    sb.AppendLine(itemText);
                }

                sb.Append("Quantidade: ");
                sb.Append(qtd);
                if (!string.IsNullOrEmpty(casas))
                {
                    sb.Append(' ');
                    sb.Append(casas);
                }
                sb.AppendLine();
            }

            sb.AppendLine(group.Name);

            // junta todas as esteiras encontradas, sem duplicatas, separadas por vírgula
            esteira = string.Join(" ", esteiras.Distinct());

            return sb.ToString();
        }
    }
}
