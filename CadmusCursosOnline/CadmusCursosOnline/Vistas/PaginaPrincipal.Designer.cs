﻿namespace CadmusCursosOnline
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inscription = new System.Windows.Forms.TabPage();
            this.choose = new System.Windows.Forms.Button();
            this.tablaCursos1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teach = new System.Windows.Forms.TabPage();
            this.cursosImpartidos = new System.Windows.Forms.Button();
            this.impartir = new System.Windows.Forms.Button();
            this.tablaCursos2 = new System.Windows.Forms.DataGridView();
            this.buscarCurProf = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myCurses = new System.Windows.Forms.TabPage();
            this.retirarse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myAccount = new System.Windows.Forms.TabPage();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCup = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelNac = new System.Windows.Forms.Label();
            this.labelFA = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.formAcad = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nac = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.cuprest = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.cambiarCuenta = new System.Windows.Forms.LinkLabel();
            this.usern = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos1)).BeginInit();
            this.teach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos2)).BeginInit();
            this.myCurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.myAccount.SuspendLayout();
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
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
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
            this.inscription.Enter += new System.EventHandler(this.inscription_Enter);
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
            // tablaCursos1
            // 
            this.tablaCursos1.AllowUserToOrderColumns = true;
            this.tablaCursos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCursos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Costo,
            this.Horas});
            this.tablaCursos1.Location = new System.Drawing.Point(10, 117);
            this.tablaCursos1.Name = "tablaCursos1";
            this.tablaCursos1.Size = new System.Drawing.Size(353, 262);
            this.tablaCursos1.TabIndex = 3;
            this.tablaCursos1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCursos1_CellContentClick);
            this.tablaCursos1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCursos1_CellEnter);
            this.tablaCursos1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCursos1_RowEnter);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 31);
            this.textBox1.TabIndex = 1;
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
            // teach
            // 
            this.teach.Controls.Add(this.cursosImpartidos);
            this.teach.Controls.Add(this.impartir);
            this.teach.Controls.Add(this.tablaCursos2);
            this.teach.Controls.Add(this.buscarCurProf);
            this.teach.Controls.Add(this.textBox2);
            this.teach.Controls.Add(this.label2);
            this.teach.Location = new System.Drawing.Point(4, 22);
            this.teach.Name = "teach";
            this.teach.Size = new System.Drawing.Size(790, 485);
            this.teach.TabIndex = 2;
            this.teach.Text = "Impartir Curso";
            this.teach.UseVisualStyleBackColor = true;
            this.teach.Enter += new System.EventHandler(this.teach_Enter);
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.tablaCursos2.Location = new System.Drawing.Point(10, 100);
            this.tablaCursos2.Name = "tablaCursos2";
            this.tablaCursos2.Size = new System.Drawing.Size(445, 262);
            this.tablaCursos2.TabIndex = 8;
            this.tablaCursos2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCursos2_CellContentClick);
            // 
            // buscarCurProf
            // 
            this.buscarCurProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCurProf.Location = new System.Drawing.Point(623, 24);
            this.buscarCurProf.Name = "buscarCurProf";
            this.buscarCurProf.Size = new System.Drawing.Size(146, 31);
            this.buscarCurProf.TabIndex = 7;
            this.buscarCurProf.Text = "Buscar";
            this.buscarCurProf.UseVisualStyleBackColor = true;
            this.buscarCurProf.Click += new System.EventHandler(this.buscarCurProf_Click);
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
            this.myCurses.Click += new System.EventHandler(this.myCurses_Click);
            this.myCurses.Enter += new System.EventHandler(this.myCurses_Enter);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCurso,
            this.dataGridViewTextBoxColumn6,
            this.nota});
            this.dataGridView1.Location = new System.Drawing.Point(18, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCurso
            // 
            this.idCurso.HeaderText = "idCurso";
            this.idCurso.Name = "idCurso";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // nota
            // 
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
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
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            // myAccount
            // 
            this.myAccount.Controls.Add(this.labelNombre);
            this.myAccount.Controls.Add(this.labelApellido);
            this.myAccount.Controls.Add(this.labelCup);
            this.myAccount.Controls.Add(this.labelDob);
            this.myAccount.Controls.Add(this.labelNac);
            this.myAccount.Controls.Add(this.labelFA);
            this.myAccount.Controls.Add(this.labelUsuario);
            this.myAccount.Controls.Add(this.formAcad);
            this.myAccount.Controls.Add(this.label18);
            this.myAccount.Controls.Add(this.nac);
            this.myAccount.Controls.Add(this.dob);
            this.myAccount.Controls.Add(this.cuprest);
            this.myAccount.Controls.Add(this.apellido);
            this.myAccount.Controls.Add(this.name);
            this.myAccount.Controls.Add(this.label11);
            this.myAccount.Controls.Add(this.label9);
            this.myAccount.Controls.Add(this.label8);
            this.myAccount.Controls.Add(this.label7);
            this.myAccount.Controls.Add(this.label6);
            this.myAccount.Controls.Add(this.delete);
            this.myAccount.Controls.Add(this.cambiarCuenta);
            this.myAccount.Controls.Add(this.usern);
            this.myAccount.Controls.Add(this.label4);
            this.myAccount.Location = new System.Drawing.Point(4, 22);
            this.myAccount.Name = "myAccount";
            this.myAccount.Size = new System.Drawing.Size(790, 485);
            this.myAccount.TabIndex = 4;
            this.myAccount.Text = "Mi Cuenta";
            this.myAccount.UseVisualStyleBackColor = true;
            this.myAccount.Click += new System.EventHandler(this.myAccount_Click);
            this.myAccount.Enter += new System.EventHandler(this.myAccount_Enter);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(99, 70);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 22);
            this.labelNombre.TabIndex = 55;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(99, 112);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(0, 22);
            this.labelApellido.TabIndex = 54;
            // 
            // labelCup
            // 
            this.labelCup.AutoSize = true;
            this.labelCup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCup.Location = new System.Drawing.Point(559, 11);
            this.labelCup.Name = "labelCup";
            this.labelCup.Size = new System.Drawing.Size(0, 22);
            this.labelCup.TabIndex = 53;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDob.Location = new System.Drawing.Point(435, 46);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(0, 22);
            this.labelDob.TabIndex = 52;
            // 
            // labelNac
            // 
            this.labelNac.AutoSize = true;
            this.labelNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNac.Location = new System.Drawing.Point(505, 86);
            this.labelNac.Name = "labelNac";
            this.labelNac.Size = new System.Drawing.Size(0, 22);
            this.labelNac.TabIndex = 51;
            // 
            // labelFA
            // 
            this.labelFA.AutoSize = true;
            this.labelFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFA.Location = new System.Drawing.Point(583, 128);
            this.labelFA.Name = "labelFA";
            this.labelFA.Size = new System.Drawing.Size(0, 22);
            this.labelFA.TabIndex = 50;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(94, 25);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 22);
            this.labelUsuario.TabIndex = 49;
            // 
            // formAcad
            // 
            this.formAcad.AutoSize = true;
            this.formAcad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formAcad.Location = new System.Drawing.Point(594, 125);
            this.formAcad.Name = "formAcad";
            this.formAcad.Size = new System.Drawing.Size(0, 24);
            this.formAcad.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(374, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 24);
            this.label18.TabIndex = 47;
            this.label18.Text = "Formación académica:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nac
            // 
            this.nac.AutoSize = true;
            this.nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nac.Location = new System.Drawing.Point(594, 86);
            this.nac.Name = "nac";
            this.nac.Size = new System.Drawing.Size(0, 24);
            this.nac.TabIndex = 46;
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(594, 46);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(0, 24);
            this.dob.TabIndex = 45;
            // 
            // cuprest
            // 
            this.cuprest.AutoSize = true;
            this.cuprest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuprest.Location = new System.Drawing.Point(594, 11);
            this.cuprest.Name = "cuprest";
            this.cuprest.Size = new System.Drawing.Size(0, 24);
            this.cuprest.TabIndex = 44;
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(145, 112);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(0, 24);
            this.apellido.TabIndex = 42;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(145, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 24);
            this.name.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cupones Restantes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "DOB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nacionalidad:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nombre:";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(610, 441);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 35);
            this.delete.TabIndex = 34;
            this.delete.Text = "Eliminar Cuenta";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cambiarCuenta
            // 
            this.cambiarCuenta.AutoSize = true;
            this.cambiarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarCuenta.Location = new System.Drawing.Point(9, 182);
            this.cambiarCuenta.Name = "cambiarCuenta";
            this.cambiarCuenta.Size = new System.Drawing.Size(155, 20);
            this.cambiarCuenta.TabIndex = 33;
            this.cambiarCuenta.TabStop = true;
            this.cambiarCuenta.Text = "Cambiar Contraseña";
            this.cambiarCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cambiarCuenta_LinkClicked);
            // 
            // usern
            // 
            this.usern.AutoSize = true;
            this.usern.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usern.Location = new System.Drawing.Point(145, 25);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(0, 24);
            this.usern.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Usuario:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Horas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inscription.ResumeLayout(false);
            this.inscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos1)).EndInit();
            this.teach.ResumeLayout(false);
            this.teach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCursos2)).EndInit();
            this.myCurses.ResumeLayout(false);
            this.myCurses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.myAccount.ResumeLayout(false);
            this.myAccount.PerformLayout();
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
        private System.Windows.Forms.Button impartir;
        private System.Windows.Forms.DataGridView tablaCursos2;
        private System.Windows.Forms.Button buscarCurProf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cursosImpartidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button retirarse;
        private System.Windows.Forms.Label formAcad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label nac;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label cuprest;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.LinkLabel cambiarCuenta;
        private System.Windows.Forms.Label usern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelCup;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelNac;
        private System.Windows.Forms.Label labelFA;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

