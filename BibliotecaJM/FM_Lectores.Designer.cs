namespace BibliotecaJM
{
    partial class FM_Lectores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.gbBuscarLec = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.gbMantenimientoLec = new System.Windows.Forms.GroupBox();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio_lec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_penalizacion_lec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.gbBuscarLec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbMantenimientoLec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.domicilio_lec,
            this.dataGridViewTextBoxColumn4,
            this.fecha_penalizacion_lec});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 80);
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.Size = new System.Drawing.Size(544, 459);
            this.lectoresDataGridView.TabIndex = 1;
            // 
            // gbBuscarLec
            // 
            this.gbBuscarLec.Controls.Add(this.bBorrar);
            this.gbBuscarLec.Controls.Add(this.bModificar);
            this.gbBuscarLec.Controls.Add(this.bNuevo);
            this.gbBuscarLec.Controls.Add(this.bBuscarNombre);
            this.gbBuscarLec.Controls.Add(this.tbNombre);
            this.gbBuscarLec.Controls.Add(this.label1);
            this.gbBuscarLec.Controls.Add(this.lectoresDataGridView);
            this.gbBuscarLec.Location = new System.Drawing.Point(12, 12);
            this.gbBuscarLec.Name = "gbBuscarLec";
            this.gbBuscarLec.Size = new System.Drawing.Size(574, 588);
            this.gbBuscarLec.TabIndex = 2;
            this.gbBuscarLec.TabStop = false;
            this.gbBuscarLec.Text = "Buscar Lectores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(156, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(287, 30);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 4;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gbMantenimientoLec
            // 
            this.gbMantenimientoLec.Controls.Add(this.bCancelar);
            this.gbMantenimientoLec.Controls.Add(this.bAceptar);
            this.gbMantenimientoLec.Controls.Add(id_lecLabel);
            this.gbMantenimientoLec.Controls.Add(this.id_lecTextBox);
            this.gbMantenimientoLec.Controls.Add(nombre_lecLabel);
            this.gbMantenimientoLec.Controls.Add(this.nombre_lecTextBox);
            this.gbMantenimientoLec.Controls.Add(domicilio_lecLabel);
            this.gbMantenimientoLec.Controls.Add(this.domicilio_lecTextBox);
            this.gbMantenimientoLec.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbMantenimientoLec.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.gbMantenimientoLec.Location = new System.Drawing.Point(608, 13);
            this.gbMantenimientoLec.Name = "gbMantenimientoLec";
            this.gbMantenimientoLec.Size = new System.Drawing.Size(394, 587);
            this.gbMantenimientoLec.TabIndex = 3;
            this.gbMantenimientoLec.TabStop = false;
            this.gbMantenimientoLec.Text = "Mantenimiento Lectores";
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(26, 545);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(109, 23);
            this.bNuevo.TabIndex = 4;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(217, 545);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(110, 23);
            this.bModificar.TabIndex = 4;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(410, 545);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(121, 23);
            this.bBorrar.TabIndex = 4;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(270, 476);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(119, 476);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 18;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(33, 55);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(68, 13);
            id_lecLabel.TabIndex = 9;
            id_lecLabel.Text = "Identificador:";
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(155, 52);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.ReadOnly = true;
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 10;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(33, 104);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 11;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(155, 101);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 12;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(33, 154);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 13;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(155, 151);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 14;
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(33, 204);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(117, 13);
            fecha_penalizacion_lecLabel.TabIndex = 15;
            fecha_penalizacion_lecLabel.Text = "Fecha de penalización:";
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Enabled = false;
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(155, 200);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_lec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // domicilio_lec
            // 
            this.domicilio_lec.DataPropertyName = "domicilio_lec";
            this.domicilio_lec.HeaderText = "domicilio_lec";
            this.domicilio_lec.Name = "domicilio_lec";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "provincia_lec";
            this.dataGridViewTextBoxColumn4.HeaderText = "provincia_lec";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // fecha_penalizacion_lec
            // 
            this.fecha_penalizacion_lec.DataPropertyName = "fecha_penalizacion_lec";
            this.fecha_penalizacion_lec.HeaderText = "fecha_penalizacion_lec";
            this.fecha_penalizacion_lec.Name = "fecha_penalizacion_lec";
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1014, 700);
            this.Controls.Add(this.gbMantenimientoLec);
            this.Controls.Add(this.gbBuscarLec);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            this.gbBuscarLec.ResumeLayout(false);
            this.gbBuscarLec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbMantenimientoLec.ResumeLayout(false);
            this.gbMantenimientoLec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.GroupBox gbBuscarLec;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio_lec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_penalizacion_lec;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.GroupBox gbMantenimientoLec;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
    }
}
