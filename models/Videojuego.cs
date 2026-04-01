using System;
using System.Collections.Generic;
using System.Linq;

namespace ejerciciosLinq.models;

public class Videojuego
{
    public string Nombre { get; set; } = "";
    public string Genero { get; set; } = "";
    public int Puntos { get; set; }
    public bool EsMultijugador { get; set; }
}