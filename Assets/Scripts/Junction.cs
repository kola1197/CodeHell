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
