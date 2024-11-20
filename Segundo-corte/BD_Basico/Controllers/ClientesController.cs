using BD_Basico.Data;
using BD_Basico.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD_Basico.Controllers
{
    public class ClientesController : Controller
    {
        //instancia privada de solo lectura
        private readonly AplicacionBDContext contexto;
        //Constructor
        public ClientesController(AplicacionBDContext context)
        {
            contexto = context;
        }

        // GET: Clientes
        //Realizara una tarea (Task) asincrona (asyn)
        public async Task<IActionResult> Index()
        {
            return View(await contexto.Clientes.ToListAsync());
        }
        // GET: Clientes/Crear
        public IActionResult Crear()
        {
            return View();
        }
        //Funciuon crear que realiza una tarea asincrona que recibe como parametros el enlace de los campos del objeto cliente
        // POST: Clientes/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("Nit,Empresa,Direccion,Telefono,Ciudad")]
Cliente cliente)
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
