using _07_CRUD_navegacion.Controllers;
using _07_CRUD_navegacion.Models;
using Google.Protobuf;

namespace _07_CRUD_navegacion.Views
{
    public partial class Form1 : Form
    {

        private readonly EmployeeController empController = new EmployeeController();
        private List<Employee> employees = new List<Employee>();
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                employees = empController.GetAll();
                if (employees != null && employees.Count > 0)
                {
                    currentIndex = 0;
                    ShowCurrentEmployee();
                }
                else
                {
                    //TODO: completar caso de no empleados
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados" + ex.Message);
            }
        }

        private void ShowCurrentEmployee()
        {

            //TODO: si no hya empleados

            var emp = employees[currentIndex];
            txtID.Text = emp.EmployeeID.ToString();
            txtNombre.Text = emp.FirstName;
            txtApellidos.Text = emp.LastName;
            dtpFechaNacimiento.Value = emp.BirthDate == default ? DateTime.Today : emp.BirthDate;

            UpdateNavigator();

        }

        private void UpdateNavigator()
        {
            if (employees == null || employees.Count == 0)
            {
                //TODO: que lo hagan los becarios
            }
            lblIndice.Text = $"{currentIndex + 1} de {employees.Count}";

            btnPrimero.Enabled = currentIndex > 0;
            btnUltimo.Enabled = currentIndex < employees.Count - 1;
            btnAnterior.Enabled = currentIndex > 0;
            btnSiguiente.Enabled = currentIndex < employees.Count - 1;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0) return;
            //no puedo ir al siguiente si estoy en el último
            if (currentIndex < employees.Count - 1) { 
                currentIndex++;
                ShowCurrentEmployee();
            }
        }
    }
}
