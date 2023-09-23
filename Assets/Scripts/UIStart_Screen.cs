using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIStartM : MonoBehaviour
{
    [SerializeField] Button _startGame;
    // Start is called before the first frame update
    void Start()
    {
        _startGame.onClick.AddListener(StartNewGame);
    }

    private void StartNewGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }
}
