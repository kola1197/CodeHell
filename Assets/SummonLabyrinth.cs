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
        if (other.transform.CompareTag("Player"))
        {
            if (CheckAvailable())
                Destroy(this);
            else
                _labyrinthSystem.DrawTileCards(type, transform);
        }
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

    private bool CheckAvailable()
    {
        Vector3 deltaVector = new Vector3();
        switch (type)
        {
            case Junction.ConnectSide.North:
                deltaVector = new Vector3(0, 0, 1);
                break;
            case Junction.ConnectSide.South:
                deltaVector = new Vector3(0, 0, -1);
                break;
            case Junction.ConnectSide.East:
                deltaVector = new Vector3(1, 0, 0);
                break;
            case Junction.ConnectSide.West:
                deltaVector = new Vector3(-1, 0, 0);
                break;
        }

        return Physics.CheckSphere(transform.position + deltaVector, 1.0f, LayerMask.NameToLayer("Environment"),
            QueryTriggerInteraction.Ignore);


    }
}
