using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float timeLeft = 90f;
    public GameObject TimeCounter;
    public GameObject GameOverOverlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        UpdateUI();
    }

    void UpdateUI()
    {
        TimeCounter.GetComponent<TextMeshProUGUI>().text = "Time Left:"+Mathf.Floor(timeLeft).ToString();
        if(timeLeft <= 0)
        {
            GameOverOverlay.SetActive(true);
        }
    }
    public void OnWin()
    {
        GameOverOverlay.SetActive(true);
        GameOverOverlay.transform.Find("LossReason").GetComponent<TextMeshProUGUI>().text = "Level Complete!";
    }
    public void OnLoss()
    {
        GameOverOverlay.SetActive(true);
        GameOverOverlay.transform.Find("LossReason").GetComponent<TextMeshProUGUI>().text = "You got spotted";
    }
}
