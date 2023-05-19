using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace TP4BIS.Models
{
public class Pais
{
    
    public string Nombre {get; private set;}
    public string imgBandera {get; private set;}
    public int Poblacion {get; private set;}
    public DateOnly FechaIndependencia{get; private set;}
    public string AtractivosTuristicos {get; private set;}

    public Pais(string nom, string imgBan,int pob, DateOnly F_I, string atrac)
    {
        Nombre = nom;
        imgBandera = imgBan;
        Poblacion = pob;
        FechaIndependencia = F_I;
        AtractivosTuristicos = atrac;
    }
}

}

