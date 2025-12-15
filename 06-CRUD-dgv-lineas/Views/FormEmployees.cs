using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_CRUD_dgv_lineas.Models;
using _06_CRUD_dgv_lineas.Controllers;

namespace _06_CRUD_dgv_lineas.Views
{
    public partial class FormEmployees : Form
    {
        private readonly EmployeeController empCtl = new EmployeeController();

        public FormEmployees()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new FormEditEmployee())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarDatos();
        }
        // establecer las columnas del dgv
        private void ConfigurarGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();

            // columna de botón editar
            var colEdit = new DataGridViewImageColumn();
            colEdit.Name = "btnModify";
            colEdit.HeaderText = "Modificar";
            colEdit.Width = 50;
            dgvEmployees.Columns.Add(colEdit);

            // columna de botón borrar
            var colDelete = new DataGridViewImageColumn();
            colDelete.Name = "btnDelete";
            colDelete.HeaderText = "Borrar";
            colDelete.Width = 50;
            dgvEmployees.Columns.Add(colDelete);

            // Columna oculta ID
            var colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "EmployeeID";
            colId.Name = "EmployeeID";
            colId.Visible = false;
            dgvEmployees.Columns.Add(colId);

            // Nombre
            var colFirstName = new DataGridViewTextBoxColumn();
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "Nombre";
            dgvEmployees.Columns.Add(colFirstName);

            // Apellidos
            var colLastName = new DataGridViewTextBoxColumn();
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Apellidos";
            dgvEmployees.Columns.Add(colLastName);

            // Fecha nacimiento
            var colBirth = new DataGridViewTextBoxColumn();
            colBirth.DataPropertyName = "BirthDate";
            colBirth.HeaderText = "Fecha nacimiento";
            dgvEmployees.Columns.Add(colBirth);

        }
        private void CargarDatos() 
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = empCtl.GetAll();
        }
    }
}
