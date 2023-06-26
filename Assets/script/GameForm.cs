using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameForm : MonoBehaviour
{
    [SerializeField] private GameObject[] points;

    private int[] polyaPosition = new []{0,0,0,0,0,0,0,0,0};
    private CheckWin _checkWin = new CheckWin();
    
    public static Action<int> Click;
    public static bool IsKrest => isKrest;
    private static bool isKrest = true;
    void Start()
    {
        Click += OnClick;
    }

    private void OnClick(int nuberPolya)
    {
        polyaPosition[nuberPolya] = isKrest ? 1 : 2;
        Debug.Log(_checkWin.Check(polyaPosition));
        
        isKrest = !isKrest;
    }

    
    void Update()
    {
    }
}