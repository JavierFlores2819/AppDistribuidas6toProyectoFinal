
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
            this.pictureBoxPlato = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxIngredientes = new System.Windows.Forms.CheckedListBox();
            this.buttonGuarPla = new System.Windows.Forms.Button();
            this.buttonCancelP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlato
            // 
            this.labelPlato.AutoSize = true;
            this.labelPlato.Location = new System.Drawing.Point(12, 14);
            this.labelPlato.Name = "labelPlato";
            this.labelPlato.Size = new System.Drawing.Size(31, 13);
            this.labelPlato.TabIndex = 0;
            this.labelPlato.Text = "Plato";
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(12, 30);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombrePlato.TabIndex = 1;
            // 
            // pictureBoxPlato
            // 
            this.pictureBoxPlato.Location = new System.Drawing.Point(46, 56);
            this.pictureBoxPlato.Name = "pictureBoxPlato";
            this.pictureBoxPlato.Size = new System.Drawing.Size(100, 90);
            this.pictureBoxPlato.TabIndex = 2;
            this.pictureBoxPlato.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingredientes";
            // 
            // checkedListBoxIngredientes
            // 
            this.checkedListBoxIngredientes.FormattingEnabled = true;
            this.checkedListBoxIngredientes.Location = new System.Drawing.Point(12, 175);
            this.checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            this.checkedListBoxIngredientes.Size = new System.Drawing.Size(171, 124);
            this.checkedListBoxIngredientes.TabIndex = 4;
            // 
            // buttonGuarPla
            // 
            this.buttonGuarPla.Location = new System.Drawing.Point(12, 305);
            this.buttonGuarPla.Name = "buttonGuarPla";
            this.buttonGuarPla.Size = new System.Drawing.Size(75, 23);
            this.buttonGuarPla.TabIndex = 5;
            this.buttonGuarPla.Text = "Guardar";
            this.buttonGuarPla.UseVisualStyleBackColor = true;
            // 
            // buttonCancelP
            // 
            this.buttonCancelP.Location = new System.Drawing.Point(93, 305);
            this.buttonCancelP.Name = "buttonCancelP";
            this.buttonCancelP.Size = new System.Drawing.Size(68, 23);
            this.buttonCancelP.TabIndex = 6;
            this.buttonCancelP.Text = "Cancelar";
            this.buttonCancelP.UseVisualStyleBackColor = true;
            // 
            // Platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 347);
            this.Controls.Add(this.buttonCancelP);
            this.Controls.Add(this.buttonGuarPla);
            this.Controls.Add(this.checkedListBoxIngredientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPlato);
            this.Controls.Add(this.textBoxNombrePlato);
            this.Controls.Add(this.labelPlato);
            this.Name = "Platos";
            this.Text = "Platos";
            this.Load += new System.EventHandler(this.Platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlato;
        private System.Windows.Forms.TextBox textBoxNombrePlato;
        private System.Windows.Forms.PictureBox pictureBoxPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxIngredientes;
        private System.Windows.Forms.Button buttonGuarPla;
        private System.Windows.Forms.Button buttonCancelP;
    }
}