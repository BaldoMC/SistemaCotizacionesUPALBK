using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Cotizaciones.Models
{

    /// <summary>
    /// Clase que representa a una persona en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
	/// - RUT con guion y digito verificador, con o sin puntos.
	///  Ejemplo de RUTs validos:
	///  18790339-4
	///  18.790.339-4
    /// </remarks>
    public class Persona
    {

        public String Rut { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; } 

        public List<Cotizacion> cotizaciones {get; set;}


        public Persona validate(){
            //validacion de rut
            if(!validarRut(this.Rut)){
                throw new ArgumentException("RUT no valido");
            }
            return this;
        }

    /// <summary>
	/// Metodo de validación de rut con digito verificador
	/// dentro de la cadena
	/// </summary>
	/// <param name="rut">string</param>
	/// <returns>booleano</returns>
        public static Boolean validarRut(String rut){
            rut = rut.Replace(".", "").ToUpper();
		    Regex expresion = new Regex("^([0-9]+-[0-9K])$");
		    string dv = rut.Substring(rut.Length - 1, 1);
    		if (!expresion.IsMatch(rut)) {
			return false;
		}
	    	char[] charCorte = { '-' };
		    string[] rutTemp = rut.Split(charCorte);
    		if (dv != Digito(int.Parse(rutTemp[0]))) {
			return false;
		}
		return true;
        }

        public static string Digito(int rut) {
		int suma = 0;
		int multiplicador = 1;
		while (rut != 0) {
			multiplicador++;
			if (multiplicador == 8)
			multiplicador = 2;
			suma += (rut % 10) * multiplicador;
			rut = rut / 10;
		}
		suma = 11 - (suma % 11);
		if (suma == 11)	{
			return "0";
		} else if (suma == 10) {
			return "K";
		} else {
			return suma.ToString();
		}
	}
    }
}