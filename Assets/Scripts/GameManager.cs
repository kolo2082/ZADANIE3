using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    GameObject[] alltargets;
    public GameObject winPanel;
    public TMP_Text TimerText;
    public TMP_Text TimeText;


    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()

    {
        float time = Time.timeSinceLevelLoad;
        TimerText.SetText(time.ToString("0.0"));


        alltargets = GameObject.FindGameObjectsWithTag("Target");
        if (alltargets.Length < 1)
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
            TimeText.SetText(time.ToString("0.0"));
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
