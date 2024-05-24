namespace TelaImpressao
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            GradeDados = new DataGridView();
            clPedido = new DataGridViewTextBoxColumn();
            clCliente = new DataGridViewTextBoxColumn();
            clOPs = new DataGridViewTextBoxColumn();
            clVerdade = new DataGridViewCheckBoxColumn();
            BtnImpressao = new Button();
            LblItem = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ChkStatus = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GradeDados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GradeDados);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 314);
            groupBox1.TabIndex = 0;
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
            // BtnImpressao
            // 
            BtnImpressao.Location = new Point(626, 43);
            BtnImpressao.Name = "BtnImpressao";
            BtnImpressao.Size = new Size(102, 42);
            BtnImpressao.TabIndex = 1;
            BtnImpressao.Text = "&Gerar Lotes";
            BtnImpressao.UseVisualStyleBackColor = true;
            // 
            // LblItem
            // 
            LblItem.AutoSize = true;
            LblItem.Location = new Point(628, 104);
            LblItem.Name = "LblItem";
            LblItem.Size = new Size(44, 15);
            LblItem.TabIndex = 2;
            LblItem.Text = "Pedido";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(630, 122);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 17);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(630, 178);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Pedidos Gerados:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(630, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 5;
            // 
            // ChkStatus
            // 
            ChkStatus.AutoSize = true;
            ChkStatus.Location = new Point(629, 145);
            ChkStatus.Name = "ChkStatus";
            ChkStatus.Size = new Size(58, 19);
            ChkStatus.TabIndex = 6;
            ChkStatus.Text = "Status";
            ChkStatus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 338);
            Controls.Add(ChkStatus);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(LblItem);
            Controls.Add(BtnImpressao);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gerador de Lote";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GradeDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView GradeDados;
        private DataGridViewTextBoxColumn clPedido;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewTextBoxColumn clOPs;
        private DataGridViewCheckBoxColumn clVerdade;
        private Button BtnImpressao;
        private Label LblItem;
        private ProgressBar progressBar1;
        private Label label1;
        private ComboBox comboBox1;
        private CheckBox ChkStatus;
    }
}
