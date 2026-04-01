using System;
using System.Collections.Generic;
using System.Linq;

namespace ejerciciosLinq.models;

public class Estudiante
{
    public string Nombre { get; set; } = string.Empty;
    public int Edad { get; set; }
    public double Nota { get; set; }
    public string Curso { get; set; } = string.Empty;
}