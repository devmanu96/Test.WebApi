using System;
using System.Collections.Generic;

namespace TestWebApi.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }
}
