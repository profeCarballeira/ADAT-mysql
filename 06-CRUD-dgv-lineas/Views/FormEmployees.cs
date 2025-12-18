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
using _06_CRUD_dgv_lineas.Properties;

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
                    empCtl.Insert(frm.EmployeeResult);
                    CargarDatos();
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
            colEdit.Image = Resources.edit24;
            colEdit.Width = 50;
            dgvEmployees.Columns.Add(colEdit);

            // columna de botón borrar
            var colDelete = new DataGridViewImageColumn();
            colDelete.Name = "btnDelete";
            colDelete.HeaderText = "Borrar";
            colDelete.Image = Resources.delete24;
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

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var fila = dgvEmployees.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["EmployeeID"].Value);

            //Editar
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "btnModify")
            {
                var emp = empCtl.GetById(id);
                if (emp == null) return;

                using (var frm = new FormEditEmployee(emp))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        empCtl.Update(frm.EmployeeResult);
                        CargarDatos();
                    }
                }
                return;
            }

            //Borrar
            if (dgvEmployees.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                if (MessageBox.Show ("¿Deseas borrar este empleado?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes) { 
                    empCtl.Delete(id);
                    CargarDatos();
                }
                return;
            }

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
