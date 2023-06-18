using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject krest;
    [SerializeField] private GameObject nolik;
    [SerializeField] private Button click;
    [SerializeField] private int index;

    void Start()
    {
        ClearPoint();
        click.onClick.AddListener(() =>
        {
            Debug.Log(index);
        });
    }

    public void ClearPoint()
    {
        krest.SetActive(false);
        nolik.SetActive(false);
    }
}
