using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLine : MonoBehaviour
{
    [SerializeField] private GameObject Hori1;
    [SerializeField] private GameObject Hori2;
    [SerializeField] private GameObject Hori3;
    [SerializeField] private GameObject Vert1;
    [SerializeField] private GameObject Vert2;
    [SerializeField] private GameObject Vert3;
    [SerializeField] private GameObject DiagLeft;
    [SerializeField] private GameObject DiagRight;

    public void SetWineLine(CheckWin.WinString line, GameObject WinLineForm)
    {
        switch (line)
        {
            case CheckWin.WinString.Hori1:
                WinLineForm.SetActive(true);
                Hori1.SetActive(true);
                break;
            case CheckWin.WinString.Hori2:
                WinLineForm.SetActive(true);
                Hori2.SetActive(true);
                break;
            case CheckWin.WinString.Hori3:
                WinLineForm.SetActive(true);
                Hori3.SetActive(true);
                break;
            case CheckWin.WinString.Vert1:
                WinLineForm.SetActive(true);
                Vert1.SetActive(true);
                break;
            case CheckWin.WinString.Vert2:
                WinLineForm.SetActive(true);
                Vert2.SetActive(true);
                break;
            case CheckWin.WinString.Vert3:
                WinLineForm.SetActive(true);
                Vert3.SetActive(true);
                break;
            case CheckWin.WinString.DiagLeft:
                WinLineForm.SetActive(true);
                DiagLeft.SetActive(true);
                break;
            case CheckWin.WinString.DiagRight:
                WinLineForm.SetActive(true);
                DiagRight.SetActive(true);
                break;
        }
    }

    public void ClearWinLine()
    { 
        gameObject.SetActive(false);
        Hori1.SetActive(false);
        Hori2.SetActive(false);
        Hori3.SetActive(false);
        Vert1.SetActive(false);
        Vert2.SetActive(false);
        Vert3.SetActive(false);
        DiagLeft.SetActive(false);
        DiagRight.SetActive(false);
    }
}