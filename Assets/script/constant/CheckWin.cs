using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin
{
    private int[] winerPosition;

    public enum WinString
    {
        DiagLeft, DiagRight,
        Hori1, Hori2, Hori3,
        Vert1, Vert2, Vert3,
        Non,
    }

    public WinString Check(int[] winerposition)
    {
        winerPosition = winerposition;

        if (winerPosition[0] != 0 && winerPosition[0] == winerPosition[4] &&
            winerPosition[4] == winerPosition[8]) return WinString.DiagLeft;
        if (winerPosition[2] != 0 && winerPosition[2] == winerPosition[4] &&
            winerPosition[4] == winerPosition[6]) return WinString.DiagRight;

        for (int i = 0; i < 9; i += 3)
        {
            if (winerPosition[i] != 0 && winerPosition[i] == winerPosition[i + 1] &&
                winerPosition[i + 1] == winerPosition[i + 2])
            {
                if (i == 0) return WinString.Hori1;
                if (i == 3) return WinString.Hori2;
                if (i == 6) return WinString.Hori3;
            }
        }

        for (int i = 0; i < 3; i += 1)
        {
            if (winerPosition[i] != 0 && winerPosition[i] == winerPosition[i + 3] &&
                winerPosition[i + 3] == winerPosition[i + 6])
            {
                if (i == 0) return WinString.Vert1;
                if (i == 1) return WinString.Vert2;
                if (i == 2) return WinString.Vert3;
            }
        }

        return WinString.Non;
    }
}