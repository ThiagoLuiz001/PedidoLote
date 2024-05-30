namespace PedidoLote
{
    partial class Inicial
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
            TxtPedido = new TextBox();
            groupBox1 = new GroupBox();
            BtnLancar = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            GradePedido = new DataGridView();
            clPedidos = new DataGridViewTextBoxColumn();
            clApagar = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GradePedido).BeginInit();
            SuspendLayout();
            // 
            // TxtPedido
            // 
            TxtPedido.Location = new Point(6, 29);
            TxtPedido.Name = "TxtPedido";
            TxtPedido.Size = new Size(105, 23);
            TxtPedido.TabIndex = 0;
            TxtPedido.KeyDown += TxtPedido_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnLancar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtPedido);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // BtnLancar
            // 
            BtnLancar.Location = new Point(171, 19);
            BtnLancar.Name = "BtnLancar";
            BtnLancar.Size = new Size(98, 41);
            BtnLancar.TabIndex = 2;
            BtnLancar.Text = "button1";
            BtnLancar.UseVisualStyleBackColor = true;
            BtnLancar.Click += BtnLancar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Pedido:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GradePedido);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 226);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Pedidos";
            // 
            // GradePedido
            // 
            GradePedido.AllowUserToAddRows = false;
            GradePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GradePedido.Columns.AddRange(new DataGridViewColumn[] { clPedidos, clApagar });
            GradePedido.Location = new Point(6, 16);
            GradePedido.Name = "GradePedido";
            GradePedido.Size = new Size(263, 204);
            GradePedido.TabIndex = 0;
            GradePedido.CellContentClick += GradePedido_CellContentClick;
            // 
            // clPedidos
            // 
            clPedidos.HeaderText = "Pedidos:";
            clPedidos.Name = "clPedidos";
            clPedidos.Width = 140;
            // 
            // clApagar
            // 
            clApagar.HeaderText = "Apagar";
            clApagar.Name = "clApagar";
            clApagar.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 327);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GradePedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtPedido;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView GradePedido;
        private Button BtnLancar;
        private DataGridViewTextBoxColumn clPedidos;
        private DataGridViewButtonColumn clApagar;
    }
}
