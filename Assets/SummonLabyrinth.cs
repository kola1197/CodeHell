using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonLabyrinth : MonoBehaviour
{
    public Junction.ConnectSide type;
    private Labyrinth _labyrinthSystem;

    private void Start()
    {
        _labyrinthSystem = FindObjectOfType<Labyrinth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player")) _labyrinthSystem.DrawTileCards(type, transform);
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player")) _labyrinthSystem.CloseUi();
    }
}
