using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Ejer1.Models
{
    public class Alunmo
    {
        #region Propiedades 
        public int AlunmoId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public string Carnet { get; set; }
        public string Apellidos { get; set; }
        public int CantidadMaterias { get; set; }
        public int Ciclo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreCompleto { get; set; }
        #endregion Propiedades

        #region Constructor 
        public Alunmo(string nombres, int edad, string apellidos, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Edad = edad;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            NombreCompleto = $"{Nombres} {Apellidos}";
        }
        #endregion Constructor

        #region Funciones 
        public bool EsMayorDeEdad()
        {
            return Edad > 18;
        }
        #endregion Funciones 
    }
}