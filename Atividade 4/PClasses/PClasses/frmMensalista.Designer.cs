﻿namespace PClasses
{
    partial class frmMensalista
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
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbtnNao);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Location = new System.Drawing.Point(552, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(31, 108);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(63, 24);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(31, 65);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(61, 24);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(289, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 26);
            this.txtNome.TabIndex = 20;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(289, 163);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(215, 26);
            this.txtSalario.TabIndex = 19;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(289, 210);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(215, 26);
            this.txtData.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(289, 76);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(215, 26);
            this.txtMatricula.TabIndex = 17;
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(289, 317);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar2.TabIndex = 16;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            this.btnInstanciar2.Click += new System.EventHandler(this.BtnInstanciar2_Click);
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(52, 317);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar.TabIndex = 15;
            this.btnInstanciar.Text = "Instanciar Mensalista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(48, 216);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(195, 20);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data Entrada na Empresa";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(48, 169);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(113, 20);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salário Mensal";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(48, 128);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(48, 82);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matrícula";
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
    }
}