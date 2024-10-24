using Ejercicio5.Models.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models.DAL
{
    public class ListadoPersonas
    {
        /// <summary>
        /// Funcion que devuelve una lista de personas
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> ObtenerListaPersonas()
        {
            List<clsPersona> listadoPersona = new List<clsPersona>
            {
            new clsPersona("Jesús","García Pereira"),
            new clsPersona("Laura", "Fernández García"),
            new clsPersona("Carlos", "Martínez López"),
            new clsPersona("Lucía", "Sánchez Pérez"),
            new clsPersona("Diego", "Rodríguez Morales"),
            new clsPersona("Elena", "Morales Suárez"),
            new clsPersona("Samuel", "Castaño Gil"),
            new clsPersona("Adriana", "Ruiz Fernández"),
            new clsPersona("Andrés", "Gómez Ramírez"),
            new clsPersona("Sara", "Vázquez Castillo"),
            new clsPersona("Roberto", "Hernández Vega")

            };
            return listadoPersona;
        }



    }
}
