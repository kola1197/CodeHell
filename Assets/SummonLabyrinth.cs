using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonLabyrinth : MonoBehaviour
{
    public Junction.ConnectSide type;
    private Labyrinth _labyrinthSystem;
    private bool _isListStashed = false;
    private List<int> _stashedTileList;
    
    public bool HasStashedList => _isListStashed;

    public List<int> StashedList
    {
        get
        {
            if (_isListStashed)
            {
                return _stashedTileList;
            }
            else
            {
                throw new Exception("No list stashed");
            }
        }
    }
    private void Start()
    {
        _labyrinthSystem = FindObjectOfType<Labyrinth>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player")) _labyrinthSystem.DrawTileCards(type, transform);
    }

    public void StashList(List<int> listToStash)
    {
        _stashedTileList = listToStash;
        _isListStashed = true;
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player")) _labyrinthSystem.CloseUi();
    }

    private void OnTriggerStay(Collider other)
    {
        switch (type)
        {
            
        }
    }
}
