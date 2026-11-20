using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionEmpleadosProyectos
{
    public partial class Form1 : Form
    {
        private readonly RepositorioSistema _repo;

        public Form1()
        {
            InitializeComponent();
            string cadenaConexion = "Server=localhost;Database=gestion_proyectos_db;Uid=root;Pwd=alan123456;";
            _repo = new RepositorioSistema(cadenaConexion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarTodo()
        {
            var empleados = _repo.SeleccionarEmpleados();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;

            cmbEmpleado.DataSource = null;
            cmbEmpleado.DataSource = empleados;
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "IdEmpleado";

            var proyectos = _repo.SeleccionarProyectos();
            dgvProyectos.DataSource = null;
            dgvProyectos.DataSource = proyectos;

            cmbProyecto.DataSource = null;
            cmbProyecto.DataSource = proyectos;
            cmbProyecto.DisplayMember = "NombreProyecto";
            cmbProyecto.ValueMember = "IdProyecto";

            dgvParticipaciones.DataSource = null;
            dgvParticipaciones.DataSource = _repo.SeleccionarParticipaciones();
        }

        private void btnInsertarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.InsertarEmpleado(new Empleado
                {
                    Nombre = txtNombreEmpleado.Text.Trim(),
                    Cargo = txtCargoEmpleado.Text.Trim(),
                    Correo = txtCorreoEmpleado.Text.Trim()
                });
                RefrescarTodo();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("No se permite registrar un correo duplicado. Este correo ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el empleado: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.CurrentRow?.DataBoundItem is Empleado emp)
                {
                    _repo.EliminarEmpleado(emp.IdEmpleado);
                    RefrescarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                _repo.InsertarProyecto(new Proyecto
                {
                    NombreProyecto = txtNombreProyecto.Text.Trim(),
                    FechaInicio = dtpFechaInicio.Value,
                    Estado = cmbEstadoProyecto.Text.Trim()
                });
                RefrescarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar proyecto: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyectos.CurrentRow?.DataBoundItem is Proyecto proy)
                {
                    _repo.EliminarProyecto(proy.IdProyecto);
                    RefrescarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proyecto: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAsignarParticipacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleado.SelectedValue is int idEmp && cmbProyecto.SelectedValue is int idProy)
                {
                    _repo.InsertarParticipacion(new Participacion
                    {
                        IdEmpleado = idEmp,
                        IdProyecto = idProy,
                        RolEnProyecto = txtRolProyecto.Text.Trim(),
                        FechaAsignacion = dtpFechaAsignacion.Value
                    });
                    RefrescarTodo();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Este empleado ya está asignado a ese proyecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar participación: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarParticipacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParticipaciones.CurrentRow?.DataBoundItem is Participacion part)
                {
                    _repo.EliminarParticipacion(part.IdParticipacion);
                    RefrescarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar participación: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}