using MySql.Data.MySqlClient;

namespace _04_4Oper_Forms_Parametros
{
    public partial class Form1 : Form
    {
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string selectQuery = "SELECT * FROM employees";
                    using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, conn))
                    {
                        using (MySqlDataReader dr = cmdSelect.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string resultado = $"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]} {dr["LastName"]}, Fecha: {dr["BirthDate"]}";
                                lstResultados.Items.Add(resultado);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Consulta errones: {ex.Message}");
                }
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            string birthDate = txtBirthDate.Text;

            DateTime fecha_yyyy_mm_dd;

            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out fecha_yyyy_mm_dd))
            {
                MessageBox.Show("Formato de feccha incorrecto. Usar dd/mm/yy por ejemplo 24/7/84");
            }



            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    //dos formas de hacerlo
                    //1. con formulación de cadenas
                    //string insertQuery = $@"INSERT INTO employees(FirstName, LastName, BirthDate)
                    //                        VALUES ('{firstName}', '{lastName}','{birthDate}')"; //ojo la fecha tien que estar "yyyy-mm-dd"
                    //con parámetros cualificados a posteriori
                    string insertQuery = @"INSERT INTO employees(FirstName, LastName, BirthDate)
                                           VALUES (@FirstName, @LastName, @BirthDate)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", fecha_yyyy_mm_dd);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Inserción correcta" : "No se pudo insertar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Consulta errones: {ex.Message}");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDEmployee.Text))
            {
                MessageBox.Show("Por favor, introduce el ID del empleado");
                return;
            }

            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            //string birthDate = txtBirthDate.Text;
            int id = int.Parse(txtIDEmployee.Text);

            DateTime fecha_yyyy_mm_dd;

            if (!DateTime.TryParseExact(txtBirthDate.Text, "d/M/yy", null, System.Globalization.DateTimeStyles.None, out fecha_yyyy_mm_dd))
            {
                MessageBox.Show("Formato de feccha incorrecto. Usar dd/mm/yy por ejemplo 24/7/84");
            }



            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
 
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE employees
                                           SET Firstname = @FirstName, LastName = @LastName, BirthDate = @BirthDate
                                           WHERE EmployeeID = @EmployeeID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", fecha_yyyy_mm_dd);
                        cmd.Parameters.AddWithValue("@EmployeeID", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Modificación con éxito" : "No se pudo modificar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Consulta errones: {ex.Message}");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
 
            int id = int.Parse(txtIDEmployee.Text);

            if (string.IsNullOrEmpty(txtIDEmployee.Text))
            {
                MessageBox.Show("Por favor, introduce el ID del empleado");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM employees WHERE EmployeeID = @EmployeeID";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", id);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        MessageBox.Show(filasAfectadas > 0 ? "Borrado con éxito" : "No se pudo borrar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Consulta errones: {ex.Message}");
                }
            }

        }
    }
}
