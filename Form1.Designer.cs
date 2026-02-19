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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtiquetaPedidos));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnMulti = new Button();
            BtnAll = new Button();
            PrintBtn = new Button();
            LstVolumes = new ListView();
            TxtBxVolumes = new TextBox();
            label3 = new Label();
            label2 = new Label();
            DtgdVwItensPedido = new DataGridView();
            BoxOrdersOpened = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            BtnClear = new Button();
            BtnPrintAmostra = new Button();
            TxtDescricao = new TextBox();
            TxtCliente = new TextBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtgdVwItensPedido).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1191, 718);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnMulti);
            tabPage1.Controls.Add(BtnAll);
            tabPage1.Controls.Add(PrintBtn);
            tabPage1.Controls.Add(LstVolumes);
            tabPage1.Controls.Add(TxtBxVolumes);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(DtgdVwItensPedido);
            tabPage1.Controls.Add(BoxOrdersOpened);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(1);
            tabPage1.Size = new Size(1183, 685);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Etiquetas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnMulti
            // 
            BtnMulti.Enabled = false;
            BtnMulti.FlatStyle = FlatStyle.System;
            BtnMulti.Location = new Point(708, 372);
            BtnMulti.Margin = new Padding(1);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(90, 33);
            BtnMulti.TabIndex = 8;
            BtnMulti.Tag = "";
            BtnMulti.Text = "Multiplos";
            toolTip1.SetToolTip(BtnMulti, "Se você quiser inserir uma linha em todas as etiquetas, selecione a linha e clique aqui");
            BtnMulti.UseVisualStyleBackColor = true;
            BtnMulti.Click += BtnMulti_Click;
            // 
            // BtnAll
            // 
            BtnAll.Enabled = false;
            BtnAll.FlatStyle = FlatStyle.System;
            BtnAll.Location = new Point(590, 372);
            BtnAll.Margin = new Padding(1);
            BtnAll.Name = "BtnAll";
            BtnAll.Size = new Size(90, 33);
            BtnAll.TabIndex = 7;
            BtnAll.Text = "Todos";
            toolTip1.SetToolTip(BtnAll, "Se você quiser inserir todas as linhas de uma vez só em um única etiqueta, clique aqui.");
            BtnAll.UseVisualStyleBackColor = true;
            BtnAll.Click += BtnAll_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Enabled = false;
            PrintBtn.FlatStyle = FlatStyle.System;
            PrintBtn.Location = new Point(472, 372);
            PrintBtn.Margin = new Padding(1);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(90, 33);
            PrintBtn.TabIndex = 6;
            PrintBtn.Text = "Imprimir";
            toolTip1.SetToolTip(PrintBtn, "Hum, agora está bonito já pode imprimir");
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // LstVolumes
            // 
            LstVolumes.AllowDrop = true;
            LstVolumes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LstVolumes.FullRowSelect = true;
            LstVolumes.HeaderStyle = ColumnHeaderStyle.None;
            LstVolumes.LabelWrap = false;
            LstVolumes.Location = new Point(17, 420);
            LstVolumes.Margin = new Padding(1);
            LstVolumes.MultiSelect = false;
            LstVolumes.Name = "LstVolumes";
            LstVolumes.Size = new Size(1152, 253);
            LstVolumes.TabIndex = 5;
            LstVolumes.UseCompatibleStateImageBehavior = false;
            LstVolumes.View = View.Details;
            LstVolumes.DragDrop += LstVolumes_DragDrop;
            LstVolumes.DragEnter += LstVolumes_DragEnter;
            LstVolumes.KeyDown += LstVolumes_KeyDown;
            // 
            // TxtBxVolumes
            // 
            TxtBxVolumes.Location = new Point(336, 378);
            TxtBxVolumes.Margin = new Padding(1);
            TxtBxVolumes.Name = "TxtBxVolumes";
            TxtBxVolumes.Size = new Size(60, 27);
            TxtBxVolumes.TabIndex = 4;
            toolTip1.SetToolTip(TxtBxVolumes, "Não se esqueça de teclar enter");
            TxtBxVolumes.KeyDown += TxtBxVolumes_KeyDown;
            TxtBxVolumes.KeyPress += TxtBxVolumes_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 381);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Volumes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1068, 381);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Conectando...";
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
            DtgdVwItensPedido.Location = new Point(17, 50);
            DtgdVwItensPedido.Margin = new Padding(1);
            DtgdVwItensPedido.MultiSelect = false;
            DtgdVwItensPedido.Name = "DtgdVwItensPedido";
            DtgdVwItensPedido.ReadOnly = true;
            DtgdVwItensPedido.RowHeadersWidth = 30;
            DtgdVwItensPedido.ShowEditingIcon = false;
            DtgdVwItensPedido.Size = new Size(1149, 303);
            DtgdVwItensPedido.TabIndex = 2;
            DtgdVwItensPedido.CellContentClick += DtgdVwItensPedido_CellContentClick;
            DtgdVwItensPedido.MouseDown += DtgdVwItensPedido_MouseDown;
            DtgdVwItensPedido.MouseMove += DtgdVwItensPedido_MouseMove;
            // 
            // BoxOrdersOpened
            // 
            BoxOrdersOpened.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxOrdersOpened.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BoxOrdersOpened.AutoCompleteSource = AutoCompleteSource.ListItems;
            BoxOrdersOpened.FormattingEnabled = true;
            BoxOrdersOpened.Location = new Point(80, 15);
            BoxOrdersOpened.Margin = new Padding(1);
            BoxOrdersOpened.Name = "BoxOrdersOpened";
            BoxOrdersOpened.Size = new Size(1086, 28);
            BoxOrdersOpened.TabIndex = 1;
            toolTip1.SetToolTip(BoxOrdersOpened, "Que tal me escolher primeiro?");
            BoxOrdersOpened.SelectedIndexChanged += BoxOrdersOpened_SelectedIndexChanged;
            BoxOrdersOpened.SelectionChangeCommitted += BoxOrdersOpened_SelectionChangeCommitted;
            BoxOrdersOpened.KeyDown += BoxOrdersOpened_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 18);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Pedidos";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(BtnClear);
            tabPage2.Controls.Add(BtnPrintAmostra);
            tabPage2.Controls.Add(TxtDescricao);
            tabPage2.Controls.Add(TxtCliente);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1);
            tabPage2.Size = new Size(1183, 685);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Amostra";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(260, 77);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Descrição";
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(593, 307);
            BtnClear.Margin = new Padding(1);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(90, 29);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Limpar";
            toolTip1.SetToolTip(BtnClear, "Limpando...");
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnPrintAmostra
            // 
            BtnPrintAmostra.Location = new Point(483, 307);
            BtnPrintAmostra.Margin = new Padding(1);
            BtnPrintAmostra.Name = "BtnPrintAmostra";
            BtnPrintAmostra.Size = new Size(90, 29);
            BtnPrintAmostra.TabIndex = 3;
            BtnPrintAmostra.Text = "Imprimir";
            toolTip1.SetToolTip(BtnPrintAmostra, "Tem certeza disso?");
            BtnPrintAmostra.UseVisualStyleBackColor = true;
            BtnPrintAmostra.Click += BtnPrintAmostra_Click;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDescricao.CharacterCasing = CharacterCasing.Upper;
            TxtDescricao.Location = new Point(260, 107);
            TxtDescricao.Margin = new Padding(1);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(688, 175);
            TxtDescricao.TabIndex = 2;
            // 
            // TxtCliente
            // 
            TxtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCliente.CharacterCasing = CharacterCasing.Upper;
            TxtCliente.Location = new Point(301, 29);
            TxtCliente.Margin = new Padding(1);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(644, 27);
            TxtCliente.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(247, 30);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Cliente";
            // 
            // FormEtiquetaPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 718);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MinimumSize = new Size(778, 452);
            Name = "FormEtiquetaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etiquetas de Pedidos";
            Load += FormEtiquetaPedidos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DtgdVwItensPedido).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
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
        private TextBox TxtCliente;
        private Label label4;
        private TextBox TxtDescricao;
        private Button BtnPrintAmostra;
        private Button BtnClear;
        private Button BtnMulti;
        private Button BtnAll;
        private ToolTip toolTip1;
        private Label label5;
    }
}
