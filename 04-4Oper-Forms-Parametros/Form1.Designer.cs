namespace _04_4Oper_Forms_Parametros
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
            btnInsertar = new Button();
            label1 = new Label();
            txtIDEmployee = new TextBox();
            lstResultados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtBirthDate = new TextBox();
            btnConsultar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(183, 116);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtIDEmployee
            // 
            txtIDEmployee.Location = new Point(12, 72);
            txtIDEmployee.Name = "txtIDEmployee";
            txtIDEmployee.Size = new Size(63, 23);
            txtIDEmployee.TabIndex = 2;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(32, 198);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(558, 139);
            lstResultados.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 32);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 32);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 32);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento:";
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(266, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(398, 72);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.PlaceholderText = "dd/mm/aa";
            txtBirthDate.Size = new Size(100, 23);
            txtBirthDate.TabIndex = 9;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(282, 116);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(282, 159);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(183, 159);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnConsultar);
            Controls.Add(txtBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstResultados);
            Controls.Add(txtIDEmployee);
            Controls.Add(label1);
            Controls.Add(btnInsertar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Label label1;
        private TextBox txtIDEmployee;
        private ListBox lstResultados;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtBirthDate;
        private Button btnConsultar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}
