namespace FirebaseDeAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEpisodio = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtEmitido = new System.Windows.Forms.TextBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Episodios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duracion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Emitido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(212, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(212, 93);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(143, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(212, 147);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(143, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtEpisodio
            // 
            this.txtEpisodio.Location = new System.Drawing.Point(212, 202);
            this.txtEpisodio.Name = "txtEpisodio";
            this.txtEpisodio.Size = new System.Drawing.Size(143, 20);
            this.txtEpisodio.TabIndex = 9;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(212, 259);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(143, 20);
            this.txtDuracion.TabIndex = 10;
            // 
            // txtEmitido
            // 
            this.txtEmitido.Location = new System.Drawing.Point(212, 315);
            this.txtEmitido.Name = "txtEmitido";
            this.txtEmitido.Size = new System.Drawing.Size(143, 20);
            this.txtEmitido.TabIndex = 11;
            // 
            // btInsertar
            // 
            this.btInsertar.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertar.Location = new System.Drawing.Point(511, 65);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(107, 31);
            this.btInsertar.TabIndex = 12;
            this.btInsertar.Text = "&Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(511, 136);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(107, 31);
            this.btBuscar.TabIndex = 13;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.Location = new System.Drawing.Point(511, 205);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(107, 31);
            this.btActualizar.TabIndex = 14;
            this.btActualizar.Text = "&Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Papyrus", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(511, 276);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(107, 31);
            this.btEliminar.TabIndex = 15;
            this.btEliminar.Text = "&Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 389);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.txtEmitido);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtEpisodio);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lista de animes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEpisodio;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtEmitido;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

