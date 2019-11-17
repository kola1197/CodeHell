using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Image positiveProgressBar;
    public Image negativeProgressBar;
    public TextMeshProUGUI ToDeadline;
    public GameObject playerUI;
    public GameObject GameClear;
    public GameObject GameOver;

    private Labyrinth _labyrinth;
    public float victoryRange = 24.0f;
    private Vector3 _victoryPoint;
    private float _distance;
    public static GameManager instance;
    private bool _canWin = false;
    private bool _lost = false;
    public bool CanWin => _canWin;
    private void Awake()
    {
        if (instance == null) 
        { 
            instance = this;
        } else if(instance == this)
        { 
            Destroy(gameObject); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        var angle = Quaternion.AngleAxis(UnityEngine.Random.Range(0, 359), Vector3.up);
        var direction = angle * player.transform.forward;
        var finishPoint = direction * UnityEngine.Random.Range(128.0f, 256.0f);
        _victoryPoint = player.transform.position + finishPoint;
        _distance = finishPoint.magnitude;
        _labyrinth = FindObjectOfType<Labyrinth>();
    }

    public void Lose()
    {
        _lost = true;
    }

    public void Victory()
    {
        GameClear.SetActive(true);
        _labyrinth.CloseUi();
        playerUI.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameLost()
    {
        GameOver.SetActive(true);
        _labyrinth.CloseUi();
        playerUI.SetActive(false);
        Time.timeScale = 0;
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("_Scenes/MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        ToDeadline.text = "До дедлайна: " + _labyrinth.TilesRemained;
        if (_labyrinth.TilesRemained <= 0 && !_canWin) Lose();
        if (player.transform.position.y < -16) Lose();
        var delta = _distance - (_victoryPoint - player.transform.position).magnitude;
        if (delta > 0)
        {
            positiveProgressBar.fillAmount = delta / _distance;
            negativeProgressBar.fillAmount = 0f;
        }
        else
        {
            positiveProgressBar.fillAmount = 0f;
            negativeProgressBar.fillAmount = delta / (0.3f * _distance);
        }

        if (Mathf.Abs(_distance - delta) < victoryRange)
        {
            _canWin = true;
        }
    }
}
