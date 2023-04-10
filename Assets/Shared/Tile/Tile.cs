using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private (int row, int column) _position;

    public bool IsOccupied { get; private set; }

    public Tile Initialize(int row, int column)
    {
        _position = (row, column);

        return this;
    }
}
