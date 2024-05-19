namespace Examen
{
    partial class Inventario
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
            panel1 = new Panel();
            Cancelar = new Button();
            tabla = new DataGridView();
            Entrada = new DataGridViewTextBoxColumn();
            factura = new DataGridViewTextBoxColumn();
            follo = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            articulos = new DataGridViewTextBoxColumn();
            precios = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Agregar = new Button();
            Precio = new TextBox();
            Cantidad = new TextBox();
            Articulo = new TextBox();
            NombreProveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            FolloFactura = new TextBox();
            label2 = new Label();
            FechaFactura = new DateTimePicker();
            FechaEntrada = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Cancelar);
            panel1.Controls.Add(tabla);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Agregar);
            panel1.Controls.Add(Precio);
            panel1.Controls.Add(Cantidad);
            panel1.Controls.Add(Articulo);
            panel1.Controls.Add(NombreProveedor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(FolloFactura);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FechaFactura);
            panel1.Controls.Add(FechaEntrada);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 564);
            panel1.TabIndex = 0;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(947, 20);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 17;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Entrada, factura, follo, Proveedor, articulos, precios });
            tabla.Location = new Point(31, 375);
            tabla.Name = "tabla";
            tabla.RowHeadersWidth = 51;
            tabla.Size = new Size(1010, 148);
            tabla.TabIndex = 15;
            // 
            // Entrada
            // 
            Entrada.HeaderText = "Fecha Entrada";
            Entrada.MinimumWidth = 6;
            Entrada.Name = "Entrada";
            Entrada.Width = 125;
            // 
            // factura
            // 
            factura.HeaderText = "Fecha de Factura";
            factura.MinimumWidth = 6;
            factura.Name = "factura";
            factura.Width = 125;
            // 
            // follo
            // 
            follo.HeaderText = "Follo Factura";
            follo.MinimumWidth = 6;
            follo.Name = "follo";
            follo.Width = 125;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Nombre de Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.Width = 125;
            // 
            // articulos
            // 
            articulos.HeaderText = "Artículo";
            articulos.MinimumWidth = 6;
            articulos.Name = "articulos";
            articulos.Width = 125;
            // 
            // precios
            // 
            precios.HeaderText = "Precio";
            precios.MinimumWidth = 6;
            precios.Name = "precios";
            precios.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 292);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 14;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 292);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 292);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 12;
            label5.Text = "Artículo";
            // 
            // Agregar
            // 
            Agregar.Location = new Point(485, 329);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(94, 29);
            Agregar.TabIndex = 11;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // Precio
            // 
            Precio.Location = new Point(333, 329);
            Precio.Name = "Precio";
            Precio.Size = new Size(125, 27);
            Precio.TabIndex = 10;
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(181, 329);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(125, 27);
            Cantidad.TabIndex = 9;
            // 
            // Articulo
            // 
            Articulo.Location = new Point(31, 329);
            Articulo.Name = "Articulo";
            Articulo.Size = new Size(125, 27);
            Articulo.TabIndex = 8;
            // 
            // NombreProveedor
            // 
            NombreProveedor.Location = new Point(31, 233);
            NombreProveedor.Name = "NombreProveedor";
            NombreProveedor.Size = new Size(404, 27);
            NombreProveedor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 192);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre del Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 104);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 5;
            label3.Text = "Follo Factura";
            // 
            // FolloFactura
            // 
            FolloFactura.Location = new Point(310, 138);
            FolloFactura.Name = "FolloFactura";
            FolloFactura.Size = new Size(125, 27);
            FolloFactura.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 104);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha Factura";
            label2.Click += label2_Click;
            // 
            // FechaFactura
            // 
            FechaFactura.Location = new Point(31, 138);
            FechaFactura.Name = "FechaFactura";
            FechaFactura.Size = new Size(250, 27);
            FechaFactura.TabIndex = 2;
            // 
            // FechaEntrada
            // 
            FechaEntrada.Location = new Point(31, 58);
            FechaEntrada.Name = "FechaEntrada";
            FechaEntrada.Size = new Size(250, 27);
            FechaEntrada.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Entrada";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 588);
            Controls.Add(panel1);
            Name = "Inventario";
            Text = "Inventario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DateTimePicker FechaFactura;
        private DateTimePicker FechaEntrada;
        private Label label1;
        private TextBox NombreProveedor;
        private Label label4;
        private Label label3;
        private TextBox FolloFactura;
        private Button Cancelar;
        private DataGridView tabla;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button Agregar;
        private TextBox Precio;
        private TextBox Cantidad;
        private TextBox Articulo;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn factura;
        private DataGridViewTextBoxColumn follo;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn articulos;
        private DataGridViewTextBoxColumn precios;
    }
}