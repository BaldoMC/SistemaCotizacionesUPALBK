using System;
using Cotizaciones.Models;
using System.Collections.Generic;
using System.Linq;
using Cotizaciones.Data;

/// <summary>
/// Archivo donde se definen las querys de la base de datos
/// </summary>
namespace Cotizaciones.Services{

    /// <summary>
    /// Clase que representa a las consultas que se realizaran a la base de datos
    /// </summary>

    public class CotizacionesRepository{
        public List<Cotizacion> ObtenerTodos(int rutPer){
            using (var context = new CotizacionesContext()){
                var cotizaciones = context.Cotizaciones
                .Where (b => b.PersonaRut.Equals(rutPer))
                .ToList();

                return cotizaciones;
            }
        }
    }
}