﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesLayer;
using DataAccessLayer;

namespace BussinesLogicLayer
{
    public class Bl_Contacto
    {

        private static Da_Contacto GetDaContacto()//metodo singleton
        {
            Da_Contacto daContacto = new Da_Contacto();
            return daContacto;
        }


        public static bool Insert(Ent_Contacto entContacto)
        {
            //instancio el metodo
            Da_Contacto daContacto = GetDaContacto();

             //Validaciones De Lugar
            bool flag = false;


            if (string.IsNullOrEmpty(entContacto.Contacto) ||string.IsNullOrEmpty(entContacto.Telefono))

            {
                flag = false;

            }
            else if (Da_Contacto.Insert(entContacto)) 
            {
                flag = true;
            
            }


            return flag;

        }

        public static bool Update(Ent_Contacto entContacto)
        {

            //instancio el metodo
            Da_Contacto daContacto = GetDaContacto();

            //Validaciones De Lugar
            bool flag = false;


            if (entContacto.IDPaciente.Equals(String.Empty) || entContacto.IDContacto.Equals(String.Empty) || entContacto.Telefono.Equals(String.Empty))
            {
                flag = false;

            }
            else if (Da_Contacto.Update(entContacto))
            {
                flag = true;

            }


            return flag;





        }

        public static bool Delete(Ent_Contacto entContacto)
        {
            //instancio el metodo
            Da_Contacto daContacto = GetDaContacto();

            //Validaciones De Lugar
            bool flag = false;


            if (entContacto.IDPaciente.Equals(String.Empty))
            {
                flag = false;

            }
            else if (Da_Contacto.Delete(entContacto))
            {
                flag = true;

            }


            return flag;



        }

        public void Search(Ent_Paciente entPersona)
        {


        }
    }
}
