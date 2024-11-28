using BD_Basico.Data;
using BD_Basico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD_Basico.Controllers
{
    public class ClientesController : Controller
    {
        //Instancia privada de solo lectura
        private readonly AplicacionBDContext contexto;
        public ClientesController(AplicacionBDContext context)
        {
            this.contexto = context;
        }

        //Get Clientes
        //REalizara una tarea asinccrona (asyn task)
        public async Task<IActionResult> Index()
        {
            //Retornamos a la vista el listado de los clientes asincronicamente
            return View(await contexto.Clientes.ToListAsync());
        }

        //Get Clientes/Crear
        //No recibe parametros pero retorna la vista
        public IActionResult Crear()
        {
            return View();
        }


        //Post Clientes/Crear
        //Segunda funcion Crear que realiza una tartea asincrona que recibe como parametros el enlace de los campos del objeto cliente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("Nit,Empresa,Direccion,Telefono,Ciudad")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                contexto.Add(cliente);
                await contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
        
    }
}
