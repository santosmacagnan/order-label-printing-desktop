using Etiquetas_Pedidos.Data;
using Etiquetas_Pedidos.Model;
using Etiquetas_Pedidos.Services;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Timer = System.Windows.Forms.Timer;
namespace Etiquetas_Pedidos
{
    public partial class FormEtiquetaPedidos : Form
    {
        private Point dragStart;
        public FormEtiquetaPedidos()
        {
            InitializeComponent();
        }
        private void FormEtiquetaPedidos_Load(object sender, EventArgs e)
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
                    connection.Open();
                    label2.Text = "Conectado";
                    label2.BackColor = Color.Green;
                    label2.ForeColor = Color.White;
                    ListaPedidosAbertos(connectionString);
                    Timer timer = new()
                    {
                        Interval = 1800000 // Intervalo de 30 minutos (30 * 60 * 1000 milissegundos)
                    };
                    timer.Tick += (s, args) => ListaPedidosAbertos(connectionString);
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                label2.Text = "Desconectado";
                label2.BackColor = Color.Red;
                label2.ForeColor = Color.White;
            }
        }
        public void ListaPedidosAbertos(string connectionString)
        {
            try
            {
                using (var conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    // aqui você chama a rotina que busca os pedidos
                    FormView formView = new();
                    List<Order> lista = formView.ListaPedidosAbertos(conn);

                    BoxOrdersOpened.DataSource = lista;
                    BoxOrdersOpened.DisplayMember = "ListOrder";
                    BoxOrdersOpened.ValueMember = "OrderCode";

                    // se chegou até aqui = conectado
                    label2.Text = "Conectado";
                    label2.BackColor = Color.Green;
                    label2.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar pedidos abertos: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                label2.Text = "Desconectado";
                label2.BackColor = Color.Red;
                label2.ForeColor = Color.White;
            }
        }
        private void DtgdVwItensPedido_MouseDown(object sender, MouseEventArgs e)
        {
            dragStart = e.Location;
        }
        private void BoxOrdersOpened_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (BoxOrdersOpened.SelectedItem is Order pedidoSelecionado)
            {
                if (pedidoSelecionado.OrderCode != "Selecione um pedido")
                {
                    string nome = pedidoSelecionado.OrderCode;
                    var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);

                    IConfiguration config = builder.Build();

                    string connectionString = config.GetConnectionString("ConexaoOracle");

                    using (var connection = new OracleConnection(connectionString))
                    {
                        Consults consults = new();
                        List<OrderItens> listOrdersItens = consults.OrderItens(nome, connection);

                        DtgdVwItensPedido.DataSource = listOrdersItens;
                        FormView form = new();

                        form.Colunasdatagrid(DtgdVwItensPedido);

                        LstVolumes.Clear();
                        LstVolumes.Groups.Clear();
                        TxtBxVolumes.Clear();
                    }
                }
                else
                {
                    LstVolumes.Clear();
                    LstVolumes.Groups.Clear();
                    TxtBxVolumes.Clear();
                    DtgdVwItensPedido.DataSource = null;
                    DtgdVwItensPedido.Rows.Clear();
                    DtgdVwItensPedido.Columns.Clear();
                }
                PrintBtn.Enabled = false;
                BtnAll.Enabled = false;
                BtnMulti.Enabled = false;
            }
        }
        private void TxtBxVolumes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var groups = new FormListView(LstVolumes);
                int vol = int.Parse(TxtBxVolumes.Text);
                if (LstVolumes.Columns.Count == 0)
                {
                    LstVolumes.Columns.Add("Description", 1000);
                    LstVolumes.Columns.Add("Quantidade", 200);
                    LstVolumes.Columns.Add("Casas", 200);
                    LstVolumes.Columns.Add("Esteira", 200);
                }
                groups.AjustGroups(vol);
                if (vol == 1)
                {
                    BtnAll.Enabled = true;
                    BtnMulti.Enabled = false;
                }
                else
                {
                    BtnAll.Enabled = false;
                    BtnMulti.Enabled = true;
                }
            }
        }
        private void LstVolumes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string[])))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void LstVolumes_DragDrop(object sender, DragEventArgs e)
        {
            Point point = LstVolumes.PointToClient(new Point(e.X, e.Y));
            ListViewItem hoveredItem = LstVolumes.GetItemAt(point.X, point.Y);
            ListViewGroup targetGroup = hoveredItem?.Group ?? LstVolumes.Groups.Cast<ListViewGroup>().FirstOrDefault();

            if (e.Data.GetDataPresent(typeof(string[])))
            {
                string[] values = e.Data.GetData(typeof(string[])) as string[];
                var item = new ListViewItem(values[0], targetGroup);
                item.SubItems.Add(values[1]);
                item.SubItems.Add(values[2]);
                item.SubItems.Add(values[3]);
                LstVolumes.Items.Add(item);
                PrintBtn.Enabled = LstVolumes.Items.Count > 1;
            }
        }
        private void LstVolumes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in LstVolumes.SelectedItems)
                {
                    LstVolumes.Items.Remove(item);
                }
            }
        }
        private void TxtBxVolumes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void DtgdVwItensPedido_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            // Só inicia se mover mais de 5px
            if (Math.Abs(e.X - dragStart.X) <= 5 && Math.Abs(e.Y - dragStart.Y) <= 5) return;

            int rowIndex = DtgdVwItensPedido.HitTest(e.X, e.Y).RowIndex;
            if (rowIndex < 0) return;

            // Se estiver editando, finaliza e força foco no grid
            if (DtgdVwItensPedido.IsCurrentCellInEditMode)
            {
                DtgdVwItensPedido.EndEdit();
                DtgdVwItensPedido.Focus();
            }

            // Seleciona a linha clicada
            DtgdVwItensPedido.ClearSelection();
            DtgdVwItensPedido.Rows[rowIndex].Selected = true;

            var r = DtgdVwItensPedido.Rows[rowIndex];

            string[] dados = [
                              $"{r.Cells["Code"].Value} {r.Cells["ProductName"].Value}",
                              $"{r.Cells["Quantity"].Value} {r.Cells["Unit"].Value}",
                              r.Cells["Casas"].Value?.ToString() ?? "",
                              r.Cells["Esteira"].Value?.ToString() ?? ""
            ];

            DtgdVwItensPedido.DoDragDrop(dados, DragDropEffects.Copy);
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            var print = new Print();
            print.PrintBrotherQL(BoxOrdersOpened, LstVolumes);
        }
        private void BtnPrintAmostra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCliente.Text) || string.IsNullOrWhiteSpace(TxtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha os campos Cliente e Descrição para imprimir a amostra.", "Faltando Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var print = new Print();
            print.PrintAmostra(TxtCliente.Text, TxtDescricao.Text);
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCliente.Clear();
            TxtDescricao.Clear();
        }
        private void BoxOrdersOpened_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (BoxOrdersOpened.Text != "Selecione um pedido -  ")
                {
                    string selected = BoxOrdersOpened.Text;
                    string code = selected.Split('-')[0].Trim();
                    var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appconfig.json", optional: false, reloadOnChange: true);

                    IConfiguration config = builder.Build();

                    string connectionString = config.GetConnectionString("ConexaoOracle");

                    using (var connection = new OracleConnection(connectionString))
                    {
                        Consults consults = new();
                        List<OrderItens> listOrdersItens = consults.OrderItens(code, connection);

                        DtgdVwItensPedido.DataSource = listOrdersItens;
                        FormView form = new();

                        form.Colunasdatagrid(DtgdVwItensPedido);

                        LstVolumes.Clear();
                        LstVolumes.Groups.Clear();
                        TxtBxVolumes.Clear();
                    }
                }
                PrintBtn.Enabled = false;
            }

        }
        private void BtnAll_Click(object sender, EventArgs e)
        {
            FormListView groups = new(LstVolumes);
            groups.AllinOne(DtgdVwItensPedido);
            PrintBtn.Enabled = true;
        }
        private void BtnMulti_Click(object sender, EventArgs e)
        {
            FormListView groups = new(LstVolumes);
            var ret = groups.OneinAll(DtgdVwItensPedido);
            if (ret == true)
                PrintBtn.Enabled = true;
        }

        private void DtgdVwItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BoxOrdersOpened_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
