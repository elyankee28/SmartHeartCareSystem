﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
  public  class Da_AntecedentesPersonales
    {


      public static bool Insert(EntidadesLayer.Ent_AntecedentesPersonales entAntecedentes)
      {
          bool flag = false;

          try
          {
              


              SqlCommand command = new SqlCommand("Spr_Insert_AntecedentesPersonales", Da_Connection.Get);
          command.CommandType = CommandType.StoredProcedure;

          Da_Connection.Get.Open();


          //command.Parameters.Add(new SqlParameter("@IDHistorial", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@InfartoMiocardioPrevio", entAntecedentes.InfartoMiocardioPrevio) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@InsuficienciaCardiaca", entAntecedentes.InsuficienciaCardiaca) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@HipertensionArterial", entAntecedentes.HipertensionArterial) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Valvulopatia", entAntecedentes.Valvulopatia) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Arritmia", entAntecedentes.Arritmia) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@DiabetisMellitas", entAntecedentes.DiabetisMellitas) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadRenal", entAntecedentes.EnfermedadRenal) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadHepatica", entAntecedentes.EnfermedadHepatica) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadPulmonar", entAntecedentes.EnfermedadPulmonar) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Tiroides", entAntecedentes.Tiroides) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@ACV", entAntecedentes.ACV) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@ASMA", entAntecedentes.ASMA) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Gastritis", entAntecedentes.Gastritis) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@UlceraPeptica", entAntecedentes.UlceraPeptica) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Amigdalitis", entAntecedentes.Amigdalitis) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@DoloresCronicosCabeza", entAntecedentes.DoloresCronicosCabeza) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadesRinon", entAntecedentes.EnfermedadesRinon) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Convulsiones", entAntecedentes.Convulsiones) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@SentidoDevilOlfato", entAntecedentes.SentidoDevilOlfato) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Obesidad", entAntecedentes.Obesidad) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadesHigado", entAntecedentes.EnfermedadesHigado) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@EnfermedadesTransmisionSexual", entAntecedentes.EnfermedadesTransmisionSexual) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Cancer", entAntecedentes.Cancer) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Alergias", entAntecedentes.Alergias) { SqlDbType = SqlDbType.Bit });
          command.Parameters.Add(new SqlParameter("@Descripcion", entAntecedentes.Descripcion) { SqlDbType = SqlDbType.NVarChar });

          command.ExecuteNonQuery();

              flag = true;
          }
          finally
          {

              if (Da_Connection.Get.State != ConnectionState.Closed)
              {
                  Da_Connection.Get.Close();
              }

          }

        return flag;

      }



      public void Update(EntidadesLayer.Ent_AntecedentesPersonales entAntecedentes)
      {

          try
          {

              SqlCommand command = new SqlCommand("Spr_Update_AntecedentesPersonales", Da_Connection.Get);
              command.CommandType = CommandType.StoredProcedure;

              Da_Connection.Get.Open();

              command.Parameters.Add(new SqlParameter("@IDHistorial", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@InfartoMiocardioPrevio", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@InsuficienciaCardiaca", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@HipertensionArterial", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Valvulopatia", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Arritmia", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@DiabetisMellitas", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadRenal", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadHepatica", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadPulmonar", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Tiroides", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@ACV", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@ASMA", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Gastritis", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@UlceraPeptica", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Amigdalitis", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@DoloresCronicosCabeza", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadesRinon", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Convulsiones", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@SentidoDevilOlfato", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Obesidad", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadesHigado", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@EnfermedadesTransmisionSexual", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Cancer", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });
              command.Parameters.Add(new SqlParameter("@Alergias", entAntecedentes.IDhistorial) { SqlDbType = SqlDbType.Bit });

              command.ExecuteNonQuery();

          }
          finally
          {

              if (Da_Connection.Get.State != ConnectionState.Closed)
              {
                  Da_Connection.Get.Close();
              }

          }


      }


    }
}
