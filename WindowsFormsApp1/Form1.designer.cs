
namespace ClienteWindows
{
    partial class Form1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnRegion = new System.Windows.Forms.Button();
            this.btnShippers = new System.Windows.Forms.Button();
            this.btnCustomerDemo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(181, 112);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(213, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(181, 146);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(213, 20);
            this.txt2.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 250);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 27);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(139, 250);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 27);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(241, 250);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 27);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(44, 338);
            this.dgvRegion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.RowHeadersWidth = 51;
            this.dgvRegion.RowTemplate.Height = 24;
            this.dgvRegion.Size = new System.Drawing.Size(512, 281);
            this.dgvRegion.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(215, 298);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 119);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Region ID";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 153);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Region Descripcion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(425, 293);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 27);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 185);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 13);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Region Descripcion";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(181, 178);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(213, 20);
            this.txt3.TabIndex = 13;
            // 
            // btnRegion
            // 
            this.btnRegion.Location = new System.Drawing.Point(15, 40);
            this.btnRegion.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegion.Name = "btnRegion";
            this.btnRegion.Size = new System.Drawing.Size(106, 48);
            this.btnRegion.TabIndex = 14;
            this.btnRegion.Text = "Region";
            this.btnRegion.UseVisualStyleBackColor = true;
            this.btnRegion.Click += new System.EventHandler(this.btnRegion_Click);
            // 
            // btnShippers
            // 
            this.btnShippers.Location = new System.Drawing.Point(139, 40);
            this.btnShippers.Margin = new System.Windows.Forms.Padding(2);
            this.btnShippers.Name = "btnShippers";
            this.btnShippers.Size = new System.Drawing.Size(110, 48);
            this.btnShippers.TabIndex = 15;
            this.btnShippers.Text = "Shippers";
            this.btnShippers.UseVisualStyleBackColor = true;
            this.btnShippers.Click += new System.EventHandler(this.btnShippers_Click);
            // 
            // btnCustomerDemo
            // 
            this.btnCustomerDemo.Location = new System.Drawing.Point(274, 40);
            this.btnCustomerDemo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerDemo.Name = "btnCustomerDemo";
            this.btnCustomerDemo.Size = new System.Drawing.Size(102, 48);
            this.btnCustomerDemo.TabIndex = 16;
            this.btnCustomerDemo.Text = "Customer Demographics";
            this.btnCustomerDemo.UseVisualStyleBackColor = true;
            this.btnCustomerDemo.Click += new System.EventHandler(this.btnCustomerDemo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.MaximumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Northwind";
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "SHIPPERSID",
            "COMPANYNAME"});
            this.cbBuscar.Location = new System.Drawing.Point(44, 298);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(143, 21);
            this.cbBuscar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 630);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCustomerDemo);
            this.Controls.Add(this.btnShippers);
            this.Controls.Add(this.btnRegion);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvRegion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Button btnShippers;
        private System.Windows.Forms.Button btnCustomerDemo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBuscar;
    }
}

