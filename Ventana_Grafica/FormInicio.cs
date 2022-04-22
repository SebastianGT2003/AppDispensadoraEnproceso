using Dispensador;

namespace Ventana_Grafica
{
    public partial class FormInicio : Form
    {
        public List<Producto> Productos { get; set; }
        public Dispensadora productos { get; set; }
        public FormInicio()
        {
           

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tslAgregar_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tblInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        public void lvwListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwListaProductos.SelectedItems.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
                


        }
        public void ActualizarProductos()
        {
        
            FormAgregar form=new FormAgregar();
   

            lvwListaProductos.Items.Clear();
       
            lvwListaProductos.CheckBoxes = true;
            ListViewItem items= new ListViewItem();
            items = lvwListaProductos.Items.Add(form.producto.Codigo);
            items.SubItems.Add(form.producto.Nombre);
            items.SubItems.Add(form.producto.Categoria);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormAgregar();
            Formulario.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormModificar();
            Formulario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormEliminar();
            Formulario.Show();
        }

        private void btnVender_Click_1(object sender, EventArgs e)
        {
            Form Formulario = new FormVender();
            Formulario.Show();
        }
    }
}