using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace GestionEmpleadosProyectos
{
    public class RepositorioSistema
    {
        private readonly string _connectionString;

        public RepositorioSistema(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_insertar_empleado", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@p_cargo", empleado.Cargo);
            cmd.Parameters.AddWithValue("@p_correo", empleado.Correo);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Empleado> SeleccionarEmpleados()
        {
            var lista = new List<Empleado>();
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_seleccionar_empleados", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Empleado
                {
                    IdEmpleado = reader.GetInt32("id_empleado"),
                    Nombre = reader.GetString("nombre"),
                    Cargo = reader.GetString("cargo"),
                    Correo = reader.GetString("correo")
                });
            }
            return lista;
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_eliminar_empleado", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_id_empleado", idEmpleado);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertarProyecto(Proyecto proyecto)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_insertar_proyecto", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_nombre_proyecto", proyecto.NombreProyecto);
            cmd.Parameters.AddWithValue("@p_fecha_inicio", proyecto.FechaInicio.Date);
            cmd.Parameters.AddWithValue("@p_estado", proyecto.Estado);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Proyecto> SeleccionarProyectos()
        {
            var lista = new List<Proyecto>();
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_seleccionar_proyectos", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Proyecto
                {
                    IdProyecto = reader.GetInt32("id_proyecto"),
                    NombreProyecto = reader.GetString("nombre_proyecto"),
                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                    Estado = reader.GetString("estado")
                });
            }
            return lista;
        }

        public void EliminarProyecto(int idProyecto)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_eliminar_proyecto", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_id_proyecto", idProyecto);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void InsertarParticipacion(Participacion participacion)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_insertar_participacion", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_id_empleado", participacion.IdEmpleado);
            cmd.Parameters.AddWithValue("@p_id_proyecto", participacion.IdProyecto);
            cmd.Parameters.AddWithValue("@p_rol_en_proyecto", participacion.RolEnProyecto);
            cmd.Parameters.AddWithValue("@p_fecha_asignacion", participacion.FechaAsignacion.Date);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public List<Participacion> SeleccionarParticipaciones()
        {
            var lista = new List<Participacion>();
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_seleccionar_participaciones", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Participacion
                {
                    IdParticipacion = reader.GetInt32("id_participacion"),
                    IdEmpleado = reader.GetInt32("id_empleado"),
                    NombreEmpleado = reader.GetString("empleado"),
                    IdProyecto = reader.GetInt32("id_proyecto"),
                    NombreProyecto = reader.GetString("proyecto"),
                    RolEnProyecto = reader.GetString("rol_en_proyecto"),
                    FechaAsignacion = reader.GetDateTime("fecha_asignacion")
                });
            }
            return lista;
        }

        public void EliminarParticipacion(int idParticipacion)
        {
            using var conn = new MySqlConnection(_connectionString);
            using var cmd = new MySqlCommand("sp_eliminar_participacion", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_id_participacion", idParticipacion);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}