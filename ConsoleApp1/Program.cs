// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        //Ejemplo de entrada
        string[] palabras = {"microsoft", "azure", "developer", "azure", "microsoft", "teams", "developer", "azure"};
        int k =2;

        //Llamada a la función que calcula las k palabras más frecuentes
        var resultado = KPalabrasMasFrecuentes(palabras, k);

        //Salida
        Console.WriteLine($"Las {k} palabras más frecuentes son: {string.Join(", ",resultado)}");
    }

    //Función que devuelve las k palabras más frecuentes
    public static List<string> KPalabrasMasFrecuentes(string[] palabras, int k)
    {
        // Función para contar la frecuencia de cada palabra
        var frecuencia = palabras
            .GroupBy(p => p) // Agrupar la palabra
            .Select(grupo => new { Palabra = grupo.Key, Frecuencia = grupo.Count() })
            .OrderByDescending(p => p.Frecuencia) // Ordenar por frecuencia descendente
            .ThenBy(p => p.Palabra) //Si hay empate, ordenar alfabeticamente
            .Take(k) //Tomar las k palabras mas frecuentes
            .Select(p => p.Palabra) //Seleccionar solo las palabras
            .ToList(); // Convertir a lista

        return frecuencia;
    }
}

