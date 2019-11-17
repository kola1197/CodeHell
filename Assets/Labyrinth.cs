﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Labyrinth : MonoBehaviour
{

    public int maxTiles = 12;
    private int _tileCount = 0;
    public GameObject[] tilePrefabs;
    public GameObject[] tileButtons;
    public GameObject tileChosingUI;
    
    private bool _isPlayerChoosingTile = false;
    private Transform _pointOfJunction;
    private Junction.ConnectSide _pointOfJunctionType;
    private int[] _tilesHaveNorth = {0, 2, 3, 5, 6, 7 };
    private int[] _tilesHaveSouth = {0, 1, 4, 5, 7, 8 };
    private int[] _tilesHaveWest = {0, 1, 2, 5, 6, 8 };
    private int[] _tilesHaveEast = {0, 3, 4, 6, 7, 8 };
    // Start is called before the first frame update
    void Start()
    {
        foreach (var button in tileButtons)
        {
            button.SetActive(false); 
        }
    }

    private int[] HasSide(Junction.ConnectSide side)
    {
        switch (side)
        {
            case Junction.ConnectSide.North: return _tilesHaveNorth;
            case Junction.ConnectSide.South: return _tilesHaveSouth;
            case Junction.ConnectSide.West: return _tilesHaveWest;
            case Junction.ConnectSide.East: return _tilesHaveEast;
        }

        return new int[0];
    }
    public void OpenUi()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        tileChosingUI.SetActive(true);
    }

    public void CloseUi()
    {
        tileChosingUI.SetActive(false);
        _isPlayerChoosingTile = false;
        _pointOfJunction = null;
        foreach (var button in tileButtons)
        {
            button.SetActive(false); 
        }
    }

    public void DrawTileCards(Junction.ConnectSide type, Transform point)
    {
        Assert.IsNotNull(point);
        OpenUi();
        _isPlayerChoosingTile = true;
        _pointOfJunction = point;
        _pointOfJunctionType = type;
        if (!GameManager.instance.CanWin)
        {
            List<int> tileList;
            if (_pointOfJunction.GetComponent<SummonLabyrinth>().HasStashedList)
            {
                tileList = _pointOfJunction.GetComponent<SummonLabyrinth>().StashedList;
            }
            else
            {
                int[] possibleTiles = HasSide(Junction.OppositeSide(type));
                tileList = new List<int>(possibleTiles);
                while (tileList.Count > 3)
                {
                    tileList.RemoveAt(UnityEngine.Random.Range(0, tileList.Count - 1));
                }

                _pointOfJunction.GetComponent<SummonLabyrinth>().StashList(tileList);

            }

            foreach (var tile in tileList)
            {
                tileButtons[tile].SetActive(true);
            }

            Debug.Log(_pointOfJunction.GetComponent<SummonLabyrinth>().HasStashedList);
        }
        else
        {
            
        }
    }

    public void PlaceTile(int tileNum)
    {
        var newTile = Instantiate(tilePrefabs[tileNum], _pointOfJunction);
        newTile.GetComponent<Junction>().ConnectTo(Junction.OppositeSide(_pointOfJunctionType));
        Destroy(_pointOfJunction.GetComponent<SummonLabyrinth>());
        CloseUi();
        _tileCount++;
    }
    

}
