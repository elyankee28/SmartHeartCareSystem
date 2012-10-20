﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinesLogicLayer;
using EntidadesLayer;
using System.Xml;


namespace aPresentationLayer
{
    public partial class Frm_Pacientes : DevExpress.XtraEditors.XtraForm
    {
          //Entidades
                    Ent_Paciente paciente = new Ent_Paciente();
                    Ent_Direcciones direcciones = new Ent_Direcciones();
                    Ent_Telefono telefonos = new Ent_Telefono();
                    Ent_Contacto contacto = new Ent_Contacto();

        private static Frm_Pacientes frm_pacientes; // Referencia estática al mismo formulario

        public static Frm_Pacientes frm_Pacientes() // Método estatico que hace referencia a el mismo
        {
            if (frm_pacientes == null || frm_pacientes.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_pacientes = new Frm_Pacientes(); // Se crea instancia
            }
            else
            {
                frm_pacientes.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_pacientes; // Retornamos el valor
        }//fin del metodo

        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //Limpio los Txt
            Bl_AdministrarControles.VaciarText(frm_pacientes);
            
            //Limpio los DatagriedView
            Bl_AdministrarControles.VaciarDGV(frm_pacientes);

            //Habilitos los Txt
            Bl_AdministrarControles.HabilitarText(frm_pacientes);

            //Habilitos los Txt
            Bl_AdministrarControles.HabilitarDGV(frm_pacientes);

            //obtengo el siguiente ID que se va a generar de Paciente
            txtIDPaciente.Text = Bl_Paciente.ObtenerIDPacienteMax().ToString();

            //Deshabilito el CampoIDPaciente
            txtIDPaciente.Enabled = false;

            //Paso el Foco Al Nombre
            txtNombres.Focus();
         
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Valores Entidad Paciente
            paciente.IDPaciente = txtIDPaciente.Text;
            paciente.Nombres = txtNombres.Text;
            paciente.Apellidos = txtApellidos.Text;
            paciente.IDTipoIdentifacion = cmbTipoIdentificacion.SelectedIndex;
            paciente.Identificacion = txtIdentificacion.Text;
            paciente.FechaNacimiento = txtFechaNacimiento.Value;
            paciente.IDNivelAcademico = cmbNivelAcademico.SelectedIndex;
            paciente.IDOcupacion = cmbOcupacion.SelectedIndex;
            paciente.Genero = Convert.ToChar(cmbGenero.Text);
            paciente.EstadoCivil = Convert.ToChar(cmbEstadoCivil.Text);
            paciente.TipoSangre = Convert.ToChar(cmbTipoSangre.Text);
            paciente.TipoPaciente = cmbTipoPaciente.SelectedIndex;
            paciente.NSS = txtNSS.Text;
            paciente.Email = txtEmail.Text;
            paciente.IDNacionalidad = cmbNacionalidad.SelectedIndex;
            paciente.IDPais = cmbPais.SelectedIndex;
            paciente.IDRegion = cmbRegion.SelectedIndex;
            paciente.IDSector = cmbRegion.SelectedIndex;
            paciente.FechaIngrero = txtFechaIngreso.Value;
            paciente.Peso = txtPeso.Value;
            paciente.Altura = txtAltura.Value;
            paciente.Activo = chkActivo.Checked;
            paciente.EnvioEmail = chkEnviarEmail.Checked;
            paciente.Observaciones = txtObservaciones.Text;

            //Valores Entidad Direcciones

            for (int i = 0; i < dtgDirecciones.RowCount - 2; i++)
            {
                direcciones.IDPaciente = Convert.ToInt32(txtIDPaciente.Text);
                direcciones.Direccion = dtgDirecciones.Rows[i].Cells[0].ToString();
            }
         
           

          




            //    Bl_Paciente.Insert(paciente, direcciones, telefonos, contacto);
               


            //Limpio los Txt
            Bl_AdministrarControles.VaciarText(frm_pacientes);

            //Limpio los DatagriedView
            Bl_AdministrarControles.VaciarDGV(frm_pacientes);
            
            //Deshabilito los Txt
            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

            //Deshabilito los Datagried
            Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

    }
}