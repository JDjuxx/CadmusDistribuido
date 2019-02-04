namespace CadmusCursosOnline
{
    partial class ListaCursosImpartidos
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
            this.cursosImpartidos = new System.Windows.Forms.DataGridView();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudianteCurso = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cursosImpartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // cursosImpartidos
            // 
            this.cursosImpartidos.AllowUserToOrderColumns = true;
            this.cursosImpartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursosImpartidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCurso,
            this.name,
            this.horas,
            this.Pago});
            this.cursosImpartidos.Location = new System.Drawing.Point(12, 37);
            this.cursosImpartidos.Name = "cursosImpartidos";
            this.cursosImpartidos.ReadOnly = true;
            this.cursosImpartidos.Size = new System.Drawing.Size(443, 106);
            this.cursosImpartidos.TabIndex = 9;
            this.cursosImpartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cursosImpartidos_CellContentClick);
            this.cursosImpartidos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cursosImpartidos_CellEnter);
            // 
            // idCurso
            // 
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Costo";
            this.Pago.Name = "Pago";
            // 
            // estudianteCurso
            // 
            this.estudianteCurso.AllowUserToOrderColumns = true;
            this.estudianteCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudianteCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.nota});
            this.estudianteCurso.Location = new System.Drawing.Point(12, 173);
            this.estudianteCurso.Name = "estudianteCurso";
            this.estudianteCurso.Size = new System.Drawing.Size(443, 64);
            this.estudianteCurso.TabIndex = 10;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Estudiante";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido Estudiante";
            this.apellido.Name = "apellido";
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(646, 396);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(142, 42);
            this.volver.TabIndex = 11;
            this.volver.Text = "Regresar";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ListaCursosImpartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.estudianteCurso);
            this.Controls.Add(this.cursosImpartidos);
            this.Name = "ListaCursosImpartidos";
            this.Text = "ListaCursosImpartidos";
            ((System.ComponentModel.ISupportInitialize)(this.cursosImpartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cursosImpartidos;
        private System.Windows.Forms.DataGridView estudianteCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
    }
}