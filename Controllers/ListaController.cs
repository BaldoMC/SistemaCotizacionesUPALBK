using System;
using Microsoft.AspNetCore.Mvc;
using Cotizaciones.Models;
using Cotizaciones.Data;
using System.Collections.Generic;
using System.Linq;
using Cotizaciones.Services;

namespace Cotizaciones.Controllers{
    public class ListaController : Controller{
        private readonly CotizacionesContext _context;
        CotizacionesRepository repo;
        
        public ListaController(CotizacionesContext context){
            _context = context;
            repo = new CotizacionesRepository(context);
        }
        
        public IActionResult Index()
        {
            var cotizaciones = repo.ObtenerCotizaciones(185075958);
            return View(cotizaciones);
        }

        
        

    }
}