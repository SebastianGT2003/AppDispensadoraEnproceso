using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dispensador;

namespace Ventana_Grafica
{
    public partial class FormAgregar : Form
    { 
        FormInicio FormInicio { get; set; }
        public Producto producto { get; set; }
        public List<Producto> Productos { get; set; }
        public FormAgregar()

        {
            this.Productos = new List<Producto>();
            Producto producto = new Producto();
            InitializeComponent();



        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            this.producto= new Producto();
            producto.Nombre= txtNombre.Text;
            producto.Codigo= txtCodigo.Text;
            producto.Valor = int.Parse(txtValor.Text);
            producto.Cantidad = int.Parse(txtCantidad.Text);
            producto.Categoria= txtCategoria.Text;
            

            FormInicio form = new FormInicio();
            form.ActualizarProductos();
            
            /*Productos.Add(producto);*/

            




         


        }
        
    }
}
