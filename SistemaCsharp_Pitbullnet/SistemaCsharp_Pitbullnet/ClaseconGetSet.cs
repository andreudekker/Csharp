using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCsharp_Pitbullnet
{
    class ClaseconGetSet
    {
       int Nacimiento; // año de nacimiento

   public ClaseconGetSet(int nacimiento) //constructor
  {
      this.Nacimiento = nacimiento; 
  }

  public int Edad
  {
    get { 
        return DateTime.Now.Year - Nacimiento; 
        }
    set {
        Nacimiento = DateTime.Now.Year - value;
        }
  }
    }
}
