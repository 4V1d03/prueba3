namespace ConexionSQL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmodificar = new System.Windows.Forms.RadioButton();
            this.rbeliminar = new System.Windows.Forms.RadioButton();
            this.rbregistrar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmodificar);
            this.groupBox1.Controls.Add(this.rbeliminar);
            this.groupBox1.Controls.Add(this.rbregistrar);
            this.groupBox1.Location = new System.Drawing.Point(14, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(528, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento C# - SQL Sever";
            // 
            // rbmodificar
            // 
            this.rbmodificar.AutoSize = true;
            this.rbmodificar.Location = new System.Drawing.Point(381, 41);
            this.rbmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbmodificar.Name = "rbmodificar";
            this.rbmodificar.Size = new System.Drawing.Size(94, 24);
            this.rbmodificar.TabIndex = 3;
            this.rbmodificar.TabStop = true;
            this.rbmodificar.Text = "Modificar";
            this.rbmodificar.UseVisualStyleBackColor = true;
            // 
            // rbeliminar
            // 
            this.rbeliminar.AutoSize = true;
            this.rbeliminar.Location = new System.Drawing.Point(200, 41);
            this.rbeliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbeliminar.Name = "rbeliminar";
            this.rbeliminar.Size = new System.Drawing.Size(84, 24);
            this.rbeliminar.TabIndex = 2;
            this.rbeliminar.TabStop = true;
            this.rbeliminar.Text = "Eliminar";
            this.rbeliminar.UseVisualStyleBackColor = true;
            // 
            // rbregistrar
            // 
            this.rbregistrar.AutoSize = true;
            this.rbregistrar.Location = new System.Drawing.Point(21, 41);
            this.rbregistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbregistrar.Name = "rbregistrar";
            this.rbregistrar.Size = new System.Drawing.Size(89, 24);
            this.rbregistrar.TabIndex = 1;
            this.rbregistrar.TabStop = true;
            this.rbregistrar.Text = "Registrar";
            this.rbregistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(150, 164);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(246, 27);
            this.txtid.TabIndex = 2;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(150, 299);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpfecha.MaxDate = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            this.dtpfecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(246, 27);
            this.dtpfecha.TabIndex = 3;
            this.dtpfecha.Value = new System.DateTime(2023, 2, 28, 0, 0, 0, 0);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(431, 147);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(111, 48);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(150, 207);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(246, 27);
            this.txtnombre.TabIndex = 5;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(150, 252);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(246, 27);
            this.txtapellidos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(431, 211);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(111, 48);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(431, 281);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(111, 48);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 371);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(528, 200);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbmodificar;
        private RadioButton rbeliminar;
        private RadioButton rbregistrar;
        private Label label1;
        private TextBox txtid;
        private DateTimePicker dtpfecha;
        private Button btnagregar;
        private TextBox txtnombre;
        private TextBox txtapellidos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btneliminar;
        private Button btnmodificar;
        private DataGridView dataGridView1;
    }
}