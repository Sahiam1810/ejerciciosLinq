using ejerciciosLinq.utils;
using ejerciciosLinq.Data;

Console.WriteLine("Ejercicios de LINQ con C#\n");

// Obtener las listas de datos
var videojuegos = DatosEjercicio.ObtenerVideojuegos();
var estudiantes = DatosEjercicio.ObtenerEstudiantes();
var equipos = DatosEjercicio.ObtenerEquipos();

// Crear instancia de la clase con los ejercicios
var ejercicios = new LinqQueries(videojuegos, estudiantes, equipos);

// Llamar a cada ejercicio para mostrar su resultado

ejercicios.MultijugadoresNombres();
