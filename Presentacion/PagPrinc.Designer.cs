
namespace Presentacion
{
    partial class PagPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.buttonRegisMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(675, 353);
            this.dataGridViewMenu.TabIndex = 0;
            // 
            // buttonRegisMenu
            // 
            this.buttonRegisMenu.Location = new System.Drawing.Point(588, 12);
            this.buttonRegisMenu.Name = "buttonRegisMenu";
            this.buttonRegisMenu.Size = new System.Drawing.Size(99, 23);
            this.buttonRegisMenu.TabIndex = 1;
            this.buttonRegisMenu.Text = "Menu del día";
            this.buttonRegisMenu.UseVisualStyleBackColor = true;
            this.buttonRegisMenu.Click += new System.EventHandler(this.buttonRegisMenu_Click);
            // 
            // PagPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 403);
            this.Controls.Add(this.buttonRegisMenu);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "PagPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CENTRO DE COMIDA";
            this.Load += new System.EventHandler(this.PagPrinc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button buttonRegisMenu;
    }
}

