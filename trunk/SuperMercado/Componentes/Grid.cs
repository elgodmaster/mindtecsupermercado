using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MindTec.Componentes
{
    public partial class Grid :  Form
    {
        private DevAge.ComponentModel.BoundDataView bd;
        public string resultado="-1";
        public Grid(DataSet ds)
        {
            this.bd=new DevAge.ComponentModel.BoundDataView(ds.Tables[0].DefaultView);
            this.bd.mDataView.RowFilter = "";
            InitializeComponent();
            this.ShowDialog(Parent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //
            //llenando grid
            //
            bd.AllowNew = false;
            bd.AllowEdit = false;
            bd.AllowDelete = false;
            /*
            this.Datos.FixedColumns = 1;
            this.Datos.FixedRows = 1;
           
             */
            this.Datos.Columns.Clear();
           

            CellBackColorAlternate viewNormal = new CellBackColorAlternate(Color.White,Color.WhiteSmoke);

            Font fuente = new Font("Verdana", 9.0f, FontStyle.Regular);
            this.Datos.Font = fuente;

            
            this.Datos.DataSource = bd;
/*
            this.Datos.Columns[0].AutoSizeMode = SourceGrid.AutoSizeMode.MinimumSize;
            this.Datos.Columns[0].Width = 20;
            */

           
            this.Datos.SelectionMode = SourceGrid.GridSelectionMode.Row;

            //
            //llenando campos
            //
            this.Datos.AutoSizeCells();

            foreach (SourceGrid.DataGridColumn obj in this.Datos.Columns)
            {
                if (obj.Width < obj.PropertyName.Length * 10)
                    obj.Width = obj.PropertyName.Length * 10;
                try { this.cmbCampo.Items.Add(obj.PropertyName.ToString()); }
                catch { ;}
            }
            this.cmbCampo.SelectedIndex = 1;

            for (int i = 0; i < this.Datos.Columns.Count; i++)
            {
                this.Datos.Columns[i].DataCell.View = viewNormal;
                
            }
            this.Datos.Selection.SelectRow(1, true);

            this.txtFiltro.Focus();

           

        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFiltro.Text = "";
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string query = this.cmbCampo.Text + " like '%" +
                         this.txtFiltro.Text + "%'";
            this.bd.mDataView.RowFilter = query;
            this.Datos.Selection.ResetSelection(true);
            if(this.Datos.Rows.Count>0)
                this.Datos.Selection.SelectRow(1, true);



        }

        private void cmbAceptar_Click(object sender, EventArgs e)
        {
                calcular();
        }

     

        private void calcular()
        {
            try
            {
                this.resultado = ((System.Data.DataRowView)this.Datos.SelectedDataRows[0]).Row.ItemArray[0].ToString().Trim();
            }
            catch
            {
                this.resultado = "";
            }
            this.Hide();
        }
        public string salir()
        {
            this.Dispose();
            return resultado;
        }

        
        private void Datos_DoubleClick(object sender, EventArgs e)
        {
            calcular();
        }

  

        private class CellBackColorAlternate : SourceGrid.Cells.Views.Cell
        {
            public CellBackColorAlternate(Color firstColor, Color secondColor)
            {
                FirstBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(firstColor);
                SecondBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(secondColor);
            }

            private DevAge.Drawing.VisualElements.IVisualElement mFirstBackground;
            public DevAge.Drawing.VisualElements.IVisualElement FirstBackground
            {
                get { return mFirstBackground; }
                set { mFirstBackground = value; }
            }

            private DevAge.Drawing.VisualElements.IVisualElement mSecondBackground;
            public DevAge.Drawing.VisualElements.IVisualElement SecondBackground
            {
                get { return mSecondBackground; }
                set { mSecondBackground = value; }
            }

            protected override void PrepareView(SourceGrid.CellContext context)
            {
                base.PrepareView(context);

                if (Math.IEEERemainder(context.Position.Row, 2) == 0)
                    Background = FirstBackground;
                else
                    Background = SecondBackground;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.resultado = "";
            this.Hide();
        }

        private void Grid_KeyPress(object sender, KeyEventArgs e)
        {
           // System.Windows.Forms.MessageBox.Show(e.KeyValue.ToString());
            if (e.KeyData == Keys.Enter)
                calcular();
            else if(e.KeyData==Keys.Escape)
                this.Hide();
        }

    }
}