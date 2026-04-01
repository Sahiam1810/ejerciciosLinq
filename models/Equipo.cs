using System;
using System.Collections.Generic;
using System.Linq;

namespace ejerciciosLinq.models;

public class Equipo
{
    public string Nombre { get; set; } = string.Empty;
    public int Puntos { get; set; }
    public int GolesFavor { get; set; }
    public int GolesContra { get; set; }
}