using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    private Tile[,] Tiles = new Tile[6,2];

    private int rowNumbers = 2;
    private int columnNumbers = 6;

    [SerializeField] private Transform[] gridParentTransform;
    
    public void CreateTiles()
    {
        foreach (var gridParent in gridParentTransform)
        {
            for (var i = 0; i < rowNumbers; i++)
            {
                for (var j = 0; j < columnNumbers; j++)
                {
                    Tiles[i, j] = Instantiate(tilePrefab, gridParent).Initialize(i, j);
                }
            }
        }
    }
}