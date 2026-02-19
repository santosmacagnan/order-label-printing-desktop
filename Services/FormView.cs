using Etiquetas_Pedidos.Data;
using Etiquetas_Pedidos.Model;
using Oracle.ManagedDataAccess.Client;

namespace Etiquetas_Pedidos.Services
{
    internal class FormView
    {
        public List<Order> ListaPedidosAbertos(OracleConnection connection)
        {
            Consults consults = new();
            List<Order> listOrders = consults.OrdersOpened(connection);
            if (listOrders == null) return null;
            listOrders.Insert(0, new Order("Selecione um pedido", " "));
            return listOrders;            
        }
        public void Colunasdatagrid(DataGridView DtgGrid)
        {            
            DtgGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DtgGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgGrid.AllowUserToResizeColumns=false;
            DtgGrid.AllowUserToResizeRows=false;
            
            DtgGrid.ReadOnly = false;
            DtgGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            DtgGrid.Columns["Code"].HeaderText = "Código";
            DtgGrid.Columns["Code"].ReadOnly = true;
            DtgGrid.Columns["Code"].Width = 120;

            DtgGrid.Columns["ProductName"].HeaderText = "Descrição";
            DtgGrid.Columns["ProductName"].ReadOnly = true;
            DtgGrid.Columns["ProductName"].Width = 500;
            DtgGrid.Columns["ProductName"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DtgGrid.Columns["Quantity"].HeaderText = "Quant";
            DtgGrid.Columns["Quantity"].ReadOnly = false;
            DtgGrid.Columns["Quantity"].Width = 75;

            DtgGrid.Columns["Unit"].HeaderText = "Un";
            DtgGrid.Columns["Unit"].ReadOnly = true;
            DtgGrid.Columns["Unit"].Width = 50;

            if (!DtgGrid.Columns.Contains("Casas"))
            {
                DtgGrid.Columns.Add("Casas", "Casas");
                DtgGrid.Columns["Casas"].Width = 150;
            }
            if (!DtgGrid.Columns.Contains("Esteira"))
            {
                DtgGrid.Columns.Add("Esteira", "Esteira");
                DtgGrid.Columns["Esteira"].Width = 150;
                
            }
        }
    }
}
