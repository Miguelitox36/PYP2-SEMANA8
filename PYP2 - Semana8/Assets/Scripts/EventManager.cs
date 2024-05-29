using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager 
{
    private List<Opcion> opcions;
    private Player player;

    public EventManager(List<Opcion> opcions, Jugador player)
    {
        this.opcions = opcions;
        this.player = player;
    }

    public void Interactuar()
    {
        // Implementa la lógica para mostrar diálogos y opciones, y manejar las selecciones del jugador.
    }
}
