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
        GameForm.Click += Click;
        ClearPoint();
        click.onClick.AddListener(() =>
        {
            Click(index);
            GameForm.Click?.Invoke(index);
        });
    }

    private void Click(int num)
    {
        if(num!= index) return;
        krest.SetActive(GameForm.IsKrest);
        nolik.SetActive(!GameForm.IsKrest);
    }

    public void ClearPoint()
    {
        krest.SetActive(false);
        nolik.SetActive(false);
    }
}
