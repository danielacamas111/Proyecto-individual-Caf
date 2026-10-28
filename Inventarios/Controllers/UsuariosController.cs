using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventarios.Models;

namespace Inventarios.Controllers;

public class UsuariosController : Controller
{
    private readonly InventarioContext _context;

    public UsuariosController(InventarioContext context)
    {
        _context = context;
    }

    // GET: /Usuarios
    public async Task<IActionResult> Index()
    {
        var usuarios = await _context.Usuarios.AsNoTracking().ToListAsync();
        // Aquí le decimos explícitamente que cargue la vista "Seguridad.cshtml"
        return View("Seguridad", usuarios);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}