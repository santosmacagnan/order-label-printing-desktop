namespace Etiquetas_Pedidos
{
    partial class FormEtiquetaPedidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtiquetaPedidos));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DtgdVwItensPedido = new DataGridView();
            tabPage2 = new TabPage();
            cmbClient = new ComboBox();
            chkBxCliente = new CheckBox();
            dtgViewAvulso = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Obs = new DataGridViewTextBoxColumn();
            Null = new DataGridViewTextBoxColumn();
            BtnMulti = new Button();
            BtnAll = new Button();
            PrintBtn = new Button();
            LstVolumes = new ListView();
            TxtBxVolumes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BoxOrdersOpened = new ComboBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgdVwItensPedido).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgViewAvulso).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 53);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1175, 356);
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DtgdVwItensPedido);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(1);
            tabPage1.Size = new Size(1167, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Etiquetas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DtgdVwItensPedido
            // 
            DtgdVwItensPedido.AllowDrop = true;
            DtgdVwItensPedido.AllowUserToAddRows = false;
            DtgdVwItensPedido.AllowUserToDeleteRows = false;
            DtgdVwItensPedido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtgdVwItensPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgdVwItensPedido.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DtgdVwItensPedido.ColumnHeadersHeight = 50;
            DtgdVwItensPedido.Location = new Point(6, 12);
            DtgdVwItensPedido.Margin = new Padding(1);
            DtgdVwItensPedido.MultiSelect = false;
            DtgdVwItensPedido.Name = "DtgdVwItensPedido";
            DtgdVwItensPedido.ReadOnly = true;
            DtgdVwItensPedido.RowHeadersWidth = 30;
            DtgdVwItensPedido.ShowEditingIcon = false;
            DtgdVwItensPedido.Size = new Size(1155, 303);
            DtgdVwItensPedido.TabIndex = 2;
            DtgdVwItensPedido.MouseDown += DtgdVwItensPedido_MouseDown;
            DtgdVwItensPedido.MouseMove += DtgdVwItensPedido_MouseMove;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbClient);
            tabPage2.Controls.Add(chkBxCliente);
            tabPage2.Controls.Add(dtgViewAvulso);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1);
            tabPage2.Size = new Size(1167, 323);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Avulso";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbClient
            // 
            cmbClient.Enabled = false;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(92, 270);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(593, 28);
            cmbClient.TabIndex = 6;
            cmbClient.TextChanged += cmbClient_TextChanged;
            // 
            // chkBxCliente
            // 
            chkBxCliente.AutoSize = true;
            chkBxCliente.Location = new Point(9, 272);
            chkBxCliente.Name = "chkBxCliente";
            chkBxCliente.Size = new Size(77, 24);
            chkBxCliente.TabIndex = 4;
            chkBxCliente.Text = "Cliente";
            chkBxCliente.UseVisualStyleBackColor = true;
            chkBxCliente.CheckStateChanged += chkBxCliente_CheckStateChanged;
            // 
            // dtgViewAvulso
            // 
            dtgViewAvulso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgViewAvulso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgViewAvulso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgViewAvulso.ColumnHeadersHeight = 50;
            dtgViewAvulso.Columns.AddRange(new DataGridViewColumn[] { Code, Description, Quantity, Unit, Obs, Null });
            dtgViewAvulso.Location = new Point(6, 12);
            dtgViewAvulso.Margin = new Padding(1);
            dtgViewAvulso.MultiSelect = false;
            dtgViewAvulso.Name = "dtgViewAvulso";
            dtgViewAvulso.RowHeadersWidth = 30;
            dtgViewAvulso.Size = new Size(1155, 226);
            dtgViewAvulso.TabIndex = 3;
            dtgViewAvulso.CellEndEdit += dtgViewAvulso_CellEndEdit;
            dtgViewAvulso.MouseDown += dtgViewAvulso_MouseDown;
            dtgViewAvulso.MouseMove += dtgViewAvulso_MouseMove;
            // 
            // Code
            // 
            Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Code.FillWeight = 133.6898F;
            Code.HeaderText = "Código";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            Code.Width = 150;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.FillWeight = 65.00358F;
            Description.HeaderText = "Descrição";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantity.FillWeight = 0.498073071F;
            Quantity.HeaderText = "Quantidade";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Unit
            // 
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Unit.FillWeight = 0.498073071F;
            Unit.HeaderText = "Unidade";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.Width = 125;
            // 
            // Obs
            // 
            Obs.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Obs.FillWeight = 300.3104F;
            Obs.HeaderText = "Observação";
            Obs.MinimumWidth = 6;
            Obs.Name = "Obs";
            Obs.Width = 300;
            // 
            // Null
            // 
            Null.HeaderText = "Column1";
            Null.MinimumWidth = 6;
            Null.Name = "Null";
            Null.Visible = false;
            // 
            // BtnMulti
            // 
            BtnMulti.Enabled = false;
            BtnMulti.FlatStyle = FlatStyle.System;
            BtnMulti.Location = new Point(675, 411);
            BtnMulti.Margin = new Padding(1);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(90, 33);
            BtnMulti.TabIndex = 8;
            BtnMulti.Tag = "";
            BtnMulti.Text = "Multiplos";
            BtnMulti.UseVisualStyleBackColor = true;
            BtnMulti.Click += BtnMulti_Click;
            // 
            // BtnAll
            // 
            BtnAll.Enabled = false;
            BtnAll.FlatStyle = FlatStyle.System;
            BtnAll.Location = new Point(557, 411);
            BtnAll.Margin = new Padding(1);
            BtnAll.Name = "BtnAll";
            BtnAll.Size = new Size(90, 33);
            BtnAll.TabIndex = 7;
            BtnAll.Text = "Todos";
            BtnAll.UseVisualStyleBackColor = true;
            BtnAll.Click += BtnAll_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Enabled = false;
            PrintBtn.FlatStyle = FlatStyle.System;
            PrintBtn.Location = new Point(439, 411);
            PrintBtn.Margin = new Padding(1);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(90, 33);
            PrintBtn.TabIndex = 6;
            PrintBtn.Text = "Imprimir";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // LstVolumes
            // 
            LstVolumes.AllowDrop = true;
            LstVolumes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LstVolumes.FullRowSelect = true;
            LstVolumes.HeaderStyle = ColumnHeaderStyle.None;
            LstVolumes.LabelWrap = false;
            LstVolumes.Location = new Point(14, 465);
            LstVolumes.Margin = new Padding(1);
            LstVolumes.MultiSelect = false;
            LstVolumes.Name = "LstVolumes";
            LstVolumes.Size = new Size(1152, 382);
            LstVolumes.TabIndex = 5;
            LstVolumes.UseCompatibleStateImageBehavior = false;
            LstVolumes.View = View.Details;
            LstVolumes.DragDrop += LstVolumes_DragDrop;
            LstVolumes.DragEnter += LstVolumes_DragEnter;
            LstVolumes.KeyDown += LstVolumes_KeyDown;
            // 
            // TxtBxVolumes
            // 
            TxtBxVolumes.Location = new Point(303, 417);
            TxtBxVolumes.Margin = new Padding(1);
            TxtBxVolumes.Name = "TxtBxVolumes";
            TxtBxVolumes.Size = new Size(60, 27);
            TxtBxVolumes.TabIndex = 4;
            TxtBxVolumes.KeyDown += TxtBxVolumes_KeyDown;
            TxtBxVolumes.KeyPress += TxtBxVolumes_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 420);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Volumes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1035, 420);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Conectando...";
            // 
            // BoxOrdersOpened
            // 
            BoxOrdersOpened.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxOrdersOpened.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BoxOrdersOpened.AutoCompleteSource = AutoCompleteSource.ListItems;
            BoxOrdersOpened.FormattingEnabled = true;
            BoxOrdersOpened.Location = new Point(84, 10);
            BoxOrdersOpened.Margin = new Padding(1);
            BoxOrdersOpened.Name = "BoxOrdersOpened";
            BoxOrdersOpened.Size = new Size(1081, 28);
            BoxOrdersOpened.TabIndex = 1;
            BoxOrdersOpened.SelectionChangeCommitted += BoxOrdersOpened_SelectionChangeCommitted;
            BoxOrdersOpened.KeyDown += BoxOrdersOpened_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Pedidos";
            // 
            // FormEtiquetaPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 862);
            Controls.Add(BtnMulti);
            Controls.Add(tabControl1);
            Controls.Add(BtnAll);
            Controls.Add(BoxOrdersOpened);
            Controls.Add(PrintBtn);
            Controls.Add(label1);
            Controls.Add(TxtBxVolumes);
            Controls.Add(LstVolumes);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MinimumSize = new Size(778, 452);
            Name = "FormEtiquetaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiquetas de Pedidos";
            WindowState = FormWindowState.Maximized;
            Load += FormEtiquetaPedidos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtgdVwItensPedido).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgViewAvulso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox BoxOrdersOpened;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private DataGridView DtgdVwItensPedido;
        private ListView LstVolumes;
        private TextBox TxtBxVolumes;
        private Label label3;
        private Button PrintBtn;
        private Button BtnMulti;
        private Button BtnAll;
        private DataGridView dtgViewAvulso;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Obs;
        private DataGridViewTextBoxColumn Null;
        private CheckBox chkBxCliente;
        private ComboBox cmbClient;
    }
}
