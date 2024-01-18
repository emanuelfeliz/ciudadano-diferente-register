using System;
using System.Collections.Generic;

namespace CiudadanoDiferente.Models;

public partial class Miembro
{
    public int VotanteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? ColegioElectoral { get; set; }

    public string Cedula { get; set; } = null!;

    public string? Recinto { get; set; }
}
