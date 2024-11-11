namespace NodoArbol
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.CajaDTexto = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(248, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(518, 32);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Simulador de Árbol Binario de Búsqueda";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMenu.Location = new System.Drawing.Point(914, 63);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(57, 22);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menú";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Navy;
            this.lblMensaje.Location = new System.Drawing.Point(295, 368);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(21, 19);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "...";
            // 
            // CajaDTexto
            // 
            this.CajaDTexto.Location = new System.Drawing.Point(769, 292);
            this.CajaDTexto.Name = "CajaDTexto";
            this.CajaDTexto.Size = new System.Drawing.Size(100, 20);
            this.CajaDTexto.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsertar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInsertar.Location = new System.Drawing.Point(907, 100);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 28);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEliminar.Location = new System.Drawing.Point(907, 272);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar un nodo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.Location = new System.Drawing.Point(907, 318);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar un nodo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.Location = new System.Drawing.Point(907, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salida";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPreOrden.Location = new System.Drawing.Point(907, 134);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(75, 40);
            this.btnPreOrden.TabIndex = 3;
            this.btnPreOrden.Text = "Recorrido preorden";
            this.btnPreOrden.UseVisualStyleBackColor = false;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPostOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPostOrden.Location = new System.Drawing.Point(907, 180);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(75, 40);
            this.btnPostOrden.TabIndex = 4;
            this.btnPostOrden.Text = "Recorrido PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = false;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInOrden.Location = new System.Drawing.Point(907, 226);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(75, 40);
            this.btnInOrden.TabIndex = 5;
            this.btnInOrden.Text = "Recorrido Inorden";
            this.btnInOrden.UseVisualStyleBackColor = false;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 486);
            this.Controls.Add(this.btnInOrden);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.CajaDTexto);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox CajaDTexto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

