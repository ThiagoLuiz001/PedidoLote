namespace PedidoLote
{
    partial class Impressao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ChkStatus = new CheckBox();
            CBEmitido = new ComboBox();
            label1 = new Label();
            PBLoad = new ProgressBar();
            LblItem = new Label();
            BtnImpressao = new Button();
            groupBox1 = new GroupBox();
            GradeDados = new DataGridView();
            clPedido = new DataGridViewTextBoxColumn();
            clCliente = new DataGridViewTextBoxColumn();
            clOPs = new DataGridViewTextBoxColumn();
            clVerdade = new DataGridViewCheckBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            CBNaoEmitido = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GradeDados).BeginInit();
            SuspendLayout();
            // 
            // ChkStatus
            // 
            ChkStatus.AutoSize = true;
            ChkStatus.Location = new Point(635, 136);
            ChkStatus.Name = "ChkStatus";
            ChkStatus.Size = new Size(58, 19);
            ChkStatus.TabIndex = 13;
            ChkStatus.Text = "Status";
            ChkStatus.UseVisualStyleBackColor = true;
            // 
            // CBEmitido
            // 
            CBEmitido.FormattingEnabled = true;
            CBEmitido.Location = new Point(635, 176);
            CBEmitido.Name = "CBEmitido";
            CBEmitido.Size = new Size(100, 23);
            CBEmitido.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 158);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 11;
            label1.Text = "Pedidos Emitidos:";
            // 
            // PBLoad
            // 
            PBLoad.Location = new Point(635, 120);
            PBLoad.Name = "PBLoad";
            PBLoad.Size = new Size(100, 10);
            PBLoad.TabIndex = 10;
            // 
            // LblItem
            // 
            LblItem.AutoSize = true;
            LblItem.Location = new Point(633, 102);
            LblItem.Name = "LblItem";
            LblItem.Size = new Size(44, 15);
            LblItem.TabIndex = 9;
            LblItem.Text = "Pedido";
            // 
            // BtnImpressao
            // 
            BtnImpressao.Location = new Point(631, 41);
            BtnImpressao.Name = "BtnImpressao";
            BtnImpressao.Size = new Size(105, 42);
            BtnImpressao.TabIndex = 8;
            BtnImpressao.Text = "&Gerar Lotes";
            BtnImpressao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GradeDados);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 314);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lote dos Pedidos:";
            // 
            // GradeDados
            // 
            GradeDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GradeDados.Columns.AddRange(new DataGridViewColumn[] { clPedido, clCliente, clOPs, clVerdade });
            GradeDados.Location = new Point(8, 22);
            GradeDados.Name = "GradeDados";
            GradeDados.Size = new Size(599, 286);
            GradeDados.TabIndex = 0;
            // 
            // clPedido
            // 
            clPedido.HeaderText = "Pedido";
            clPedido.Name = "clPedido";
            clPedido.ReadOnly = true;
            clPedido.Width = 80;
            // 
            // clCliente
            // 
            clCliente.HeaderText = "Cliente";
            clCliente.Name = "clCliente";
            clCliente.ReadOnly = true;
            clCliente.Width = 300;
            // 
            // clOPs
            // 
            clOPs.HeaderText = "OPs";
            clOPs.Name = "clOPs";
            clOPs.ReadOnly = true;
            clOPs.Width = 80;
            // 
            // clVerdade
            // 
            clVerdade.HeaderText = "Existe";
            clVerdade.Name = "clVerdade";
            clVerdade.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 212);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 14;
            label2.Text = "Sem Emissão:";
            // 
            // CBNaoEmitido
            // 
            CBNaoEmitido.FormattingEnabled = true;
            CBNaoEmitido.Location = new Point(635, 230);
            CBNaoEmitido.Name = "CBNaoEmitido";
            CBNaoEmitido.Size = new Size(101, 23);
            CBNaoEmitido.TabIndex = 15;
            // 
            // Impressao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 327);
            Controls.Add(CBNaoEmitido);
            Controls.Add(label2);
            Controls.Add(ChkStatus);
            Controls.Add(CBEmitido);
            Controls.Add(label1);
            Controls.Add(PBLoad);
            Controls.Add(LblItem);
            Controls.Add(BtnImpressao);
            Controls.Add(groupBox1);
            Name = "Impressao";
            Text = "Impressao";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GradeDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkStatus;
        private ComboBox CBEmitido;
        private Label label1;
        private ProgressBar PBLoad;
        private Label LblItem;
        private Button BtnImpressao;
        private GroupBox groupBox1;
        private DataGridView GradeDados;
        private DataGridViewTextBoxColumn clPedido;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewTextBoxColumn clOPs;
        private DataGridViewCheckBoxColumn clVerdade;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private ComboBox CBNaoEmitido;
    }
}