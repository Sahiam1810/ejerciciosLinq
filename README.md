# Taller_Linq_Esteban_Sahiam
## Taller de LINQ en C# — 15 Ejercicios

Aplicación de consola en **C#** que implementa 15 ejercicios progresivos de **LINQ** (_Language Integrated Query_), organizados en 5 bloques temáticos que van de lo básico hasta un reto final combinado.

---

## Descripción

El taller trabaja sobre tres colecciones de objetos — videojuegos, estudiantes y equipos — y aplica los operadores LINQ más importantes para filtrar, transformar, ordenar, consultar y agrupar datos en memoria.

---

## Estructura del proyecto

```
ejerciciosLinq/
├── Models/
│   ├── Videojuego.cs       - modelo con Nombre, Genero, Puntos, EsMultijugador
│   ├── Estudiante.cs       - modelo con Nombre, Edad, Nota, Curso
│   └── Equipo.cs           - modelo con Nombre, Puntos, GolesFavor, GolesContra
├── Data/
│   └── DatosEjercicio.cs   - las 3 listas con datos de prueba
├── Utils/
│   └── LinqQueries.cs      - los 15 ejercicios LINQ
└── Program.cs              - llama los 15 métodos en orden
```

---

## Operadores LINQ practicados

| Operador | Para qué sirve |
|----------|---------------|
| `Where` | Filtrar elementos que cumplen una condición |
| `Select` | Proyectar o transformar cada elemento |
| `OrderByDescending` | Ordenar de mayor a menor |
| `ThenByDescending` | Segundo criterio de ordenamiento |
| `Count` | Contar elementos que cumplen una condición |
| `Any` | Verificar si existe al menos un elemento |
| `FirstOrDefault` | Obtener el primer elemento o null |
| `GroupBy` | Agrupar elementos por una clave común |

---

## Ejercicios del taller

### Bloque 1 — Filtrar (`Where`)
| # | Ejercicio |
|---|-----------|
| 01 | Nombres de videojuegos multijugador |
| 02 | Estudiantes aprobados (nota >= 3.0) |
| 03 | Equipos con buen ataque (GF > 10) |

### Bloque 2 — Transformar (`Select`)
| # | Ejercicio |
|---|-----------|
| 04 | Solo nombres de todos los videojuegos |
| 05 | Cada estudiante en formato `Nombre - Curso` |
| 06 | Diferencia de gol por equipo |

### Bloque 3 — Ordenar (`OrderBy`, `ThenBy`)
| # | Ejercicio |
|---|-----------|
| 07 | Ranking de videojuegos por puntos |
| 08 | Ranking de estudiantes por nota |
| 09 | Tabla de posiciones con desempate por goles |

### Bloque 4 — Consultas rápidas (`Count`, `Any`, `FirstOrDefault`)
| # | Ejercicio |
|---|-----------|
| 10 | Contar videojuegos con más de 90 puntos |
| 11 | Verificar si existe algún reprobado |
| 12 | Obtener el mejor equipo de la tabla |

### Bloque 5 — Agrupar y combinar (`GroupBy`)
| # | Ejercicio |
|---|-----------|
| 13 | Agrupar estudiantes por curso |
| 14 | Agrupar videojuegos por género y contar |
| 15 | **Reto final** — `Where` + `OrderBy` + `Select` combinados |

---

## Cómo ejecutar

### Requisitos
- .NET SDK 10.0 o superior


### Pasos

**1. Clona el repositorio**
```bash
git clone https://github.com/Sahiam1810/ejercicios-csharp.git
cd ejerciciosLinq
```

**2. Ejecuta el proyecto**
```bash
dotnet run
```

---

## Ejemplo de salida

```

-----------------------------

Ejercicio 01 — Videojuegos multijugador
Minecraft
FIFA
Mario Kart

-----------------------------

Ejercicio 02 — Estudiantes aprobados
Ana - 4.8
Luis - 3.2
Marta - 4.5
Sofía - 5

-----------------------------

Ejercicio 03 — Equipos con más de 10 goles a favor
Tigres FC - GF: 12
Leones FC - GF: 18

-----------------------------

```

---

## Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET 10.0
- **Tipo:** Aplicación de consola
- **Consultas:** LINQ (Language Integrated Query)

---

## Autor

**Sahiam1810**
[github.com/Sahiam1810](https://github.com/Sahiam1810)