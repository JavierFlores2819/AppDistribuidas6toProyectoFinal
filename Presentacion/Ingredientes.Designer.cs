
namespace Presentacion
{
    partial class Ingredientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGuardarIngrediente = new System.Windows.Forms.Button();
            this.buttonCnacelarIngrediente = new System.Windows.Forms.Button();
            this.dataGridViewIngredeintes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredeintes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Ingrediente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonGuardarIngrediente
            // 
            this.buttonGuardarIngrediente.Location = new System.Drawing.Point(86, 189);
            this.buttonGuardarIngrediente.Name = "buttonGuardarIngrediente";
            this.buttonGuardarIngrediente.Size = new System.Drawing.Size(69, 23);
            this.buttonGuardarIngrediente.TabIndex = 2;
            this.buttonGuardarIngrediente.Text = "Guardar";
            this.buttonGuardarIngrediente.UseVisualStyleBackColor = true;
            this.buttonGuardarIngrediente.Click += new System.EventHandler(this.buttonGuardarIngrediente_Click);
            // 
            // buttonCnacelarIngrediente
            // 
            this.buttonCnacelarIngrediente.Location = new System.Drawing.Point(161, 189);
            this.buttonCnacelarIngrediente.Name = "buttonCnacelarIngrediente";
            this.buttonCnacelarIngrediente.Size = new System.Drawing.Size(69, 23);
            this.buttonCnacelarIngrediente.TabIndex = 3;
            this.buttonCnacelarIngrediente.Text = "Cancelar";
            this.buttonCnacelarIngrediente.UseVisualStyleBackColor = true;
            this.buttonCnacelarIngrediente.Click += new System.EventHandler(this.buttonCnacelarIngrediente_Click);
            // 
            // dataGridViewIngredeintes
            // 
            this.dataGridViewIngredeintes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIngredeintes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIngredeintes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredeintes.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewIngredeintes.Name = "dataGridViewIngredeintes";
            this.dataGridViewIngredeintes.Size = new System.Drawing.Size(218, 132);
            this.dataGridViewIngredeintes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewIngredeintes);
            this.Controls.Add(this.buttonCnacelarIngrediente);
            this.Controls.Add(this.buttonGuardarIngrediente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ingredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.Ingredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredeintes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGuardarIngrediente;
        private System.Windows.Forms.Button buttonCnacelarIngrediente;
        private System.Windows.Forms.DataGridView dataGridViewIngredeintes;
        private System.Windows.Forms.Button button1;
    }
}