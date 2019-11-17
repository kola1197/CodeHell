using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChain : MonoBehaviour
{
    public Junction.ConnectSide side;
    public GameObject connectingJunction;
    public float connectingTime;
    private bool _passed = false;
    private void Update()
    {
        if (Time.time > connectingTime && !_passed && connectingJunction != null)
        {
            connectingJunction.transform.position =
                this.GetComponent<Junction>().SidePosition(Junction.OppositeSide(side));
            connectingJunction.GetComponent<Junction>().ConnectTo(side);
            _passed = true;
        }
    }
}
