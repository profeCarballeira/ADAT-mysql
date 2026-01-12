namespace _07_CRUD_navegacion.Views
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblIndice = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            txtIndiceSalto = new TextBox();
            btnIrAIndice = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 113);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 160);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha nacimiento";
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Cursor = Cursors.SizeNESW;
            lblIndice.Location = new Point(244, 231);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(50, 20);
            lblIndice.TabIndex = 4;
            lblIndice.Text = "0 de 0";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(216, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(29, 27);
            txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(216, 106);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(270, 27);
            txtApellidos.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(216, 153);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(270, 27);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(98, 218);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(67, 47);
            btnPrimero.TabIndex = 11;
            btnPrimero.Text = "|<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(171, 218);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(67, 47);
            btnAnterior.TabIndex = 12;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(332, 218);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(67, 47);
            btnSiguiente.TabIndex = 13;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(419, 218);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(67, 47);
            btnUltimo.TabIndex = 14;
            btnUltimo.Text = ">|";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // txtIndiceSalto
            // 
            txtIndiceSalto.Location = new Point(244, 274);
            txtIndiceSalto.Name = "txtIndiceSalto";
            txtIndiceSalto.Size = new Size(47, 27);
            txtIndiceSalto.TabIndex = 15;
            // 
            // btnIrAIndice
            // 
            btnIrAIndice.Location = new Point(312, 271);
            btnIrAIndice.Name = "btnIrAIndice";
            btnIrAIndice.Size = new Size(61, 30);
            btnIrAIndice.TabIndex = 16;
            btnIrAIndice.Text = "Ir a";
            btnIrAIndice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 330);
            Controls.Add(btnIrAIndice);
            Controls.Add(txtIndiceSalto);
            Controls.Add(btnUltimo);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(btnPrimero);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(lblIndice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblIndice;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private Button button1;
        private Button btnPrimero;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnUltimo;
        private TextBox txtIndiceSalto;
        private Button btnIrAIndice;
    }
}
