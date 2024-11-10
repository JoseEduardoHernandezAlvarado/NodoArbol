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
            this.txtMeter = new System.Windows.Forms.TextBox();
            this.btnInsetar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
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
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Simulador de Árbol Binario de Búsqueda";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMenu.Location = new System.Drawing.Point(45, 64);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(57, 22);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menú";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Navy;
            this.lblMensaje.Location = new System.Drawing.Point(144, 190);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(25, 24);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "...";
            this.lblMensaje.Visible = false;
            // 
            // txtMeter
            // 
            this.txtMeter.Location = new System.Drawing.Point(148, 227);
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.Size = new System.Drawing.Size(100, 20);
            this.txtMeter.TabIndex = 10;
            this.txtMeter.Visible = false;
            // 
            // btnInsetar
            // 
            this.btnInsetar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsetar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsetar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInsetar.Location = new System.Drawing.Point(38, 101);
            this.btnInsetar.Name = "btnInsetar";
            this.btnInsetar.Size = new System.Drawing.Size(75, 28);
            this.btnInsetar.TabIndex = 2;
            this.btnInsetar.Text = "Insertar";
            this.btnInsetar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEliminar.Location = new System.Drawing.Point(38, 273);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar un nodo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.Location = new System.Drawing.Point(38, 319);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar un nodo";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.Location = new System.Drawing.Point(38, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 28);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salida";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreOrden.Enabled = false;
            this.btnPreOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPreOrden.Location = new System.Drawing.Point(38, 135);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(75, 40);
            this.btnPreOrden.TabIndex = 3;
            this.btnPreOrden.Text = "Recorrido preorden";
            this.btnPreOrden.UseVisualStyleBackColor = false;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPostOrden.Enabled = false;
            this.btnPostOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPostOrden.Location = new System.Drawing.Point(38, 181);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(75, 40);
            this.btnPostOrden.TabIndex = 4;
            this.btnPostOrden.Text = "Recorrido PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = false;
            // 
            // btnInOrden
            // 
            this.btnInOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInOrden.Enabled = false;
            this.btnInOrden.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInOrden.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInOrden.Location = new System.Drawing.Point(38, 227);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(75, 40);
            this.btnInOrden.TabIndex = 5;
            this.btnInOrden.Text = "Recorrido Inorden";
            this.btnInOrden.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.btnInsetar);
            this.Controls.Add(this.txtMeter);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMeter;
        private System.Windows.Forms.Button btnInsetar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnInOrden;
    }
}

