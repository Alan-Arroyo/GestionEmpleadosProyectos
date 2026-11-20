namespace GestionEmpleadosProyectos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCargoEmpleado;
        private System.Windows.Forms.TextBox txtCorreoEmpleado;
        private System.Windows.Forms.Button btnInsertarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;

        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cmbEstadoProyecto;
        private System.Windows.Forms.Button btnInsertarProyecto;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.DataGridView dgvProyectos;

        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.TextBox txtRolProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacion;
        private System.Windows.Forms.Button btnAsignarParticipacion;
        private System.Windows.Forms.Button btnEliminarParticipacion;
        private System.Windows.Forms.DataGridView dgvParticipaciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCargoEmpleado = new System.Windows.Forms.TextBox();
            this.txtCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.btnInsertarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();

            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.btnInsertarProyecto = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();

            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.txtRolProyecto = new System.Windows.Forms.TextBox();
            this.dtpFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.btnAsignarParticipacion = new System.Windows.Forms.Button();
            this.btnEliminarParticipacion = new System.Windows.Forms.Button();
            this.dgvParticipaciones = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipaciones)).BeginInit();
            this.SuspendLayout();

            this.txtNombreEmpleado.Location = new System.Drawing.Point(20, 20);
            this.txtNombreEmpleado.PlaceholderText = "Nombre empleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(160, 23);

            this.txtCargoEmpleado.Location = new System.Drawing.Point(190, 20);
            this.txtCargoEmpleado.PlaceholderText = "Cargo";
            this.txtCargoEmpleado.Size = new System.Drawing.Size(140, 23);

            this.txtCorreoEmpleado.Location = new System.Drawing.Point(340, 20);
            this.txtCorreoEmpleado.PlaceholderText = "Correo";
            this.txtCorreoEmpleado.Size = new System.Drawing.Size(180, 23);

            this.btnInsertarEmpleado.Location = new System.Drawing.Point(530, 19);
            this.btnInsertarEmpleado.Size = new System.Drawing.Size(120, 25);
            this.btnInsertarEmpleado.Text = "Agregar Empleado";
            this.btnInsertarEmpleado.Click += new System.EventHandler(this.btnInsertarEmpleado_Click);

            this.btnEliminarEmpleado.Location = new System.Drawing.Point(660, 19);
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(120, 25);
            this.btnEliminarEmpleado.Text = "Eliminar Empleado";
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);

            this.dgvEmpleados.Location = new System.Drawing.Point(20, 52);
            this.dgvEmpleados.Size = new System.Drawing.Size(760, 120);

            this.txtNombreProyecto.Location = new System.Drawing.Point(20, 190);
            this.txtNombreProyecto.PlaceholderText = "Nombre proyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(180, 23);

            this.dtpFechaInicio.Location = new System.Drawing.Point(210, 190);
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 23);

            this.cmbEstadoProyecto.Items.AddRange(new object[] { "Activo", "En progreso", "Finalizado" });
            this.cmbEstadoProyecto.Location = new System.Drawing.Point(360, 190);
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(130, 23);

            this.btnInsertarProyecto.Location = new System.Drawing.Point(530, 189);
            this.btnInsertarProyecto.Size = new System.Drawing.Size(120, 25);
            this.btnInsertarProyecto.Text = "Agregar Proyecto";
            this.btnInsertarProyecto.Click += new System.EventHandler(this.btnInsertarProyecto_Click);

            this.btnEliminarProyecto.Location = new System.Drawing.Point(660, 189);
            this.btnEliminarProyecto.Size = new System.Drawing.Size(120, 25);
            this.btnEliminarProyecto.Text = "Eliminar Proyecto";
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);

            this.dgvProyectos.Location = new System.Drawing.Point(20, 222);
            this.dgvProyectos.Size = new System.Drawing.Size(760, 120);

            this.cmbEmpleado.Location = new System.Drawing.Point(20, 360);
            this.cmbEmpleado.Size = new System.Drawing.Size(160, 23);

            this.cmbProyecto.Location = new System.Drawing.Point(190, 360);
            this.cmbProyecto.Size = new System.Drawing.Size(160, 23);

            this.txtRolProyecto.Location = new System.Drawing.Point(360, 360);
            this.txtRolProyecto.PlaceholderText = "Rol en proyecto";
            this.txtRolProyecto.Size = new System.Drawing.Size(130, 23);

            this.dtpFechaAsignacion.Location = new System.Drawing.Point(500, 360);
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(120, 23);

            this.btnAsignarParticipacion.Location = new System.Drawing.Point(630, 359);
            this.btnAsignarParticipacion.Size = new System.Drawing.Size(75, 25);
            this.btnAsignarParticipacion.Text = "Asignar";
            this.btnAsignarParticipacion.Click += new System.EventHandler(this.btnAsignarParticipacion_Click);

            this.btnEliminarParticipacion.Location = new System.Drawing.Point(710, 359);
            this.btnEliminarParticipacion.Size = new System.Drawing.Size(70, 25);
            this.btnEliminarParticipacion.Text = "Quitar";
            this.btnEliminarParticipacion.Click += new System.EventHandler(this.btnEliminarParticipacion_Click);

            this.dgvParticipaciones.Location = new System.Drawing.Point(20, 392);
            this.dgvParticipaciones.Size = new System.Drawing.Size(760, 130);

            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtCargoEmpleado);
            this.Controls.Add(this.txtCorreoEmpleado);
            this.Controls.Add(this.btnInsertarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.dgvEmpleados);

            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cmbEstadoProyecto);
            this.Controls.Add(this.btnInsertarProyecto);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.dgvProyectos);

            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.txtRolProyecto);
            this.Controls.Add(this.dtpFechaAsignacion);
            this.Controls.Add(this.btnAsignarParticipacion);
            this.Controls.Add(this.btnEliminarParticipacion);
            this.Controls.Add(this.dgvParticipaciones);

            this.Name = "Form1";
            this.Text = "Gestión de Empleados y Proyectos";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}