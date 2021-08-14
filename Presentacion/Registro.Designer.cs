
namespace Presentacion
{
    partial class Registro
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
            this.comboBoxSopa = new System.Windows.Forms.ComboBox();
            this.comboBoxSegundo = new System.Windows.Forms.ComboBox();
            this.comboBoxPostre = new System.Windows.Forms.ComboBox();
            this.comboBoxBebida = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelReg = new System.Windows.Forms.Button();
            this.buttonRegistra = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.buttonSopa = new System.Windows.Forms.Button();
            this.buttonPostre = new System.Windows.Forms.Button();
            this.buttonBebida = new System.Windows.Forms.Button();
            this.buttonSegund = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPostreIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxSopaIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxBebidaIngrediente = new System.Windows.Forms.TextBox();
            this.textBoxSegundoIngrediente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSopa
            // 
            this.comboBoxSopa.FormattingEnabled = true;
            this.comboBoxSopa.Location = new System.Drawing.Point(141, 33);
            this.comboBoxSopa.Name = "comboBoxSopa";
            this.comboBoxSopa.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSopa.TabIndex = 0;
            this.comboBoxSopa.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSopa_SelectionChangeCommitted);
            // 
            // comboBoxSegundo
            // 
            this.comboBoxSegundo.FormattingEnabled = true;
            this.comboBoxSegundo.Location = new System.Drawing.Point(141, 60);
            this.comboBoxSegundo.Name = "comboBoxSegundo";
            this.comboBoxSegundo.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSegundo.TabIndex = 1;
            this.comboBoxSegundo.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSegundo_SelectionChangeCommitted);
            // 
            // comboBoxPostre
            // 
            this.comboBoxPostre.FormattingEnabled = true;
            this.comboBoxPostre.Location = new System.Drawing.Point(141, 114);
            this.comboBoxPostre.Name = "comboBoxPostre";
            this.comboBoxPostre.Size = new System.Drawing.Size(157, 21);
            this.comboBoxPostre.TabIndex = 2;
            this.comboBoxPostre.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPostre_SelectionChangeCommitted);
            // 
            // comboBoxBebida
            // 
            this.comboBoxBebida.FormattingEnabled = true;
            this.comboBoxBebida.Location = new System.Drawing.Point(141, 87);
            this.comboBoxBebida.Name = "comboBoxBebida";
            this.comboBoxBebida.Size = new System.Drawing.Size(157, 21);
            this.comboBoxBebida.TabIndex = 3;
            this.comboBoxBebida.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBebida_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Postre/Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bebida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sopa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundo";
            // 
            // buttonCancelReg
            // 
            this.buttonCancelReg.Location = new System.Drawing.Point(175, 293);
            this.buttonCancelReg.Name = "buttonCancelReg";
            this.buttonCancelReg.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelReg.TabIndex = 5;
            this.buttonCancelReg.Text = "Cancelar";
            this.buttonCancelReg.UseVisualStyleBackColor = true;
            this.buttonCancelReg.Click += new System.EventHandler(this.buttonCancelReg_Click);
            // 
            // buttonRegistra
            // 
            this.buttonRegistra.Location = new System.Drawing.Point(94, 293);
            this.buttonRegistra.Name = "buttonRegistra";
            this.buttonRegistra.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistra.TabIndex = 6;
            this.buttonRegistra.Text = "Registrar";
            this.buttonRegistra.UseVisualStyleBackColor = true;
            this.buttonRegistra.Click += new System.EventHandler(this.buttonRegistra_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(141, 142);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(157, 20);
            this.dateTimePickerFecha.TabIndex = 7;
            this.dateTimePickerFecha.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // buttonSopa
            // 
            this.buttonSopa.Location = new System.Drawing.Point(304, 33);
            this.buttonSopa.Name = "buttonSopa";
            this.buttonSopa.Size = new System.Drawing.Size(31, 21);
            this.buttonSopa.TabIndex = 8;
            this.buttonSopa.Text = "...";
            this.buttonSopa.UseVisualStyleBackColor = true;
            this.buttonSopa.Click += new System.EventHandler(this.buttonSopa_Click);
            // 
            // buttonPostre
            // 
            this.buttonPostre.Location = new System.Drawing.Point(304, 114);
            this.buttonPostre.Name = "buttonPostre";
            this.buttonPostre.Size = new System.Drawing.Size(31, 21);
            this.buttonPostre.TabIndex = 9;
            this.buttonPostre.Text = "...";
            this.buttonPostre.UseVisualStyleBackColor = true;
            this.buttonPostre.Click += new System.EventHandler(this.buttonPostre_Click);
            // 
            // buttonBebida
            // 
            this.buttonBebida.Location = new System.Drawing.Point(304, 87);
            this.buttonBebida.Name = "buttonBebida";
            this.buttonBebida.Size = new System.Drawing.Size(31, 21);
            this.buttonBebida.TabIndex = 10;
            this.buttonBebida.Text = "...";
            this.buttonBebida.UseVisualStyleBackColor = true;
            this.buttonBebida.Click += new System.EventHandler(this.buttonBebida_Click);
            // 
            // buttonSegund
            // 
            this.buttonSegund.Location = new System.Drawing.Point(304, 60);
            this.buttonSegund.Name = "buttonSegund";
            this.buttonSegund.Size = new System.Drawing.Size(31, 21);
            this.buttonSegund.TabIndex = 11;
            this.buttonSegund.Text = "...";
            this.buttonSegund.UseVisualStyleBackColor = true;
            this.buttonSegund.Click += new System.EventHandler(this.buttonSegund_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPostreIngrediente);
            this.groupBox2.Controls.Add(this.textBoxSopaIngrediente);
            this.groupBox2.Controls.Add(this.textBoxBebidaIngrediente);
            this.groupBox2.Controls.Add(this.textBoxSegundoIngrediente);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // textBoxPostreIngrediente
            // 
            this.textBoxPostreIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPostreIngrediente.Location = new System.Drawing.Point(6, 91);
            this.textBoxPostreIngrediente.Multiline = true;
            this.textBoxPostreIngrediente.Name = "textBoxPostreIngrediente";
            this.textBoxPostreIngrediente.ReadOnly = true;
            this.textBoxPostreIngrediente.Size = new System.Drawing.Size(319, 18);
            this.textBoxPostreIngrediente.TabIndex = 20;
            // 
            // textBoxSopaIngrediente
            // 
            this.textBoxSopaIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSopaIngrediente.Location = new System.Drawing.Point(6, 19);
            this.textBoxSopaIngrediente.Multiline = true;
            this.textBoxSopaIngrediente.Name = "textBoxSopaIngrediente";
            this.textBoxSopaIngrediente.ReadOnly = true;
            this.textBoxSopaIngrediente.Size = new System.Drawing.Size(319, 18);
            this.textBoxSopaIngrediente.TabIndex = 17;
            // 
            // textBoxBebidaIngrediente
            // 
            this.textBoxBebidaIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBebidaIngrediente.Location = new System.Drawing.Point(6, 67);
            this.textBoxBebidaIngrediente.Multiline = true;
            this.textBoxBebidaIngrediente.Name = "textBoxBebidaIngrediente";
            this.textBoxBebidaIngrediente.ReadOnly = true;
            this.textBoxBebidaIngrediente.Size = new System.Drawing.Size(319, 18);
            this.textBoxBebidaIngrediente.TabIndex = 19;
            // 
            // textBoxSegundoIngrediente
            // 
            this.textBoxSegundoIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSegundoIngrediente.Location = new System.Drawing.Point(6, 43);
            this.textBoxSegundoIngrediente.Multiline = true;
            this.textBoxSegundoIngrediente.Name = "textBoxSegundoIngrediente";
            this.textBoxSegundoIngrediente.ReadOnly = true;
            this.textBoxSegundoIngrediente.Size = new System.Drawing.Size(319, 18);
            this.textBoxSegundoIngrediente.TabIndex = 18;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSegund);
            this.Controls.Add(this.buttonBebida);
            this.Controls.Add(this.buttonPostre);
            this.Controls.Add(this.buttonSopa);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.buttonRegistra);
            this.Controls.Add(this.buttonCancelReg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxBebida);
            this.Controls.Add(this.comboBoxPostre);
            this.Controls.Add(this.comboBoxSegundo);
            this.Controls.Add(this.comboBoxSopa);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelReg;
        private System.Windows.Forms.Button buttonRegistra;
        private System.Windows.Forms.Button buttonSopa;
        private System.Windows.Forms.Button buttonPostre;
        private System.Windows.Forms.Button buttonBebida;
        private System.Windows.Forms.Button buttonSegund;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPostreIngrediente;
        private System.Windows.Forms.TextBox textBoxSopaIngrediente;
        private System.Windows.Forms.TextBox textBoxBebidaIngrediente;
        private System.Windows.Forms.TextBox textBoxSegundoIngrediente;
        public System.Windows.Forms.ComboBox comboBoxSopa;
        public System.Windows.Forms.ComboBox comboBoxSegundo;
        public System.Windows.Forms.ComboBox comboBoxPostre;
        public System.Windows.Forms.ComboBox comboBoxBebida;
        public System.Windows.Forms.DateTimePicker dateTimePickerFecha;
    }
}