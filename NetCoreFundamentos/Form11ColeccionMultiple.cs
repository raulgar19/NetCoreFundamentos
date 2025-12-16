using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numElementos = this.lstElementos.SelectedItems.Count -1;

            for (int i = numElementos; i >= 0; i--) 
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";

            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }

            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ", ";
            }

            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');

        }
    }
}
