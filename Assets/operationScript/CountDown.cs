using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
    public float timeStart = 60;

    public Text textBox;

    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject LosePanel;
    void Win()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    void Lose()
    {
        LosePanel.SetActive(true);
        Time.timeScale = 0f;
    }

	void Start () {
        textBox.text = timeStart.ToString();
        Time.timeScale = 1f;
	}
	
	void Update () {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0)
        {
            timeStart = 0;
            Win();

        }
        if(HealthBarScript.health <= 0)
            {
            timeStart = 5;
            Lose();
            }
	}
}
