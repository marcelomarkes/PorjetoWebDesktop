namespace AdmVendas
{
    partial class frmVeiculo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ckbFreio = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ckbAr = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAirBag = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDirecao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNPorta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnoCarro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnoFab = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbStiPesquisa = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtValorVenda);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtValorCompra);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ckbFreio);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ckbAr);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbSituacao);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbAirBag);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbDirecao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbNPorta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbCor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAnoCarro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAnoFab);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciar Veículo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(418, 462);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(55, 23);
            this.txtCodigo.TabIndex = 34;
            this.txtCodigo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(245, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 35);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(114, 456);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(132, 416);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(386, 23);
            this.txtObservacao.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Observação";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(397, 379);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(121, 23);
            this.txtValorVenda.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(277, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Valor da Vendas";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(132, 379);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(121, 23);
            this.txtValorCompra.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Valor da Compra";
            // 
            // ckbFreio
            // 
            this.ckbFreio.AutoSize = true;
            this.ckbFreio.Location = new System.Drawing.Point(328, 345);
            this.ckbFreio.Name = "ckbFreio";
            this.ckbFreio.Size = new System.Drawing.Size(50, 21);
            this.ckbFreio.TabIndex = 25;
            this.ckbFreio.Text = "Sim";
            this.ckbFreio.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Freio ABS";
            // 
            // ckbAr
            // 
            this.ckbAr.AutoSize = true;
            this.ckbAr.Location = new System.Drawing.Point(110, 346);
            this.ckbAr.Name = "ckbAr";
            this.ckbAr.Size = new System.Drawing.Size(50, 21);
            this.ckbAr.TabIndex = 23;
            this.ckbAr.Text = "Sim";
            this.ckbAr.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ar";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Vendido"});
            this.cmbSituacao.Location = new System.Drawing.Point(352, 295);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(166, 24);
            this.cmbSituacao.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Situação";
            // 
            // cmbAirBag
            // 
            this.cmbAirBag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAirBag.FormattingEnabled = true;
            this.cmbAirBag.Items.AddRange(new object[] {
            "0",
            "2",
            "4",
            "6",
            "8"});
            this.cmbAirBag.Location = new System.Drawing.Point(78, 295);
            this.cmbAirBag.Name = "cmbAirBag";
            this.cmbAirBag.Size = new System.Drawing.Size(175, 24);
            this.cmbAirBag.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Airbag";
            // 
            // cmbDirecao
            // 
            this.cmbDirecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirecao.FormattingEnabled = true;
            this.cmbDirecao.Items.AddRange(new object[] {
            "Manual",
            "Hidraulica",
            "Eletrica"});
            this.cmbDirecao.Location = new System.Drawing.Point(352, 249);
            this.cmbDirecao.Name = "cmbDirecao";
            this.cmbDirecao.Size = new System.Drawing.Size(166, 24);
            this.cmbDirecao.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Direção";
            // 
            // cmbNPorta
            // 
            this.cmbNPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPorta.FormattingEnabled = true;
            this.cmbNPorta.Items.AddRange(new object[] {
            "2",
            "4"});
            this.cmbNPorta.Location = new System.Drawing.Point(78, 249);
            this.cmbNPorta.Name = "cmbNPorta";
            this.cmbNPorta.Size = new System.Drawing.Size(175, 24);
            this.cmbNPorta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "N. Porta";
            // 
            // cmbCor
            // 
            this.cmbCor.DisplayMember = "nome_cor";
            this.cmbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Location = new System.Drawing.Point(352, 197);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(166, 24);
            this.cmbCor.TabIndex = 13;
            this.cmbCor.ValueMember = "id_cor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cor";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(78, 198);
            this.txtKM.Mask = "0000";
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(100, 23);
            this.txtKM.TabIndex = 11;
            this.txtKM.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "KM";
            // 
            // txtAnoCarro
            // 
            this.txtAnoCarro.Location = new System.Drawing.Point(352, 141);
            this.txtAnoCarro.Mask = "0000";
            this.txtAnoCarro.Name = "txtAnoCarro";
            this.txtAnoCarro.Size = new System.Drawing.Size(100, 23);
            this.txtAnoCarro.TabIndex = 9;
            this.txtAnoCarro.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ano Carro";
            // 
            // txtAnoFab
            // 
            this.txtAnoFab.Location = new System.Drawing.Point(78, 141);
            this.txtAnoFab.Mask = "0000";
            this.txtAnoFab.Name = "txtAnoFab";
            this.txtAnoFab.Size = new System.Drawing.Size(100, 23);
            this.txtAnoFab.TabIndex = 7;
            this.txtAnoFab.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano Fab.";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DisplayMember = "nome_modelo";
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(352, 85);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(166, 24);
            this.cmbModelo.TabIndex = 5;
            this.cmbModelo.ValueMember = "id_modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DisplayMember = "nome_marca";
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(78, 85);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(175, 24);
            this.cmbMarca.TabIndex = 3;
            this.cmbMarca.ValueMember = "id_marca";
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(78, 31);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 23);
            this.txtPlaca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.cmbStiPesquisa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(584, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Veículo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Navy;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(165, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 42);
            this.btnPesquisar.TabIndex = 37;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbStiPesquisa
            // 
            this.cmbStiPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStiPesquisa.FormattingEnabled = true;
            this.cmbStiPesquisa.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Vendido"});
            this.cmbStiPesquisa.Location = new System.Drawing.Point(118, 53);
            this.cmbStiPesquisa.Name = "cmbStiPesquisa";
            this.cmbStiPesquisa.Size = new System.Drawing.Size(231, 24);
            this.cmbStiPesquisa.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Situação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVeiculos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(584, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 326);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado da Veículo";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(6, 24);
            this.dgvVeiculos.MultiSelect = false;
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(398, 296);
            this.dgvVeiculos.TabIndex = 1;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellClick);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVeiculo";
            this.Text = "Veículo";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDirecao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNPorta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtKM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtAnoCarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtAnoFab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ckbFreio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbAr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAirBag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.ComboBox cmbStiPesquisa;
    }
}