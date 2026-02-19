
namespace Etiquetas_Pedidos.Services
{
    internal class FormListView
    {
        private readonly ListView _listView;
        public FormListView(ListView listView)
        {
            _listView = listView ?? throw new ArgumentNullException(nameof(listView));
        }

        public void AjustGroups(int qtd)
        {
            int actualGroups = _listView.Groups.Count;
            if (qtd <= 0) _listView.Clear();
            for (int i = 0; i < actualGroups && i < qtd; i++)
            {
                _listView.Groups[i].Header = $"Volume {i + 1} de {qtd}";
                _listView.Groups[i].Name = $"Volume {i + 1} de {qtd}";
            }
            if (actualGroups > qtd)
            {
                for (int i = actualGroups - 1; i >= qtd; i--)
                {
                    var groupRemove = _listView.Groups[i];
                    for (int j = _listView.Items.Count - 1; j >= qtd; j--)
                    {
                        if (_listView.Items[j].Group == groupRemove)
                        {
                            _listView.Items.RemoveAt(j);
                        }
                    }
                    _listView.Groups.RemoveAt(i);
                }
            }
            else if (actualGroups < qtd)
            {
                for (int i = actualGroups + 1; i <= qtd; i++)
                {
                    CreateGroups(i, qtd);
                }
            }
        }
        private void CreateGroups(int i, int qtd)
        {
            var group = new ListViewGroup($"Volume {i} de {qtd}", HorizontalAlignment.Left)
            {
                Name = $"Volume {i} de {qtd}"
            };
            _listView.Groups.Add(group);
            var item = new ListViewItem("Arraste Aqui") { Group = group };
            _listView.Items.Add(item);
        }

        public void AllinOne(DataGridView dgv)
        {
           var group = _listView.Groups[0]; // sempre pega o primeiro grupo

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string description = (row.Cells["Code"].Value.ToString() ?? "")
                                        + " "
                                        + (row.Cells["ProductName"].Value.ToString() ?? "");
                    string quantity = (row.Cells["Quantity"].Value.ToString() ?? "")
                                        + " "
                                        + (row.Cells["Unit"].Value.ToString() ?? "");
                    string casas = row.Cells["Casas"].Value?.ToString() ?? "";
                    string esteira = row.Cells["Esteira"].Value?.ToString() ?? "";

                    var item = new ListViewItem(description) { Group = group };
                    item.SubItems.Add(quantity);
                    item.SubItems.Add(casas);
                    item.SubItems.Add(esteira);

                    _listView.Items.Add(item);
                }
            }
        }

        public bool OneinAll(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha primeiro!","Seleção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            // pega a linha selecionada (a primeira, caso selecione mais de uma)
            DataGridViewRow row = dgv.SelectedRows[0];

            // pega os valores das células
            string description = (row.Cells["Code"].Value.ToString() ?? "")
                                                    + " "
                                                    + (row.Cells["ProductName"].Value.ToString() ?? "");
            string quantity = (row.Cells["Quantity"].Value.ToString() ?? "")
                                + " "
                                + (row.Cells["Unit"].Value.ToString() ?? "");
            string casas = row.Cells["Casas"].Value?.ToString() ?? "";
            string esteira = row.Cells["Esteira"].Value?.ToString() ?? "";

            // percorre todos os grupos já existentes no ListView
            foreach (ListViewGroup group in _listView.Groups)
            {
                var item = new ListViewItem(description) { Group = group };
                item.SubItems.Add(quantity);
                item.SubItems.Add(casas);
                item.SubItems.Add(esteira);

                _listView.Items.Add(item);
            }
            return true;
        }
    }
}


