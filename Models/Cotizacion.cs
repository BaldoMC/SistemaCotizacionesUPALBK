using System;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Cotizaciones.Models
{

    /// <summary>
    /// Clase que representa a una cotizacion en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Cotizacion
    {
        public int ID { get; set; }
        public string nombreCliente{get ; set; }
        public string nombreProductor{get ; set; }
        public DateTime fechaCreacion {get; set; }
        public DateTime fechaValidez{get; set; }
        public string descripcion{get; set; }
        public int costo{get; set; }
        public int total {get; set; }
        public string estado{get; set; }

        public int PersonaID {get;set; }
        [ForeignKey("PersonaID")]
        public Persona persona {get; set;}

    }
}