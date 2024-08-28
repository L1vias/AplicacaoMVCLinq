using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteContrller : Controller
    {
        public IActionResult index()
        {

            return View();
        }

        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Livia", "Livia@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(2, "Bea", "Bea@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c3 = new Cliente(3, "Ana Julia", "anajulia@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c4 = new Cliente(4, "Ana Clara", "anaclara@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c5 = new Cliente(5, "Levi", "levi@example.com", "1234-5678", new DateOnly(2000, 6, 1));

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);
            return View();
        }
    }
}
