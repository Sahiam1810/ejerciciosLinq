using ejerciciosLinq.utils;
using ejerciciosLinq.Data;

Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("Ejercicios de LINQ con C#\n");
Console.WriteLine("\n-----------------------------\n");

// Obtener las listas de datos
var videojuegos = DatosEjercicio.ObtenerVideojuegos();
var estudiantes = DatosEjercicio.ObtenerEstudiantes();
var equipos = DatosEjercicio.ObtenerEquipos();

// Crear instancia de la clase con los ejercicios
var ejercicios = new LinqQueries(videojuegos, estudiantes, equipos);

// Llamar a cada ejercicio para mostrar su resultado

ejercicios.MultijugadoresNombres();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.EstudiantesAprobados();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.EquiposGolesFavor();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.NombresVideojuegos();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.NombreYCurso();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.EquiposDiferenciaGol();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.RankingVideojuegos();
  Console.WriteLine("\n-----------------------------\n");
ejercicios.RankingEstudiantes();
