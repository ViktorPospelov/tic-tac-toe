using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin
{
    private int[] winerPosition;

    public bool Check(int[] winerposition)
    {
        winerPosition = winerposition;
        
        
        if (CheckHorizon()) return true;

        if (CheckVertical()) return true;
        
        return false;
    }

    private bool CheckHorizon()
    {
        for (int i = 0; i < 9; i += 3)
        {
            if (winerPosition[i] != 0 && winerPosition[i] == winerPosition[i + 1] &&
                winerPosition[i + 1] == winerPosition[i + 2]) return true;
        }

        return false;
    }

    private bool CheckVertical()
    {
        for (int i = 0; i < 3; i += 1)
        {
            if (winerPosition[i] != 0 && winerPosition[i] == winerPosition[i + 3] &&
                winerPosition[i + 3] == winerPosition[i + 6]) return true;
        }

        return false;
    }
}