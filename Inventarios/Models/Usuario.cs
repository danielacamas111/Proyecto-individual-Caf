using System;
using System.Collections.Generic;

namespace Inventarios.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Rol { get; set; } = null!;
}
