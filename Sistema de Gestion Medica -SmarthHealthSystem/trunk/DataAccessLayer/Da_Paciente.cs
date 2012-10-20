﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Da_Paciente
    {

        public static bool Insert(Ent_Paciente EntidadPaciente) 
        {
            bool flag = false;
            
            try
            {
                //conecction = new DAConecction();
                SqlCommand command = new SqlCommand("Spr_InsertPersona", Da_Connection.Get);
                command.CommandType = CommandType.StoredProcedure;

                Da_Connection.Get.Open();

                //Paso los valores para la tabla Pacientes.
                command.Parameters.Add(new SqlParameter("@Nombres", EntidadPaciente.Nombres) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Apellidos", EntidadPaciente.Apellidos) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@IDTipoIdentifacion", EntidadPaciente.IDTipoIdentifacion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Identificacion", EntidadPaciente.Identificacion) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@NSS", EntidadPaciente.NSS) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@FechaNacimiento", EntidadPaciente.FechaNacimiento) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@NivelAcademico", EntidadPaciente.IDNivelAcademico) { SqlDbType = SqlDbType.Int});
                command.Parameters.Add(new SqlParameter("@FechaIngrero", EntidadPaciente.FechaIngrero) { SqlDbType = SqlDbType.Date });
                command.Parameters.Add(new SqlParameter("@Sexo", EntidadPaciente.Genero) { SqlDbType = SqlDbType.NChar });
                command.Parameters.Add(new SqlParameter("@EstadoCivil", EntidadPaciente.EstadoCivil) { SqlDbType = SqlDbType.NChar });
                command.Parameters.Add(new SqlParameter("@Nacionalidad", EntidadPaciente.IDNacionalidad) { SqlDbType = SqlDbType.Int});
                command.Parameters.Add(new SqlParameter("@IDPais", EntidadPaciente.IDPais) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDProvincia", EntidadPaciente.IDProvincia) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDRegion", EntidadPaciente.IDRegion) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@IDSector", EntidadPaciente.IDSector) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@Email", EntidadPaciente.Email) { SqlDbType = SqlDbType.DateTime });
                command.Parameters.Add(new SqlParameter("@Observaciones", EntidadPaciente.Observaciones) { SqlDbType = SqlDbType.NVarChar });
                command.Parameters.Add(new SqlParameter("@Peso", EntidadPaciente.Peso) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Altura", EntidadPaciente.Altura) { SqlDbType = SqlDbType.Decimal });
                command.Parameters.Add(new SqlParameter("@Activo", EntidadPaciente.Activo) { SqlDbType = SqlDbType.Bit });
                command.Parameters.Add(new SqlParameter("@EnvioMail", EntidadPaciente.EnvioEmail) { SqlDbType = SqlDbType.Bit });
                command.Parameters.Add(new SqlParameter("@TipoPaciente", EntidadPaciente.TipoPaciente) { SqlDbType = SqlDbType.Int });
                command.Parameters.Add(new SqlParameter("@TipoSangre", EntidadPaciente.TipoSangre) { SqlDbType = SqlDbType.NChar});
                //Ejecuto el Query
                command.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            } // end catch
            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }
            
            }


            return flag;
        
        }
        public bool Update() 
        
        {

            bool flag = false;

            return flag;
        
        }
        public bool Delete() 
        
        {
            bool flag = false;

            return flag;
        
        }
        public bool Search()
        
        {
            bool flag = false;

            return flag;
        
        }
        public static int ObtenerIDPacienteMax()
        {
            try
            {

                SqlCommand ObjCmd = new SqlCommand("SELECT MAX(IDPaciente) FROM Paciente ", Da_Connection.Get);
                ObjCmd.CommandType = CommandType.Text;
                Da_Connection.Get.Open();

                var dr = ObjCmd.ExecuteReader();
                while (dr.Read())
                {
                    return dr.GetInt32(0) + 1;//obtengo el ultimo registro y le sumo uno para visualizarlo en el frmPacientes

                }
            }

            finally
            {

                if (Da_Connection.Get.State != ConnectionState.Closed)
                {
                    Da_Connection.Get.Close();
                }

            }
            return 0;
        }
    }
}
