using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor 
{
    /*Los contructores no requieren "Start" ni "Update"
     Atributos o Propiedades
    + = Público 
     - = Privado*/
    // Start is called before the first frame update
     public int IdPlayer;
     public string Nombre;
     public float Vida;
     public float velocidad;
     private Transform posicion;
     private int daño;

     public Constructor (int Id, string name, float life, float speed)
          {
               //Al constructor se le darán parámetros para poder asignar argumentos ()
        //Parametros:Elementos que me van a pedir los métodos para poder hacer funcionar su acción / evento
              this.IdPlayer = Id;
              this.Nombre= name;
              this.Vida= life;
              this.velocidad = speed;


          }

    public int Heroe { get; internal set; }
}
