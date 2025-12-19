
namespace _06_CRUD_dgv_lineas.Views
{
    partial class FormEditEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblBirthDate = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(14, 20);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(14, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Apellidos:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(14, 105);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(128, 20);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "Fecha nacimiento:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 16);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(228, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(149, 59);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(228, 27);
            txtLastName.TabIndex = 4;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(149, 101);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(137, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(149, 153);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 153);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 195);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblBirthDate);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEditEmployee";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
