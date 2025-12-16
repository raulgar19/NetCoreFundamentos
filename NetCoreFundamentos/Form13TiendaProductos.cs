using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.lstTienda.Items.Add(producto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.SelectedItems.Count - 1;

            for (int i = numProductos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.SelectedItems.Count - 1;

            for (int i = numProductos; i >= 0; i--)
            {
                string item = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(item);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string item in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(item);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (lstAlmacen.SelectedIndex > 0)
            {
                int index = lstAlmacen.SelectedIndex;
                object item = lstAlmacen.SelectedItem;
                
                lstAlmacen.Items.RemoveAt(index);
                lstAlmacen.Items.Insert(index - 1, item);
                lstAlmacen.SelectedIndex = index - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (lstAlmacen.SelectedIndex >= 0 && lstAlmacen.SelectedIndex < lstAlmacen.Items.Count - 1)
            {
                int index = lstAlmacen.SelectedIndex;
                object item = lstAlmacen.SelectedItem;
                
                lstAlmacen.Items.RemoveAt(index);
                lstAlmacen.Items.Insert(index + 1, item);
                lstAlmacen.SelectedIndex = index + 1;
            }
        }
    }
}