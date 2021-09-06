using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject defeatPanel;
    [SerializeField] GameObject platform;
    [SerializeField] Transform ball;
    [SerializeField] Timer timer;

    void Start()
    {
        startPanel.SetActive(true);
        defeatPanel.SetActive(false);
    }

    private IEnumerator StartGame()
    {
        startPanel.SetActive(false);
        defeatPanel.SetActive(false);
        platform.transform.rotation = Quaternion.Euler(-3, 0, 0);
        Instantiate(ball);
        timer.StartTimer();
        yield return null;
    }
    public IEnumerator EndGame()
    {
        timer.StopTimer();
        platform.transform.rotation = Quaternion.Euler(-3, 0, 0);
        defeatPanel.SetActive(true);
        yield return null;
    }

    public void StartGameClick() {
        StartCoroutine(StartGame());
    }

    public void QuitGameClick()
    {
        Application.Quit();
    }

}

