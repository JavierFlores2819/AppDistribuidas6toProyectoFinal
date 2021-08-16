
namespace Presentacion
{
    partial class Platos
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
            this.labelPlato = new System.Windows.Forms.Label();
            this.textBoxNombrePlato = new System.Windows.Forms.TextBox();
            this.imgPlato = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuarPla = new System.Windows.Forms.Button();
            this.buttonCancelP = new System.Windows.Forms.Button();
            this.buttonIngredientes = new System.Windows.Forms.Button();
            this.checkedListBoxIngrediente = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlato
            // 
            this.labelPlato.AutoSize = true;
            this.labelPlato.Location = new System.Drawing.Point(4, 5);
            this.labelPlato.Name = "labelPlato";
            this.labelPlato.Size = new System.Drawing.Size(33, 12);
            this.labelPlato.TabIndex = 0;
            this.labelPlato.Text = "Plato";
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(6, 21);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(181, 20);
            this.textBoxNombrePlato.TabIndex = 1;
            this.textBoxNombrePlato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombrePlato_KeyPress);
            // 
            // imgPlato
            // 
            this.imgPlato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPlato.Location = new System.Drawing.Point(48, 47);
            this.imgPlato.Name = "imgPlato";
            this.imgPlato.Size = new System.Drawing.Size(97, 89);
            this.imgPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlato.TabIndex = 2;
            this.imgPlato.TabStop = false;
            this.imgPlato.Click += new System.EventHandler(this.imgPlato_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingredientes";
            // 
            // buttonGuarPla
            // 
            this.buttonGuarPla.Location = new System.Drawing.Point(13, 153);
            this.buttonGuarPla.Name = "buttonGuarPla";
            this.buttonGuarPla.Size = new System.Drawing.Size(78, 21);
            this.buttonGuarPla.TabIndex = 5;
            this.buttonGuarPla.Text = "Guardar";
            this.buttonGuarPla.UseVisualStyleBackColor = true;
            this.buttonGuarPla.Click += new System.EventHandler(this.buttonGuarPla_Click);
            // 
            // buttonCancelP
            // 
            this.buttonCancelP.Location = new System.Drawing.Point(97, 153);
            this.buttonCancelP.Name = "buttonCancelP";
            this.buttonCancelP.Size = new System.Drawing.Size(78, 21);
            this.buttonCancelP.TabIndex = 6;
            this.buttonCancelP.Text = "Cancelar";
            this.buttonCancelP.UseVisualStyleBackColor = true;
            this.buttonCancelP.Click += new System.EventHandler(this.buttonCancelP_Click);
            // 
            // buttonIngredientes
            // 
            this.buttonIngredientes.Location = new System.Drawing.Point(354, 21);
            this.buttonIngredientes.Name = "buttonIngredientes";
            this.buttonIngredientes.Size = new System.Drawing.Size(24, 20);
            this.buttonIngredientes.TabIndex = 7;
            this.buttonIngredientes.Text = "...";
            this.buttonIngredientes.UseVisualStyleBackColor = true;
            this.buttonIngredientes.Click += new System.EventHandler(this.buttonIngredientes_Click);
            // 
            // checkedListBoxIngrediente
            // 
            this.checkedListBoxIngrediente.FormattingEnabled = true;
            this.checkedListBoxIngrediente.Location = new System.Drawing.Point(193, 21);
            this.checkedListBoxIngrediente.Name = "checkedListBoxIngrediente";
            this.checkedListBoxIngrediente.Size = new System.Drawing.Size(155, 169);
            this.checkedListBoxIngrediente.TabIndex = 8;
            // 
            // Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 203);
            this.Controls.Add(this.checkedListBoxIngrediente);
            this.Controls.Add(this.buttonIngredientes);
            this.Controls.Add(this.buttonCancelP);
            this.Controls.Add(this.buttonGuarPla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgPlato);
            this.Controls.Add(this.textBoxNombrePlato);
            this.Controls.Add(this.labelPlato);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Platos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLATOS";
            this.Load += new System.EventHandler(this.Platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombrePlato;
        private System.Windows.Forms.PictureBox imgPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuarPla;
        private System.Windows.Forms.Button buttonCancelP;
        private System.Windows.Forms.Button buttonIngredientes;
        private System.Windows.Forms.CheckedListBox checkedListBoxIngrediente;
        public System.Windows.Forms.Label labelPlato;
    }
}