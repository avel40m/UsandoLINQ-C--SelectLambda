using System.Collections.Generic;
using System;
using System.Linq;

namespace Linq_Alumnos
{
    class Program
    {
        public static List<Alumnos> Obtener()
        {
            List<Alumnos> alumnos = new List<Alumnos>
            {
                new Alumnos{Id = 1,Nombre="Avelino",Apellido="Mendez",Edad=28,Turno="Mañana",Carrera="Profesorado",Promedio=7},
                new Alumnos{Id = 2,Nombre="Hector",Apellido="Lopez",Edad=30,Turno="Tarde",Carrera="Tecnico",Promedio=3},
                new Alumnos{Id = 3,Nombre="Veronica",Apellido="Estevanez",Edad=21,Turno="Mañana",Carrera="Profesorado",Promedio=8},
                new Alumnos{Id = 4,Nombre="Alberto",Apellido="Aranda",Edad=19,Turno="Noche",Carrera="Ingenieria",Promedio=8},
                new Alumnos{Id = 5,Nombre="Mauricio",Apellido="Jpett",Edad=40,Turno="Mañana",Carrera="Licenciatura",Promedio=10},
                new Alumnos{Id = 6,Nombre="Cristina",Apellido="Mendez",Edad=34,Turno="Tarde",Carrera="Ingenieria",Promedio=7},
                new Alumnos{Id = 7,Nombre="Leo",Apellido="Rodriguez",Edad=25,Turno="Mañana",Carrera="Profesorado",Promedio=6},
                new Alumnos{Id = 8,Nombre="Leandro",Apellido="Mendoza",Edad=28,Turno="Tarde",Carrera="Licenciatura",Promedio=5},
                new Alumnos{Id = 9,Nombre="Ana",Apellido="Jefferson",Edad=29,Turno="Tarde",Carrera="Profesorado",Promedio=4},
                new Alumnos{Id = 10,Nombre="Yanina",Apellido="Morales",Edad=32,Turno="Noche",Carrera="Tecnico",Promedio=8},
            };
            return alumnos;
        }
        
        static void Main(string[] args)
        {
            var Estudiantes = Obtener();

            var estudiante = Estudiantes.OrderBy(e => e.Nombre).ThenBy(e => e.Edad).Where(e => e.Promedio <= 5);
            foreach (Alumnos alumnos in estudiante)
            {
                Console.WriteLine("Nombre: {0}, Edad: {1}",alumnos.Nombre,alumnos.Edad);
            }

        }
    }
}
