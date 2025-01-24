namespace GestorInventario
{
    partial class Ingresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresar));
            this.ID = new System.Windows.Forms.TextBox();
            this.Producto = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Detalles = new System.Windows.Forms.TextBox();
            this.IngresarID = new System.Windows.Forms.RichTextBox();
            this.IngresarProducto = new System.Windows.Forms.RichTextBox();
            this.IngresarCantidad = new System.Windows.Forms.RichTextBox();
            this.IngresarPrecio = new System.Windows.Forms.RichTextBox();
            this.IngresarDetalles = new System.Windows.Forms.RichTextBox();
            this.Ingre = new System.Windows.Forms.Button();
            this.Cance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(69, 50);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(39, 22);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(69, 115);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(69, 22);
            this.Producto.TabIndex = 1;
            this.Producto.Text = "Producto:";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(69, 185);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(69, 22);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.Text = "Cantidad:";
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(69, 250);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(57, 22);
            this.Precio.TabIndex = 3;
            this.Precio.Text = "Precio:";
            // 
            // Detalles
            // 
            this.Detalles.Location = new System.Drawing.Point(69, 317);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(69, 22);
            this.Detalles.TabIndex = 4;
            this.Detalles.Text = "Detalles:";
            // 
            // IngresarID
            // 
            this.IngresarID.Location = new System.Drawing.Point(209, 38);
            this.IngresarID.Name = "IngresarID";
            this.IngresarID.Size = new System.Drawing.Size(187, 34);
            this.IngresarID.TabIndex = 5;
            this.IngresarID.Text = "";
            // 
            // IngresarProducto
            // 
            this.IngresarProducto.Location = new System.Drawing.Point(209, 102);
            this.IngresarProducto.Name = "IngresarProducto";
            this.IngresarProducto.Size = new System.Drawing.Size(190, 35);
            this.IngresarProducto.TabIndex = 6;
            this.IngresarProducto.Text = "";
            // 
            // IngresarCantidad
            // 
            this.IngresarCantidad.Location = new System.Drawing.Point(209, 168);
            this.IngresarCantidad.Name = "IngresarCantidad";
            this.IngresarCantidad.Size = new System.Drawing.Size(187, 39);
            this.IngresarCantidad.TabIndex = 7;
            this.IngresarCantidad.Text = "";
            // 
            // IngresarPrecio
            // 
            this.IngresarPrecio.Location = new System.Drawing.Point(209, 232);
            this.IngresarPrecio.Name = "IngresarPrecio";
            this.IngresarPrecio.Size = new System.Drawing.Size(187, 40);
            this.IngresarPrecio.TabIndex = 8;
            this.IngresarPrecio.Text = "";
            // 
            // IngresarDetalles
            // 
            this.IngresarDetalles.Location = new System.Drawing.Point(209, 305);
            this.IngresarDetalles.Name = "IngresarDetalles";
            this.IngresarDetalles.Size = new System.Drawing.Size(190, 94);
            this.IngresarDetalles.TabIndex = 9;
            this.IngresarDetalles.Text = "";
            // 
            // Ingre
            // 
            this.Ingre.Image = ((System.Drawing.Image)(resources.GetObject("Ingre.Image")));
            this.Ingre.Location = new System.Drawing.Point(141, 447);
            this.Ingre.Name = "Ingre";
            this.Ingre.Size = new System.Drawing.Size(84, 66);
            this.Ingre.TabIndex = 10;
            this.Ingre.UseVisualStyleBackColor = true;
            this.Ingre.Click += new System.EventHandler(this.Ingre_Click);
            // 
            // Cance
            // 
            this.Cance.Image = ((System.Drawing.Image)(resources.GetObject("Cance.Image")));
            this.Cance.Location = new System.Drawing.Point(329, 447);
            this.Cance.Name = "Cance";
            this.Cance.Size = new System.Drawing.Size(88, 66);
            this.Cance.TabIndex = 11;
            this.Cance.UseVisualStyleBackColor = true;
            this.Cance.Click += new System.EventHandler(this.Cance_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 544);
            this.Controls.Add(this.Cance);
            this.Controls.Add(this.Ingre);
            this.Controls.Add(this.IngresarDetalles);
            this.Controls.Add(this.IngresarPrecio);
            this.Controls.Add(this.IngresarCantidad);
            this.Controls.Add(this.IngresarProducto);
            this.Controls.Add(this.IngresarID);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Producto;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Detalles;
        private System.Windows.Forms.RichTextBox IngresarID;
        private System.Windows.Forms.RichTextBox IngresarProducto;
        private System.Windows.Forms.RichTextBox IngresarCantidad;
        private System.Windows.Forms.RichTextBox IngresarPrecio;
        private System.Windows.Forms.RichTextBox IngresarDetalles;
        private System.Windows.Forms.Button Ingre;
        private System.Windows.Forms.Button Cance;
    }
}