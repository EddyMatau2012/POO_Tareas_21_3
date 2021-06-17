using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Heroe;
    public string Name;
    public float vida;
    public float speed;

    Basemestiza Bsmestiza;

    private void start()
    {
        Bsmestiza = GameObject.FindObjectOfType<Basemestiza>();
        {
            SubirInfo(Heroe);
        }

        
    
        



    }

    void SubirInfo(int id)
    {
        for (int i = 0; i < Bsmestiza.NuevoJugador.Length;i++)
        {
            if (Bsmestiza.NuevoJugador[i].Heroe==id)
            {
                this.Name=Bsmestiza.NuevoJugador[i].Nombre;
                this.vida=Bsmestiza.NuevoJugador[i].Vida;
                this.speed=Bsmestiza.NuevoJugador[i].velocidad;
            }
            
        }
    }
}
