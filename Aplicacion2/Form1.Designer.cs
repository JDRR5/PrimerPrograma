namespace Aplicacion2
{
    partial class PRIMER_FORM
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
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.Txt_NUMERO = new System.Windows.Forms.TextBox();
            this.GroupBoxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_ID = new System.Windows.Forms.Label();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.TXT_CORREO = new System.Windows.Forms.TextBox();
            this.LBL_CORREO = new System.Windows.Forms.Label();
            this.LBL_TELEFONO = new System.Windows.Forms.Label();
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.GroupBoxInfoPersonal.SuspendLayout();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtInfo
            // 
            this.TxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInfo.Location = new System.Drawing.Point(448, 56);
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(217, 38);
            this.TxtInfo.TabIndex = 0;
            this.TxtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInfo_KeyPress);
            // 
            // Txt_NUMERO
            // 
            this.Txt_NUMERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NUMERO.Location = new System.Drawing.Point(449, 37);
            this.Txt_NUMERO.Name = "Txt_NUMERO";
            this.Txt_NUMERO.Size = new System.Drawing.Size(218, 38);
            this.Txt_NUMERO.TabIndex = 1;
            this.Txt_NUMERO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NUMERO_KeyPress_1);
            // 
            // GroupBoxInfoPersonal
            // 
            this.GroupBoxInfoPersonal.Controls.Add(this.LBL_NAME);
            this.GroupBoxInfoPersonal.Controls.Add(this.txt_Nombre);
            this.GroupBoxInfoPersonal.Controls.Add(this.LBL_ID);
            this.GroupBoxInfoPersonal.Controls.Add(this.TxtInfo);
            this.GroupBoxInfoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxInfoPersonal.Location = new System.Drawing.Point(55, 6);
            this.GroupBoxInfoPersonal.Name = "GroupBoxInfoPersonal";
            this.GroupBoxInfoPersonal.Size = new System.Drawing.Size(690, 198);
            this.GroupBoxInfoPersonal.TabIndex = 2;
            this.GroupBoxInfoPersonal.TabStop = false;
            this.GroupBoxInfoPersonal.Text = "INFORMACIÓN PERSONAL";
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.AutoSize = true;
            this.LBL_NAME.Location = new System.Drawing.Point(200, 131);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(233, 31);
            this.LBL_NAME.TabIndex = 3;
            this.LBL_NAME.Text = "Nombre Completo";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(448, 131);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(217, 38);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Location = new System.Drawing.Point(280, 59);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(117, 31);
            this.LBL_ID.TabIndex = 1;
            this.LBL_ID.Text = "N° de ID";
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.TXT_CORREO);
            this.groupBoxContacto.Controls.Add(this.LBL_CORREO);
            this.groupBoxContacto.Controls.Add(this.LBL_TELEFONO);
            this.groupBoxContacto.Controls.Add(this.Txt_NUMERO);
            this.groupBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContacto.Location = new System.Drawing.Point(54, 210);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(690, 171);
            this.groupBoxContacto.TabIndex = 3;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "CONTACTO";
            // 
            // TXT_CORREO
            // 
            this.TXT_CORREO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CORREO.Location = new System.Drawing.Point(449, 91);
            this.TXT_CORREO.Name = "TXT_CORREO";
            this.TXT_CORREO.Size = new System.Drawing.Size(218, 38);
            this.TXT_CORREO.TabIndex = 5;
            this.TXT_CORREO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_CORREO_KeyPress);
            // 
            // LBL_CORREO
            // 
            this.LBL_CORREO.AutoSize = true;
            this.LBL_CORREO.Location = new System.Drawing.Point(204, 98);
            this.LBL_CORREO.Name = "LBL_CORREO";
            this.LBL_CORREO.Size = new System.Drawing.Size(239, 31);
            this.LBL_CORREO.TabIndex = 4;
            this.LBL_CORREO.Text = "Correo Electrónico";
            // 
            // LBL_TELEFONO
            // 
            this.LBL_TELEFONO.AutoSize = true;
            this.LBL_TELEFONO.Location = new System.Drawing.Point(211, 44);
            this.LBL_TELEFONO.Name = "LBL_TELEFONO";
            this.LBL_TELEFONO.Size = new System.Drawing.Size(195, 31);
            this.LBL_TELEFONO.TabIndex = 4;
            this.LBL_TELEFONO.Text = "N° de Teléfono";
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCELAR.Location = new System.Drawing.Point(166, 387);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(188, 64);
            this.BTN_CANCELAR.TabIndex = 4;
            this.BTN_CANCELAR.Text = "CANCELAR";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(452, 387);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(188, 64);
            this.BTN_ACEPTAR.TabIndex = 5;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = true;
            // 
            // PRIMER_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_ACEPTAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.groupBoxContacto);
            this.Controls.Add(this.GroupBoxInfoPersonal);
            this.Name = "PRIMER_FORM";
            this.Text = "Form1";
            this.GroupBoxInfoPersonal.ResumeLayout(false);
            this.GroupBoxInfoPersonal.PerformLayout();
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.TextBox Txt_NUMERO;
        private System.Windows.Forms.GroupBox GroupBoxInfoPersonal;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.Label LBL_ID;
        private System.Windows.Forms.Label LBL_NAME;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox TXT_CORREO;
        private System.Windows.Forms.Label LBL_CORREO;
        private System.Windows.Forms.Label LBL_TELEFONO;
        private System.Windows.Forms.Button BTN_CANCELAR;
        private System.Windows.Forms.Button BTN_ACEPTAR;
    }
}

