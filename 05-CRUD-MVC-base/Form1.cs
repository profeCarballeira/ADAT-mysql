using _05_CRUD_MVC_base.Controllers;
using _05_CRUD_MVC_base.Models;


namespace _05_CRUD_MVC_base
{
    public partial class Form1 : Form
    {
        private readonly EmplyeeController controladorEmp = new EmplyeeController();
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = controladorEmp.GetAll();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
