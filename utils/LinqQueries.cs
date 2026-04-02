using System;

using ejerciciosLinq.models;
namespace ejerciciosLinq.utils;

// Clase que contiene los ejercicios.
public class LinqQueries
{
    // Las tres listas sobre las que se hacen todas las consultas
    private readonly List<Videojuego> _videojuegos;
    private readonly List<Estudiante> _estudiantes;
    private readonly List<Equipo> _equipos;

    public LinqQueries(List<Videojuego> videojuegos, List<Estudiante> estudiantes, List<Equipo> equipos)
    {
        _videojuegos = videojuegos;
        _estudiantes = estudiantes;
        _equipos = equipos;
    }

// EN TOTAL SON 15 EJERCICIOS:

// ---- Bloque 1: filtrar.


    // Ejercicio 1: Mostrar solo los nombres de los videojuegos que sean multijugador.

    public void MultijugadoresNombres()
    {
        Console.WriteLine("Ejercicio 01 — Videojuegos multijugador");

            // Where filtra los multijugador, Select extrae solo el nombre
        var nombres = _videojuegos
            .Where(v => v.EsMultijugador)
            .Select(v => v.Nombre);

        foreach (var nombre in nombres)
            Console.WriteLine(nombre);
    }

    // Ejercicio 2: Mostrar los estudiantes cuya nota sea mayor o igual a 3.0.

    public void EstudiantesAprobados()
    {
        Console.WriteLine("Ejercicio 02 — Estudiantes aprobados");

            // Where conserva solo los estudiantes cuya nota sea >= 3.0
        var aprobados = _estudiantes.Where(e => e.Nota >= 3.0);

        foreach (var e in aprobados)
            Console.WriteLine($"{e.Nombre} - {e.Nota}");
    }

    // Ejercicio 3: Mostrar los equipos que tengan más de 10 goles a favor.

    public void EquiposGolesFavor()
    {
        Console.WriteLine("Ejercicio 03 — Equipos con más de 10 goles a favor");

        // Where filtra los equipos con más de 10 goles a favor
        var resultado = _equipos.Where(e => e.GolesFavor > 10);

        foreach (var e in resultado)
            Console.WriteLine($"{e.Nombre} - GF: {e.GolesFavor}");
    }


// Bloque 2: Transformar.

    // ejercicio 4: Crear una consulta que devuelva solo los nombres de todos los videojuegos.
    public void NombresVideojuegos()
    {
        Console.WriteLine("Ejercicio 04 — Solo nombres de videojuegos");

        // Select proyecta cada objeto Videojuego extrayendo únicamente su Nombre
        var nombres = _videojuegos.Select(v => v.Nombre);

        foreach (var nombre in nombres)
            Console.WriteLine(nombre);
    }

    // Ejercicio 5: Mostrar cada estudiante en formato: `Nombre - Curso`

    public void NombreYCurso()
    {
        Console.WriteLine("Ejercicio 05 — Nombre y curso de cada estudiante");

        // Select transforma cada Estudiante en un string interpolado
        var resumen = _estudiantes.Select(e => $"{e.Nombre} - {e.Curso}");

        foreach (var item in resumen)
            Console.WriteLine(item);
    }


    // Ejercicio 6:  Diferencia de gol, Mostrar para cada equipo: `Nombre - DiferenciaDeGol`, La diferencia de gol se calcula así: ```GolesFavor - GolesContra```
    public void EquiposDiferenciaGol()
    {
        Console.WriteLine("Ejercicio 06 — Diferencia de gol por equipo");

        // Select calcula la diferencia de gol (GF - GC) en la misma consulta
        var resultado = _equipos.Select(e => new
        {
            e.Nombre,
            DiferenciaGol = e.GolesFavor - e.GolesContra
        });

        foreach (var item in resultado)
            Console.WriteLine($"{item.Nombre} - DG: {item.DiferenciaGol}");

    }


// BLOQUE 3: Ordenar.

    // Ejercicio 7: ordenar videojuegos de mayor a menor por puntos.

    public void RankingVideojuegos()
    {
        Console.WriteLine("Ejercicio 07 — Ranking de videojuegos por puntos");

        // OrderByDescending ordena de mayor a menor según Puntos
        var ranking = _videojuegos.OrderByDescending(v => v.Puntos);

        foreach (var v in ranking)
            Console.WriteLine($"{v.Nombre} — {v.Puntos} pts");
    }
}