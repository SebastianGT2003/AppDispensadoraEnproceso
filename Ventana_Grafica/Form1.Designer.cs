namespace Ventana_Grafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblInicio = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabSalir = new System.Windows.Forms.TabPage();
            this.lvwBotones = new System.Windows.Forms.ListView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.tabVender = new System.Windows.Forms.TabPage();
            this.lvwListaProductos = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.tblInicio.SuspendLayout();
            this.tabOpciones.SuspendLayout();
            this.tabVender.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // tblInicio
            // 
            this.tblInicio.ColumnCount = 1;
            this.tblInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInicio.Controls.Add(this.label1, 0, 0);
            this.tblInicio.Controls.Add(this.tabOpciones, 0, 1);
            this.tblInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInicio.Location = new System.Drawing.Point(0, 0);
            this.tblInicio.Name = "tblInicio";
            this.tblInicio.RowCount = 2;
            this.tblInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInicio.Size = new System.Drawing.Size(800, 450);
            this.tblInicio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispensadora de Sara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabVender);
            this.tabOpciones.Controls.Add(this.tabSalir);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOpciones.Location = new System.Drawing.Point(3, 228);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(794, 219);
            this.tabOpciones.TabIndex = 3;
            // 
            // tabSalir
            // 
            this.tabSalir.Location = new System.Drawing.Point(4, 29);
            this.tabSalir.Name = "tabSalir";
            this.tabSalir.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalir.Size = new System.Drawing.Size(786, 186);
            this.tabSalir.TabIndex = 4;
            this.tabSalir.Text = "Salir";
            this.tabSalir.UseVisualStyleBackColor = true;
            // 
            // lvwBotones
            // 
            this.lvwBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwBotones.Location = new System.Drawing.Point(3, 3);
            this.lvwBotones.Name = "lvwBotones";
            this.lvwBotones.Size = new System.Drawing.Size(780, 52);
            this.lvwBotones.TabIndex = 5;
            this.lvwBotones.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(598, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(511, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(419, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(686, 3);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(94, 29);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // tabVender
            // 
            this.tabVender.Controls.Add(this.lvwListaProductos);
            this.tabVender.Controls.Add(this.btnVender);
            this.tabVender.Controls.Add(this.btnAgregar);
            this.tabVender.Controls.Add(this.btnModificar);
            this.tabVender.Controls.Add(this.btnEliminar);
            this.tabVender.Controls.Add(this.lvwBotones);
            this.tabVender.Location = new System.Drawing.Point(4, 29);
            this.tabVender.Name = "tabVender";
            this.tabVender.Padding = new System.Windows.Forms.Padding(3);
            this.tabVender.Size = new System.Drawing.Size(786, 186);
            this.tabVender.TabIndex = 3;
            this.tabVender.Text = "Productos";
            this.tabVender.UseVisualStyleBackColor = true;
            // 
            // lvwListaProductos
            // 
            this.lvwListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwListaProductos.Location = new System.Drawing.Point(3, 55);
            this.lvwListaProductos.Name = "lvwListaProductos";
            this.lvwListaProductos.Size = new System.Drawing.Size(780, 128);
            this.lvwListaProductos.TabIndex = 7;
            this.lvwListaProductos.UseCompatibleStateImageBehavior = false;
            this.lvwListaProductos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.tblInicio.ResumeLayout(false);
            this.tblInicio.PerformLayout();
            this.tabOpciones.ResumeLayout(false);
            this.tabVender.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ErrorProvider erpError;
        private ToolTip toolTip1;
        private TableLayoutPanel tblInicio;
        private Label label1;
        private TabControl tabOpciones;
        private TabPage tabSalir;
        private TabPage tabVender;
        private ListView lvwListaProductos;
        private Button btnVender;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView lvwBotones;
    }
}