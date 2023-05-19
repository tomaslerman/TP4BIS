using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace TP4BIS.Models
{
 public static class Info
{
   private static List<Pais> ListaPaises {get; set;}= new List<Pais>();


   private static void InicializarLista()
   {
    ListaPaises.Add(new Pais ("Argentina",  "Bandera-de-Argentina.png.webp",	45808747,new DateOnly(1916,07,16), "Cataratas del Iguazú"));
    ListaPaises.Add(new Pais ("Jamaica",  "Bandera_Jamaica.png", 2900000,new DateOnly(1962,08,06), "Montego Bay"));
    ListaPaises.Add(new Pais ("Brasil",  "bandera_Brasil.png",213900000,new DateOnly(1822,09,07), "Cristo Redentor"));
    ListaPaises.Add(new Pais ("Chile",  "Bandera_Chile.png",19100000,new DateOnly(1810,9,18), "Parque Nacional Torres del Paine"));
    ListaPaises.Add(new Pais ("Estados Unidos",  "Bandera_EstadosUnidos.png",331400000,new DateOnly(1776,7,4), "Gran Cañón"));
   }
   
   public static List<Pais> ListarPaises(){
      if (ListaPaises.Count == 0) InicializarLista();
      return ListaPaises;
   }
   public static Pais DetallePais(string Nombre)
   {
      
      Pais paisBuscado = null;
      foreach (var item in ListaPaises)
      {
         if(item.Nombre == Nombre)
         {
            
            paisBuscado = item;
            
         } 
      }
    return paisBuscado;
  
   }

}  
}
