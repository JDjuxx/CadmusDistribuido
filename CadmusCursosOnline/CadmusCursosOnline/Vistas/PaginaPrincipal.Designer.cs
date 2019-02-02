namespace CadmusCursosOnline
{
    partial class principalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principalPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inicio = new System.Windows.Forms.TabPage();
            this.inscription = new System.Windows.Forms.TabPage();
            this.teach = new System.Windows.Forms.TabPage();
            this.myCurses = new System.Windows.Forms.TabPage();
            this.myAccount = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tablaCursos1 = new System.Windows.Forms.DataGridView();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choose = new System.Windows.Forms.Button();
            this.impartir = new System.Windows.Forms.Button();
            this.tablaCursos2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cursosImpartidos = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retirarse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.inicio.SuspendLayout();
            this.inscription.SuspendLayout();
            this.teach.SuspendLayout();
            this.myCurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inicio);
            this.tabControl1.Controls.Add(this.inscription);
            this.tabControl1.Controls.Add(this.teach);
            this.tabControl1.Controls.Add(this.myCurses);
            this.tabControl1.Controls.Add(this.myAccount);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // inicio
            // 
            this.inicio.Controls.Add(this.pictureBox2);
            this.inicio.Controls.Add(this.pictureBox1);
            this.inicio.Location = new System.Drawing.Point(4, 22);
            this.inicio.Name = "inicio";
            this.inicio.Padding = new System.Windows.Forms.Padding(3);
            this.inicio.Size = new System.Drawing.Size(790, 485);
            this.inicio.TabIndex = 0;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // inscription
            // 
            this.inscription.Controls.Add(this.choose);
            this.inscription.Controls.Add(this.tablaCursos1);
            this.inscription.Controls.Add(this.button1);
            this.inscription.Controls.Add(this.textBox1);
            this.inscription.Controls.Add(this.label1);
            this.inscription.Location = new System.Drawing.Point(4, 22);
            this.inscription.Name = "inscription";
            this.inscription.Padding = new System.Windows.Forms.Padding(3);
            this.inscription.Size = new System.Drawing.Size(790, 485);
            this.inscription.TabIndex = 1;
            this.inscription.Text = "Incríbete";
            this.inscription.UseVisualStyleBackColor = true;
            // 
            // teach
            // 
            this.teach.Controls.Add(this.cursosImpartidos);
            this.teach.Controls.Add(this.impartir);
            this.teach.Controls.Add(this.tablaCursos2);
            this.teach.Controls.Add(this.button3);
            this.teach.Controls.Add(this.textBox2);
            this.teach.Controls.Add(this.label2);
            this.teach.Location = new System.Drawing.Point(4, 22);
            this.teach.Name = "teach";
            this.teach.Size = new System.Drawing.Size(790, 485);
            this.teach.TabIndex = 2;
            this.teach.Text = "Impartir Curso";
            this.teach.UseVisualStyleBackColor = true;
            // 
            // myCurses
            // 
            this.myCurses.Controls.Add(this.retirarse);
            this.myCurses.Controls.Add(this.dataGridView1);
            this.myCurses.Controls.Add(this.button2);
            this.myCurses.Controls.Add(this.textBox3);
            this.myCurses.Controls.Add(this.label3);
            this.myCurses.Location = new System.Drawing.Point(4, 22);
            this.myCurses.Name = "myCurses";
            this.myCurses.Size = new System.Drawing.Size(790, 485);
            this.myCurses.TabIndex = 3;
            this.myCurses.Text = "Mis Cursos";
            this.myCurses.UseVisualStyleBackColor = true;
            // 
            // myAccount
            // 
            this.myAccount.Location = new System.Drawing.Point(4, 22);
            this.myAccount.Name = "myAccount";
            this.myAccount.Size = new System.Drawing.Size(790, 485);
            this.myAccount.TabIndex = 4;
            this.myAccount.Text = "Mi Cuenta";
            this.myAccount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Curso ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tablaCursos1
            // 
            this.tablaCursos1.AllowUserToOrderColumns = true;
            this.tablaCursos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCursos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCurso,
            this.nombre,
            this.categoria,
            this.horas,
            this.costo});
            this.tablaCursos1.Location = new System.Drawing.Point(10, 117);
            this.tablaCursos1.Name = "tablaCursos1";
            this.tablaCursos1.Size = new System.Drawing.Size(543, 262);
            this.tablaCursos1.TabIndex = 3;
            // 
            // idCurso
            // 
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            // 
            // choose
            // 
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(608, 443);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(144, 33);
            this.choose.TabIndex = 4;
            this.choose.Text = "Incribirse";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // impartir
            // 
            this.impartir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impartir.Location = new System.Drawing.Point(560, 428);
            this.impartir.Name = "impartir";
            this.impartir.Size = new System.Drawing.Size(209, 33);
            this.impartir.TabIndex = 9;
            this.impartir.Text = "Seleccionar Curso";
            this.impartir.UseVisualStyleBackColor = true;
            this.impartir.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablaCursos2
            // 
            this.tablaCursos2.AllowUserToOrderColumns = true;
            this.tablaCursos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCursos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tablaCursos2.Location = new System.Drawing.Point(10, 100);
            this.tablaCursos2.Name = "tablaCursos2";
            this.tablaCursos2.Size = new System.Drawing.Size(445, 262);
            this.tablaCursos2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(623, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(202, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 31);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Curso ";
            // 
            // cursosImpartidos
            // 
            this.cursosImpartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cursosImpartidos.Location = new System.Drawing.Point(10, 428);
            this.cursosImpartidos.Name = "cursosImpartidos";
            this.cursosImpartidos.Size = new System.Drawing.Size(209, 33);
            this.cursosImpartidos.TabIndex = 10;
            this.cursosImpartidos.Text = "Lista de Cursos";
            this.cursosImpartidos.UseVisualStyleBackColor = true;
            this.cursosImpartidos.Click += new System.EventHandler(this.cursosImpartidos_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Curso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Horas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.nota});
            this.dataGridView1.Location = new System.Drawing.Point(18, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 226);
            this.dataGridView1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(210, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(351, 31);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre del Curso ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CadmusCursosOnline.Properties.Resources.promoción;
            this.pictureBox2.Location = new System.Drawing.Point(91, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 97);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadmusCursosOnline.Properties.Resources.logoFrase;
            this.pictureBox1.Location = new System.Drawing.Point(91, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Curso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Horas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            // 
            // retirarse
            // 
            this.retirarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirarse.Location = new System.Drawing.Point(605, 427);
            this.retirarse.Name = "retirarse";
            this.retirarse.Size = new System.Drawing.Size(146, 31);
            this.retirarse.TabIndex = 14;
            this.retirarse.Text = "Retirarse";
            this.retirarse.UseVisualStyleBackColor = true;
            this.retirarse.Click += new System.EventHandler(this.button5_Click);
            // 
            // principalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principalPage";
            this.Text = "Pagina Principal";
            this.tabControl1.ResumeLayout(false);
            this.inicio.ResumeLayout(false);
            this.inscription.ResumeLayout(false);
            this.inscription.PerformLayout();
            this.teach.ResumeLayout(false);
            this.teach.PerformLayout();
            this.myCurses.ResumeLayout(false);
            this.myCurses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage inscription;
        private System.Windows.Forms.TabPage teach;
        private System.Windows.Forms.TabPage myCurses;
        private System.Windows.Forms.TabPage myAccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.DataGridView tablaCursos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.Button impartir;
        private System.Windows.Forms.DataGridView tablaCursos2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cursosImpartidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button retirarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
    }
}

