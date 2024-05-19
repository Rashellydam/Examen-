namespace Examen
{
    partial class Proveedor
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
            Codigo = new TextBox();
            CodigoTributario = new TextBox();
            RazonSocial = new TextBox();
            PrimerNombre = new TextBox();
            SegundoNombre = new TextBox();
            PrimerApellido = new TextBox();
            SegundoApellido = new TextBox();
            Telefono = new TextBox();
            Tipo = new ComboBox();
            TipoCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Direccion = new TextBox();
            label10 = new Label();
            Atencion = new TextBox();
            Zona = new TextBox();
            Cobrar = new TextBox();
            Aportes = new TextBox();
            label11 = new Label();
            DiasVencimientos = new TextBox();
            label12 = new Label();
            Aval = new TextBox();
            label13 = new Label();
            DireccionAval = new TextBox();
            label14 = new Label();
            CodigoAval = new TextBox();
            label15 = new Label();
            TelefonoAval = new TextBox();
            panel1 = new Panel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            Tabla = new DataGridView();
            CodigoTable = new DataGridViewTextBoxColumn();
            RazonSocialTable = new DataGridViewTextBoxColumn();
            PrimerNombreTable = new DataGridViewTextBoxColumn();
            SegundoNombreTable = new DataGridViewTextBoxColumn();
            PrimerApellidoTable = new DataGridViewTextBoxColumn();
            SegundoApellidoTable = new DataGridViewTextBoxColumn();
            TelefonoTable = new DataGridViewTextBoxColumn();
            TipoTable = new DataGridViewTextBoxColumn();
            DireccionTable = new DataGridViewTextBoxColumn();
            AtencionTable = new DataGridViewTextBoxColumn();
            DiasVencimientoTable = new DataGridViewTextBoxColumn();
            ZonaTable = new DataGridViewTextBoxColumn();
            CobrarTable = new DataGridViewTextBoxColumn();
            AportesTable = new DataGridViewTextBoxColumn();
            AvalTable = new DataGridViewTextBoxColumn();
            AvalCodigoTable = new DataGridViewTextBoxColumn();
            AvalDireccionTable = new DataGridViewTextBoxColumn();
            AvalTelefonoTable = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Grabar = new Button();
            Cancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Codigo
            // 
            Codigo.Location = new Point(139, 39);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(125, 27);
            Codigo.TabIndex = 0;
            // 
            // CodigoTributario
            // 
            CodigoTributario.Location = new Point(139, 99);
            CodigoTributario.Name = "CodigoTributario";
            CodigoTributario.Size = new Size(125, 27);
            CodigoTributario.TabIndex = 1;
            // 
            // RazonSocial
            // 
            RazonSocial.Location = new Point(590, 39);
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Size = new Size(351, 27);
            RazonSocial.TabIndex = 2;
            // 
            // PrimerNombre
            // 
            PrimerNombre.Location = new Point(590, 102);
            PrimerNombre.Name = "PrimerNombre";
            PrimerNombre.Size = new Size(162, 27);
            PrimerNombre.TabIndex = 3;
            PrimerNombre.TextChanged += textBox4_TextChanged;
            // 
            // SegundoNombre
            // 
            SegundoNombre.Location = new Point(778, 102);
            SegundoNombre.Name = "SegundoNombre";
            SegundoNombre.Size = new Size(163, 27);
            SegundoNombre.TabIndex = 4;
            // 
            // PrimerApellido
            // 
            PrimerApellido.Location = new Point(590, 177);
            PrimerApellido.Name = "PrimerApellido";
            PrimerApellido.Size = new Size(162, 27);
            PrimerApellido.TabIndex = 5;
            // 
            // SegundoApellido
            // 
            SegundoApellido.Location = new Point(778, 177);
            SegundoApellido.Name = "SegundoApellido";
            SegundoApellido.Size = new Size(163, 27);
            SegundoApellido.TabIndex = 6;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(590, 272);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(125, 27);
            Telefono.TabIndex = 7;
            // 
            // Tipo
            // 
            Tipo.FormattingEnabled = true;
            Tipo.Location = new Point(816, 272);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(125, 28);
            Tipo.TabIndex = 8;
            // 
            // TipoCliente
            // 
            TipoCliente.FormattingEnabled = true;
            TipoCliente.Location = new Point(139, 173);
            TipoCliente.Name = "TipoCliente";
            TipoCliente.Size = new Size(125, 28);
            TipoCliente.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 42);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 11;
            label2.Text = "Razón social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 102);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 177);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 13;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 265);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(747, 279);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 15;
            label6.Text = "Tipo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 88);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 16;
            label7.Text = "Cod. Tributario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 176);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 17;
            label8.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 329);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 19;
            label9.Text = "Dirección";
            // 
            // Direccion
            // 
            Direccion.Location = new Point(139, 326);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(162, 27);
            Direccion.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 410);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 21;
            label10.Text = "Atención";
            // 
            // Atencion
            // 
            Atencion.Location = new Point(139, 410);
            Atencion.Name = "Atencion";
            Atencion.Size = new Size(162, 27);
            Atencion.TabIndex = 20;
            // 
            // Zona
            // 
            Zona.Location = new Point(719, 360);
            Zona.Name = "Zona";
            Zona.Size = new Size(125, 27);
            Zona.TabIndex = 22;
            // 
            // Cobrar
            // 
            Cobrar.Location = new Point(719, 410);
            Cobrar.Name = "Cobrar";
            Cobrar.Size = new Size(125, 27);
            Cobrar.TabIndex = 23;
            // 
            // Aportes
            // 
            Aportes.Location = new Point(719, 469);
            Aportes.Name = "Aportes";
            Aportes.Size = new Size(125, 27);
            Aportes.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 493);
            label11.Name = "label11";
            label11.Size = new Size(243, 20);
            label11.TabIndex = 26;
            label11.Text = "Días de vencimiento de las facturas";
            // 
            // DiasVencimientos
            // 
            DiasVencimientos.Location = new Point(262, 479);
            DiasVencimientos.Name = "DiasVencimientos";
            DiasVencimientos.Size = new Size(35, 27);
            DiasVencimientos.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 618);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 28;
            label12.Text = "Aval";
            // 
            // Aval
            // 
            Aval.Location = new Point(139, 615);
            Aval.Name = "Aval";
            Aval.Size = new Size(351, 27);
            Aval.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 676);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 30;
            label13.Text = "Dirección";
            // 
            // DireccionAval
            // 
            DireccionAval.Location = new Point(139, 673);
            DireccionAval.Name = "DireccionAval";
            DireccionAval.Size = new Size(351, 27);
            DireccionAval.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(621, 614);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 32;
            label14.Text = "Código";
            // 
            // CodigoAval
            // 
            CodigoAval.Location = new Point(719, 611);
            CodigoAval.Name = "CodigoAval";
            CodigoAval.Size = new Size(351, 27);
            CodigoAval.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(621, 676);
            label15.Name = "label15";
            label15.Size = new Size(67, 20);
            label15.TabIndex = 34;
            label15.Text = "Teléfono";
            // 
            // TelefonoAval
            // 
            TelefonoAval.Location = new Point(719, 673);
            TelefonoAval.Name = "TelefonoAval";
            TelefonoAval.Size = new Size(351, 27);
            TelefonoAval.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(DiasVencimientos);
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 557);
            panel1.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(579, 455);
            label18.Name = "label18";
            label18.Size = new Size(86, 20);
            label18.TabIndex = 28;
            label18.Text = "Cta.Aportes";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(579, 403);
            label17.Name = "label17";
            label17.Size = new Size(72, 20);
            label17.TabIndex = 27;
            label17.Text = "Cobrador";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(579, 346);
            label16.Name = "label16";
            label16.Size = new Size(43, 20);
            label16.TabIndex = 26;
            label16.Text = "Zona";
            // 
            // Tabla
            // 
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { CodigoTable, RazonSocialTable, PrimerNombreTable, SegundoNombreTable, PrimerApellidoTable, SegundoApellidoTable, TelefonoTable, TipoTable, DireccionTable, AtencionTable, DiasVencimientoTable, ZonaTable, CobrarTable, AportesTable, AvalTable, AvalCodigoTable, AvalDireccionTable, AvalTelefonoTable, Column1 });
            Tabla.Location = new Point(41, 809);
            Tabla.Name = "Tabla";
            Tabla.RowHeadersWidth = 51;
            Tabla.Size = new Size(1029, 188);
            Tabla.TabIndex = 36;
            // 
            // CodigoTable
            // 
            CodigoTable.HeaderText = "Codigo";
            CodigoTable.MinimumWidth = 6;
            CodigoTable.Name = "CodigoTable";
            CodigoTable.Width = 125;
            // 
            // RazonSocialTable
            // 
            RazonSocialTable.HeaderText = "Razón Social";
            RazonSocialTable.MinimumWidth = 6;
            RazonSocialTable.Name = "RazonSocialTable";
            RazonSocialTable.Width = 125;
            // 
            // PrimerNombreTable
            // 
            PrimerNombreTable.HeaderText = "Primer Nombre";
            PrimerNombreTable.MinimumWidth = 6;
            PrimerNombreTable.Name = "PrimerNombreTable";
            PrimerNombreTable.Width = 125;
            // 
            // SegundoNombreTable
            // 
            SegundoNombreTable.HeaderText = "Segundo Nombre";
            SegundoNombreTable.MinimumWidth = 6;
            SegundoNombreTable.Name = "SegundoNombreTable";
            SegundoNombreTable.Width = 125;
            // 
            // PrimerApellidoTable
            // 
            PrimerApellidoTable.HeaderText = "Primer Apellido";
            PrimerApellidoTable.MinimumWidth = 6;
            PrimerApellidoTable.Name = "PrimerApellidoTable";
            PrimerApellidoTable.Width = 125;
            // 
            // SegundoApellidoTable
            // 
            SegundoApellidoTable.HeaderText = "Segundo Apellido";
            SegundoApellidoTable.MinimumWidth = 6;
            SegundoApellidoTable.Name = "SegundoApellidoTable";
            SegundoApellidoTable.Width = 125;
            // 
            // TelefonoTable
            // 
            TelefonoTable.HeaderText = "Teléfono";
            TelefonoTable.MinimumWidth = 6;
            TelefonoTable.Name = "TelefonoTable";
            TelefonoTable.Width = 125;
            // 
            // TipoTable
            // 
            TipoTable.HeaderText = "Tipo";
            TipoTable.MinimumWidth = 6;
            TipoTable.Name = "TipoTable";
            TipoTable.Width = 125;
            // 
            // DireccionTable
            // 
            DireccionTable.HeaderText = "Dirección";
            DireccionTable.MinimumWidth = 6;
            DireccionTable.Name = "DireccionTable";
            DireccionTable.Width = 125;
            // 
            // AtencionTable
            // 
            AtencionTable.HeaderText = "Atención";
            AtencionTable.MinimumWidth = 6;
            AtencionTable.Name = "AtencionTable";
            AtencionTable.Width = 125;
            // 
            // DiasVencimientoTable
            // 
            DiasVencimientoTable.HeaderText = "Días de Vencimiento";
            DiasVencimientoTable.MinimumWidth = 6;
            DiasVencimientoTable.Name = "DiasVencimientoTable";
            DiasVencimientoTable.Width = 125;
            // 
            // ZonaTable
            // 
            ZonaTable.HeaderText = "Zona";
            ZonaTable.MinimumWidth = 6;
            ZonaTable.Name = "ZonaTable";
            ZonaTable.Width = 125;
            // 
            // CobrarTable
            // 
            CobrarTable.HeaderText = "Cobrador";
            CobrarTable.MinimumWidth = 6;
            CobrarTable.Name = "CobrarTable";
            CobrarTable.Width = 125;
            // 
            // AportesTable
            // 
            AportesTable.HeaderText = "Aportes";
            AportesTable.MinimumWidth = 6;
            AportesTable.Name = "AportesTable";
            AportesTable.Width = 125;
            // 
            // AvalTable
            // 
            AvalTable.HeaderText = "Aval";
            AvalTable.MinimumWidth = 6;
            AvalTable.Name = "AvalTable";
            AvalTable.Width = 125;
            // 
            // AvalCodigoTable
            // 
            AvalCodigoTable.HeaderText = "Aval Código";
            AvalCodigoTable.MinimumWidth = 6;
            AvalCodigoTable.Name = "AvalCodigoTable";
            AvalCodigoTable.Width = 125;
            // 
            // AvalDireccionTable
            // 
            AvalDireccionTable.HeaderText = "Aval Dirección";
            AvalDireccionTable.MinimumWidth = 6;
            AvalDireccionTable.Name = "AvalDireccionTable";
            AvalDireccionTable.Width = 125;
            // 
            // AvalTelefonoTable
            // 
            AvalTelefonoTable.HeaderText = "Aval Teléfono";
            AvalTelefonoTable.MinimumWidth = 6;
            AvalTelefonoTable.Name = "AvalTelefonoTable";
            AvalTelefonoTable.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Grabar
            // 
            Grabar.Location = new Point(44, 745);
            Grabar.Name = "Grabar";
            Grabar.Size = new Size(512, 46);
            Grabar.TabIndex = 37;
            Grabar.Text = "Grabar";
            Grabar.UseVisualStyleBackColor = true;
            Grabar.Click += Grabar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(565, 745);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(505, 46);
            Cancelar.TabIndex = 38;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 1009);
            Controls.Add(Cancelar);
            Controls.Add(Grabar);
            Controls.Add(Tabla);
            Controls.Add(label15);
            Controls.Add(TelefonoAval);
            Controls.Add(label14);
            Controls.Add(CodigoAval);
            Controls.Add(label13);
            Controls.Add(DireccionAval);
            Controls.Add(label12);
            Controls.Add(Aval);
            Controls.Add(label11);
            Controls.Add(Aportes);
            Controls.Add(Cobrar);
            Controls.Add(Zona);
            Controls.Add(label10);
            Controls.Add(Atencion);
            Controls.Add(label9);
            Controls.Add(Direccion);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TipoCliente);
            Controls.Add(Tipo);
            Controls.Add(Telefono);
            Controls.Add(SegundoApellido);
            Controls.Add(PrimerApellido);
            Controls.Add(SegundoNombre);
            Controls.Add(PrimerNombre);
            Controls.Add(RazonSocial);
            Controls.Add(CodigoTributario);
            Controls.Add(Codigo);
            Controls.Add(panel1);
            Name = "Proveedor";
            Text = "Proveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Codigo;
        private TextBox CodigoTributario;
        private TextBox RazonSocial;
        private TextBox PrimerNombre;
        private TextBox SegundoNombre;
        private TextBox PrimerApellido;
        private TextBox SegundoApellido;
        private TextBox Telefono;
        private ComboBox Tipo;
        private ComboBox TipoCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Direccion;
        private Label label10;
        private TextBox Atencion;
        private TextBox Zona;
        private TextBox Cobrar;
        private TextBox Aportes;
        private Label label11;
        private TextBox DiasVencimientos;
        private Label label12;
        private TextBox Aval;
        private Label label13;
        private TextBox DireccionAval;
        private Label label14;
        private TextBox CodigoAval;
        private Label label15;
        private TextBox TelefonoAval;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private Label label16;
        private DataGridView Tabla;
        private Button Grabar;
        private Button Cancelar;
        private DataGridViewTextBoxColumn CodigoTable;
        private DataGridViewTextBoxColumn RazonSocialTable;
        private DataGridViewTextBoxColumn PrimerNombreTable;
        private DataGridViewTextBoxColumn SegundoNombreTable;
        private DataGridViewTextBoxColumn PrimerApellidoTable;
        private DataGridViewTextBoxColumn SegundoApellidoTable;
        private DataGridViewTextBoxColumn TelefonoTable;
        private DataGridViewTextBoxColumn TipoTable;
        private DataGridViewTextBoxColumn DireccionTable;
        private DataGridViewTextBoxColumn AtencionTable;
        private DataGridViewTextBoxColumn DiasVencimientoTable;
        private DataGridViewTextBoxColumn ZonaTable;
        private DataGridViewTextBoxColumn CobrarTable;
        private DataGridViewTextBoxColumn AportesTable;
        private DataGridViewTextBoxColumn AvalTable;
        private DataGridViewTextBoxColumn AvalCodigoTable;
        private DataGridViewTextBoxColumn AvalDireccionTable;
        private DataGridViewTextBoxColumn AvalTelefonoTable;
        private DataGridViewTextBoxColumn Column1;
    }
}