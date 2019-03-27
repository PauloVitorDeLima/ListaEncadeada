namespace MusicPlayer
{
    partial class Form1
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
            this.RichTxtBxName = new System.Windows.Forms.RichTextBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAddFirst = new System.Windows.Forms.Button();
            this.BtRemoveLast = new System.Windows.Forms.Button();
            this.BtRemoveFirst = new System.Windows.Forms.Button();
            this.BtAddLast = new System.Windows.Forms.Button();
            this.NumericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTxtBxTamanho = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTxtBxSalario = new System.Windows.Forms.MaskedTextBox();
            this.CmbBxSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTxtBxName
            // 
            this.RichTxtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.RichTxtBxName.Location = new System.Drawing.Point(449, 12);
            this.RichTxtBxName.Name = "RichTxtBxName";
            this.RichTxtBxName.Size = new System.Drawing.Size(421, 426);
            this.RichTxtBxName.TabIndex = 0;
            this.RichTxtBxName.Text = "";
            // 
            // TxtBxName
            // 
            this.TxtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtBxName.Location = new System.Drawing.Point(138, 15);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(180, 31);
            this.TxtBxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // BtAddFirst
            // 
            this.BtAddFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BtAddFirst.Location = new System.Drawing.Point(47, 289);
            this.BtAddFirst.Name = "BtAddFirst";
            this.BtAddFirst.Size = new System.Drawing.Size(175, 35);
            this.BtAddFirst.TabIndex = 3;
            this.BtAddFirst.Text = "Add Primeiro";
            this.BtAddFirst.UseVisualStyleBackColor = true;
            this.BtAddFirst.Click += new System.EventHandler(this.BtAddFirst_Click);
            // 
            // BtRemoveLast
            // 
            this.BtRemoveLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BtRemoveLast.Location = new System.Drawing.Point(268, 375);
            this.BtRemoveLast.Name = "BtRemoveLast";
            this.BtRemoveLast.Size = new System.Drawing.Size(159, 35);
            this.BtRemoveLast.TabIndex = 4;
            this.BtRemoveLast.Text = "Remove Ultimo";
            this.BtRemoveLast.UseVisualStyleBackColor = true;
            this.BtRemoveLast.Click += new System.EventHandler(this.BtRemoveLast_Click);
            // 
            // BtRemoveFirst
            // 
            this.BtRemoveFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BtRemoveFirst.Location = new System.Drawing.Point(47, 375);
            this.BtRemoveFirst.Name = "BtRemoveFirst";
            this.BtRemoveFirst.Size = new System.Drawing.Size(175, 35);
            this.BtRemoveFirst.TabIndex = 5;
            this.BtRemoveFirst.Text = "Remove Primeiro";
            this.BtRemoveFirst.UseVisualStyleBackColor = true;
            this.BtRemoveFirst.Click += new System.EventHandler(this.BtRemoveFirst_Click);
            // 
            // BtAddLast
            // 
            this.BtAddLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BtAddLast.Location = new System.Drawing.Point(268, 289);
            this.BtAddLast.Name = "BtAddLast";
            this.BtAddLast.Size = new System.Drawing.Size(159, 35);
            this.BtAddLast.TabIndex = 6;
            this.BtAddLast.Text = "Add ultimo";
            this.BtAddLast.UseVisualStyleBackColor = true;
            this.BtAddLast.Click += new System.EventHandler(this.BtAddLast_Click);
            // 
            // NumericUpDownIdade
            // 
            this.NumericUpDownIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NumericUpDownIdade.Location = new System.Drawing.Point(138, 61);
            this.NumericUpDownIdade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownIdade.Name = "NumericUpDownIdade";
            this.NumericUpDownIdade.Size = new System.Drawing.Size(180, 26);
            this.NumericUpDownIdade.TabIndex = 7;
            this.NumericUpDownIdade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(43, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Idade";
            // 
            // MskTxtBxTamanho
            // 
            this.MskTxtBxTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MskTxtBxTamanho.Location = new System.Drawing.Point(138, 103);
            this.MskTxtBxTamanho.Name = "MskTxtBxTamanho";
            this.MskTxtBxTamanho.Size = new System.Drawing.Size(180, 26);
            this.MskTxtBxTamanho.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(46, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(46, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Salário";
            // 
            // MskTxtBxSalario
            // 
            this.MskTxtBxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MskTxtBxSalario.Location = new System.Drawing.Point(138, 148);
            this.MskTxtBxSalario.Name = "MskTxtBxSalario";
            this.MskTxtBxSalario.Size = new System.Drawing.Size(180, 26);
            this.MskTxtBxSalario.TabIndex = 11;
            // 
            // CmbBxSexo
            // 
            this.CmbBxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CmbBxSexo.FormattingEnabled = true;
            this.CmbBxSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino"});
            this.CmbBxSexo.Location = new System.Drawing.Point(138, 187);
            this.CmbBxSexo.Name = "CmbBxSexo";
            this.CmbBxSexo.Size = new System.Drawing.Size(180, 28);
            this.CmbBxSexo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(46, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBxSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskTxtBxSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MskTxtBxTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericUpDownIdade);
            this.Controls.Add(this.BtAddLast);
            this.Controls.Add(this.BtRemoveFirst);
            this.Controls.Add(this.BtRemoveLast);
            this.Controls.Add(this.BtAddFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.RichTxtBxName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxtBxName;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtAddFirst;
        private System.Windows.Forms.Button BtRemoveLast;
        private System.Windows.Forms.Button BtRemoveFirst;
        private System.Windows.Forms.Button BtAddLast;
        private System.Windows.Forms.NumericUpDown NumericUpDownIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTxtBxTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTxtBxSalario;
        private System.Windows.Forms.ComboBox CmbBxSexo;
        private System.Windows.Forms.Label label5;
    }
}

