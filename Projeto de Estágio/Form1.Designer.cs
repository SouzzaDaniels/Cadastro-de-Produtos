namespace Projeto_de_Estágio
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
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.nomeProduto = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.descricaoP = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.valorP = new System.Windows.Forms.Label();
            this.textBoxDisponivel = new System.Windows.Forms.TextBox();
            this.disponivel = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToOrderColumns = true;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(381, 34);
            this.dgProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.RowHeadersWidth = 62;
            this.dgProduto.RowTemplate.Height = 25;
            this.dgProduto.Size = new System.Drawing.Size(726, 471);
            this.dgProduto.TabIndex = 0;
            this.dgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellContentClick);
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSize = true;
            this.nomeProduto.Location = new System.Drawing.Point(13, 34);
            this.nomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(61, 25);
            this.nomeProduto.TabIndex = 1;
            this.nomeProduto.Text = "Nome";
            this.nomeProduto.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 64);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(307, 31);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(13, 140);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(307, 31);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // descricaoP
            // 
            this.descricaoP.AutoSize = true;
            this.descricaoP.Location = new System.Drawing.Point(13, 110);
            this.descricaoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descricaoP.Name = "descricaoP";
            this.descricaoP.Size = new System.Drawing.Size(88, 25);
            this.descricaoP.TabIndex = 3;
            this.descricaoP.Text = "Descrição";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(13, 228);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(307, 31);
            this.textBoxValor.TabIndex = 6;
            // 
            // valorP
            // 
            this.valorP.AutoSize = true;
            this.valorP.Location = new System.Drawing.Point(13, 198);
            this.valorP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorP.Name = "valorP";
            this.valorP.Size = new System.Drawing.Size(52, 25);
            this.valorP.TabIndex = 5;
            this.valorP.Text = "Valor";
            // 
            // textBoxDisponivel
            // 
            this.textBoxDisponivel.Location = new System.Drawing.Point(13, 301);
            this.textBoxDisponivel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDisponivel.Name = "textBoxDisponivel";
            this.textBoxDisponivel.Size = new System.Drawing.Size(307, 31);
            this.textBoxDisponivel.TabIndex = 8;
            // 
            // disponivel
            // 
            this.disponivel.AutoSize = true;
            this.disponivel.Location = new System.Drawing.Point(13, 271);
            this.disponivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disponivel.Name = "disponivel";
            this.disponivel.Size = new System.Drawing.Size(196, 25);
            this.disponivel.TabIndex = 7;
            this.disponivel.Text = "Disponível para venda?";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(213, 342);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 38);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 524);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBoxDisponivel);
            this.Controls.Add(this.disponivel);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.valorP);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.descricaoP);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.dgProduto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgProduto;
        private Label nomeProduto;
        private TextBox textBoxNome;
        private TextBox textBoxDescricao;
        private Label descricaoP;
        private TextBox textBoxValor;
        private Label valorP;
        private TextBox textBoxDisponivel;
        private Label disponivel;
        private Button btnSalvar;
    }
}