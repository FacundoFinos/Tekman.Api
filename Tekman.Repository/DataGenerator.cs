using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tekman.Repository.Models;

namespace Tekman.Repository
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TekmanDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<TekmanDBContext>>()))
            {
                context.ActividadTipo.AddRange(
                    new Models.ActividadTipo
                    {
                        Tipo = "Prueba",
                        Ponderacion = 0.4m
                    },
                    new Models.ActividadTipo
                    {
                        Tipo = "Ejercicio",
                        Ponderacion = 0.2m
                    },
                    new Models.ActividadTipo
                    {
                        Tipo = "Actividad",
                        Ponderacion = 0.3m
                    },
                    new Models.ActividadTipo
                    {
                        Tipo = "Autoevaluación",
                        Ponderacion = 0.1m
                    });

                context.Pregunta.AddRange(
                    new Models.Pregunta { 
                        Id =1,
                        Descripcion = "¿Quien descubrió America?"
                    },
                    new Models.Pregunta
                    {
                        Id = 2,
                        Descripcion = "¿Que tiene mas tamaño, un terabyte o un gigabyte?"
                    }
                    );

                context.PreguntaRespuesta.AddRange(
                    new Models.PreguntaRespuesta { 
                        IdPregunta = 1,
                        RespuestaCorecta = "Cristobal Colon"
                    },
                    new Models.PreguntaRespuesta
                    {
                        IdPregunta = 2,
                        RespuestaCorecta = "terabyte"
                    });

                context.Ejercicio.AddRange(
                    new Models.Ejercicio
                    {
                        Id = 1,
                        Nombre = "Test 1",
                        Preguntas = new List<Pregunta>()
                    });

                context.Ejercicio.Find(1).Preguntas.Add(context.Pregunta.Find(1));
                context.SaveChanges();
            }
        }
    }
}
