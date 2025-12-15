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

namespace _06_CRUD_dgv_lineas.Views
{
    public partial class FormEditEmployee : Form
    {
        public Employee EmployeeResult { get; private set; }

        // Constructor para AÑADIR
        //public FormEditEmployee() : this(null)
        //{
        //}

        // Constructor para MODIFICAR (para AÑADIR sin parámetros)
        public FormEditEmployee(Employee? emp = null)
        {
            InitializeComponent();

            if (emp == null)
            {
                EmployeeResult = new Employee();
            }
            else
            {
                EmployeeResult = emp;
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                dtpBirthDate.Value = emp.BirthDate;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EmployeeResult.FirstName = txtFirstName.Text;
            EmployeeResult.LastName = txtLastName.Text;
            EmployeeResult.BirthDate = dtpBirthDate.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
