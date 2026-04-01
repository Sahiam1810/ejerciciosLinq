using System;

using ejerciciosLinq.models;
namespace ejerciciosLinq.Data;

// Clase estática que provee las listas de datos 
public static class DatosEjercicio
{
    // Lista de videojuegos
    public static List<Videojuego> ObtenerVideojuegos() => new()
    {
        new Videojuego { Nombre = "Minecraft", Genero = "Sandbox", Puntos = 95, EsMultijugador = true  },
        new Videojuego { Nombre = "FIFA", Genero = "Deportes", Puntos = 88, EsMultijugador = true  },
        new Videojuego { Nombre = "Celeste", Genero = "Plataformas", Puntos = 92, EsMultijugador = false },
        new Videojuego { Nombre = "Mario Kart", Genero = "Carreras", Puntos = 90, EsMultijugador = true  },
        new Videojuego { Nombre = "Hollow Knight", Genero = "Aventura", Puntos = 94, EsMultijugador = false },
    };

    // Lista de estudiantes
    public static List<Estudiante> ObtenerEstudiantes() => new()
    {
        new Estudiante { Nombre = "Ana", Edad = 12, Nota = 4.8, Curso = "6A" },
        new Estudiante { Nombre = "Luis", Edad = 13, Nota = 3.2, Curso = "6A" },
        new Estudiante { Nombre = "Marta", Edad = 12, Nota = 4.5, Curso = "6B" },
        new Estudiante { Nombre = "Carlos", Edad = 14, Nota = 2.9, Curso = "6B" },
        new Estudiante { Nombre = "Sofía", Edad = 13, Nota = 5.0, Curso = "6A" },
    };

    // Lista de equipos
    public static List<Equipo> ObtenerEquipos() => new()
    {
        new Equipo { Nombre = "Tigres FC", Puntos = 15, GolesFavor = 12, GolesContra = 6  },
        new Equipo { Nombre = "Leones FC", Puntos = 22, GolesFavor = 18, GolesContra = 10 },
        new Equipo { Nombre = "Águilas FC", Puntos = 19, GolesFavor = 10, GolesContra = 5  },
        new Equipo { Nombre = "Toros FC", Puntos = 8,  GolesFavor = 6, GolesContra = 14 },
    };
}

