using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junction : MonoBehaviour
{
    public enum ConnectSide
    {
        North,
        South,
        West,
        East
    }

    public Transform north;
    public Transform south;
    public Transform west;
    public Transform east;

    private bool _isNorthAvailable = true;
    private bool _isSouthAvailable = true;
    private bool _isWestAvailable = true;
    private bool _isEastAvailable = true;

    public Vector3 SidePosition(ConnectSide side)
    {
        var result = this.transform.position;
            switch (side)
            {
                case ConnectSide.North:
                    result = north.position;
                    break;
                case ConnectSide.South:
                    result = south.position;
                    break;
                case ConnectSide.East:
                    result = east.position;
                    break; 
                case ConnectSide.West:
                    result = west.position;
                    break;
            }
            return result;
    }
    public Vector3 SideDelta(ConnectSide side)
    {
        var result = this.transform.position;
        switch (side)
        {
            case ConnectSide.North:
                result -= north.position;
                break;
            case ConnectSide.South:
                result -= south.position;
                break;
            case ConnectSide.East:
                result -= east.position;
                break; 
            case ConnectSide.West:
                result -= west.position;
                break;
        }

        return result;
    }

    private void Start()
    {
        if (north == null) _isNorthAvailable = false;
        if (south == null) _isSouthAvailable = false;
        if (east == null) _isEastAvailable = false;
        if (west == null) _isWestAvailable = false;
    }

    public List<ConnectSide> GetAvailableSides()
    {
        var result = new List<ConnectSide>();
        if (_isNorthAvailable) result.Add(ConnectSide.North);
        if (_isSouthAvailable) result.Add(ConnectSide.South);
        if (_isWestAvailable) result.Add(ConnectSide.West);
        if (_isEastAvailable) result.Add(ConnectSide.East);
        return result;
    }

    public bool IsAvailable(ConnectSide side)
    {
        switch (side)
        {
            case ConnectSide.North: return _isNorthAvailable;
            case ConnectSide.South: return _isSouthAvailable;
            case ConnectSide.East: return _isEastAvailable;
            case ConnectSide.West: return _isWestAvailable;
        }

        return false;
    }
    
    public static ConnectSide OppositeSide(ConnectSide side)
    {
        var result = side;
        switch (side)
        {
            case ConnectSide.North:
                result = ConnectSide.South;
                break;
            case ConnectSide.South:
                result = ConnectSide.North;
                break;
            case ConnectSide.East:
                result = ConnectSide.West;
                break; 
            case ConnectSide.West:
                result = ConnectSide.East;
                break;
        }

        return result;
    }
    public void ConnectTo(ConnectSide side)
    {
        var delta = SideDelta(side);
        this.transform.position += delta;
    }
    

}
