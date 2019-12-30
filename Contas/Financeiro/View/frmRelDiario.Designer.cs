namespace Financeiro.View
{
    partial class frmRelDiario
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
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalSaida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalEnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgSaida = new System.Windows.Forms.DataGridView();
            this.dgEntrada = new System.Windows.Forms.DataGridView();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "SALDO";
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.Location = new System.Drawing.Point(235, 13);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(28, 13);
            this.lblTotalEntrada.TabIndex = 26;
            this.lblTotalEntrada.Text = "0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "R$";
            // 
            // lblTotalSaida
            // 
            this.lblTotalSaida.AutoSize = true;
            this.lblTotalSaida.Location = new System.Drawing.Point(234, 234);
            this.lblTotalSaida.Name = "lblTotalSaida";
            this.lblTotalSaida.Size = new System.Drawing.Size(28, 13);
            this.lblTotalSaida.TabIndex = 24;
            this.lblTotalSaida.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "R$";
            // 
            // lblTotalEnt
            // 
            this.lblTotalEnt.AutoSize = true;
            this.lblTotalEnt.Location = new System.Drawing.Point(77, 85);
            this.lblTotalEnt.Name = "lblTotalEnt";
            this.lblTotalEnt.Size = new System.Drawing.Size(28, 13);
            this.lblTotalEnt.TabIndex = 22;
            this.lblTotalEnt.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "R$";
            // 
            // dgSaida
            // 
            this.dgSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgSaida.Location = new System.Drawing.Point(160, 250);
            this.dgSaida.MultiSelect = false;
            this.dgSaida.Name = "dgSaida";
            this.dgSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSaida.Size = new System.Drawing.Size(552, 188);
            this.dgSaida.TabIndex = 20;
            // 
            // dgEntrada
            // 
            this.dgEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrada.Location = new System.Drawing.Point(160, 29);
            this.dgEntrada.MultiSelect = false;
            this.dgEntrada.Name = "dgEntrada";
            this.dgEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntrada.Size = new System.Drawing.Size(552, 188);
            this.dgEntrada.TabIndex = 19;
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(13, 40);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(94, 20);
            this.dt.TabIndex = 18;
            this.dt.Value = new System.DateTime(2019, 11, 20, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Saida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lançamento diario:";
            // 
            // frmRelDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalSaida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalEnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgSaida);
            this.Controls.Add(this.dgEntrada);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRelDiario";
            this.Text = "Relatorio Diario";
            ((System.ComponentModel.ISupportInitialize)(this.dgSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalEnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgSaida;
        private System.Windows.Forms.DataGridView dgEntrada;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}