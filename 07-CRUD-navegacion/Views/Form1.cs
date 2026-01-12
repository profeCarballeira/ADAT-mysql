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
                    currentIndex = -1;
                    ClearControls();
                    UpdateNavigator();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados" + ex.Message);
            }
        }

        private void ClearControls()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
        }
        private void ShowCurrentEmployee()
        {
            if (employees == null || employees.Count == 0 || currentIndex < 0 || currentIndex >= employees.Count)
            {
                ClearControls();
                UpdateNavigator();
                return;
            }

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
                lblIndice.Text = "0 de 0";
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;
                btnUltimo.Enabled = false;
                btnSiguiente.Enabled = false;
            }
            lblIndice.Text = $"{currentIndex + 1} de {employees.Count}";

            btnPrimero.Enabled = currentIndex > 0;
            btnUltimo.Enabled = currentIndex < employees.Count - 1;
            btnAnterior.Enabled = currentIndex > 0;
            btnSiguiente.Enabled = currentIndex < employees.Count - 1;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0) return;
            currentIndex = employees.Count - 1;
            ShowCurrentEmployee();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0) return;
            //no puedo ir al siguiente si estoy en el último
            if (currentIndex < employees.Count - 1)
            {
                currentIndex++;
                ShowCurrentEmployee();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0) return;
            currentIndex = 0;
            ShowCurrentEmployee();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0) return;
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowCurrentEmployee();
            }

        }

        private void btnIrAIndice_Click(object sender, EventArgs e)
        {
            //int ind = System.Convert.ToInt32(this.txtIndiceSalto.Text);
            //if ((ind > 0) && (ind <= employees.Count))
            //{
            //    currentIndex = ind - 1;
            //    ShowCurrentEmployee();
            //}
            int ind;
            if (int.TryParse(this.txtIndiceSalto.Text, out ind))
            {
                if (ind > 0 && ind <= employees.Count)
                {
                    currentIndex = ind - 1;
                    ShowCurrentEmployee();
                }
                else
                {
                    MessageBox.Show($"Introduce un número entre 1 y {employees.Count}.");
                }
            }
            else
            {
                MessageBox.Show("Introduce un número válido.");
            }
        }
    }
}
