using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basemestiza : MonoBehaviour
{
    public Constructor [] NuevoJugador;
    void Awake ()
    {
        NuevoJugador = new Constructor [2];
        NuevoJugador [0] = new Constructor (1, "Percy Jackson", 100,50);
        NuevoJugador [1] = new Constructor (2, "Annabeth Chase", 100,50);
    }
}
