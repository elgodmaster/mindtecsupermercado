using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MindTec.Componentes
{
    partial class Grid 
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAceptar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.Datos = new SourceGrid.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAceptar
            // 
            this.cmbAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbAceptar.Location = new System.Drawing.Point(423, 352);
            this.cmbAceptar.Name = "cmbAceptar";
            this.cmbAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmbAceptar.TabIndex = 9;
            this.cmbAceptar.Text = "Enviar";
            this.cmbAceptar.UseVisualStyleBackColor = false;
            this.cmbAceptar.Click += new System.EventHandler(this.cmbAceptar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(219, 353);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(183, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(70, 353);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(121, 21);
            this.cmbCampo.TabIndex = 7;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblfiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblfiltro.Location = new System.Drawing.Point(10, 357);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(54, 13);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtrar Por:";
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.BackColor = System.Drawing.Color.Transparent;
            this.Datos.DeleteQuestionMessage = "Are you sure to delete all the selected rows?";
            this.Datos.FixedRows = 1;
            this.Datos.Location = new System.Drawing.Point(14, 33);
            this.Datos.MaximumSize = new System.Drawing.Size(485, 300);
            this.Datos.MinimumSize = new System.Drawing.Size(100, 100);
            this.Datos.Name = "Datos";
            this.Datos.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.Datos.Size = new System.Drawing.Size(485, 300);
            this.Datos.TabIndex = 5;
            this.Datos.TabStop = true;
            this.Datos.ToolTipText = "";
            this.Datos.DoubleClick += new System.EventHandler(this.Datos_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(497, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 382);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAceptar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.Datos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmbAceptar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label lblfiltro;
        private SourceGrid.DataGrid Datos;
        private Label label1;

    }
}