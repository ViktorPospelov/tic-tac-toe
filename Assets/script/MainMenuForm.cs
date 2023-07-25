using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using YG;

public class MainMenuForm : MonoBehaviour
{
  

    [SerializeField] private Button one;
    [SerializeField] private Button two;
    [SerializeField] private GameForm gameForm;
    [SerializeField] private GameForm gameFormDesc;

    private void Start()
    {
        gameForm = Screen.width > Screen.height ? gameFormDesc : gameForm;
        
        one.onClick.AddListener(() =>
        {
            gameForm.onBot = true;
            gameForm.gameObject.SetActive(true);
            gameObject.SetActive(false);
        });
        two.onClick.AddListener(() =>
        {
            gameForm.onBot = false;
            gameForm.gameObject.SetActive(true);
            gameObject.SetActive(false);
        });
    }
}