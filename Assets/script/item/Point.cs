using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject krest;
    [SerializeField] private GameObject nolik;
    [SerializeField] private Button _click;
    [SerializeField] private int index;

    void Start()
    {
        _click.onClick.AddListener(() =>
        {
            Debug.Log(index);
        });
    }
}
