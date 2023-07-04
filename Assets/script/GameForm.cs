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

public class GameForm : MonoBehaviour
{
    [SerializeField] private GameObject[] points;

    [SerializeField] private Button Block;

    [SerializeField] private TextMeshProUGUI X;
    [SerializeField] private TextMeshProUGUI O;
    [SerializeField] private TextMeshProUGUI deaHeat;

    [SerializeField] private WinLine winLine;
    [SerializeField] private GameObject boom;
    private int[] polyaPosition;
    private CheckWin _checkWin;
    private Bot _Bot;
    private int _clevernessBot = 10;

    public static Action<int> Click;
    public static bool IsKrest => isKrest;
    private static bool isKrest;

    public bool onBot;

    private static bool LangRu = true;

    void OnEnable()
    {
        StartGame();
    }

    public void ButtonStartNewGame()
    {
        if (YandexGame.nowFullAd) YandexGame.FullscreenShow();
        gameObject.SetActive(false);
    }
   

    private void StartGame()
    {
        winLine.ClearWinLine();
        deaHeat.gameObject.SetActive(false);
        X.gameObject.SetActive(false);
        O.gameObject.SetActive(false);
        onBot = false;
        Block.gameObject.SetActive(false);
        isKrest = onBot;
        Click += OnClick;
        _checkWin = new CheckWin();
        _Bot = new Bot();
        polyaPosition = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }

    private void OnClick(int nuberPolya)
    {
        Block.gameObject.SetActive(true);
        polyaPosition[nuberPolya] = isKrest ? 1 : 2;
        var state = _checkWin.Check(polyaPosition);
        if (state != CheckWin.WinString.Non)
        {
            Block.gameObject.SetActive(true);
            if (state != CheckWin.WinString.DeaHeat) boom.SetActive(true);
            SetWiner(state);
        }
        else
        {
            Block.gameObject.SetActive(onBot);
        }

        isKrest = !isKrest;
        if (!IsKrest && onBot) StartCoroutine(MoveBot());
        if(state!= CheckWin.WinString.Non)winLine.gameObject.SetActive(true);
        winLine.SetWineLine(state, winLine.gameObject);
    }


    private IEnumerator MoveBot()
    {
        yield return new WaitForSeconds(1.3f);
        if (polyaPosition.Sum() < 12 && _checkWin.Check(polyaPosition) == CheckWin.WinString.Non)
        {
            var bm = _Bot.MoveBot(polyaPosition, _clevernessBot);
            Debug.Log(bm);
            if (!IsKrest) Click?.Invoke(bm);
            Block.gameObject.SetActive(false);
        }
    }

    private void SetWiner(CheckWin.WinString state)
    {
        if (state == CheckWin.WinString.DeaHeat)
        {
            deaHeat.gameObject.SetActive(true);
            deaHeat.text = LangRu ? "Ничья!" : "Dea Heat!";
        }
        else
        {
            if (isKrest)
            {
                O.text = LangRu ? "Побидил 0!" : "Winer Red!";
                O.gameObject.SetActive(true);
            }
            else
            {
                X.text = LangRu ? "Побидил X!" : "Winer Blue!";
                X.gameObject.SetActive(true);
            }
        }
    }

    private void OnDisable()
    {
        Block.onClick.RemoveAllListeners();
        Click -= OnClick;
    }
}