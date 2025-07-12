using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public Collect cl;
    public GameObject game_over_screen;

    


    public Image timer_png;
    public TextMeshProUGUI timer_txt;
    public float currentTime;
    public float player_time;
    public TextMeshProUGUI game_over_score;


    public TextMeshProUGUI score_txt;

    

    void Start()
    {
        player_time = PlayerPrefs.GetFloat("anaSüre");
        currentTime = player_time;
        Time.timeScale=1;
        timer_txt.SetText(currentTime.ToString());
        StartCoroutine(UpdateTime());
        

    }



    // Update is called once per frame
    void Update()
    {
        
        score_txt.SetText(cl.TotalScore.ToString());
        game_over_score.SetText("Score= "+ score_txt.text);

        if(currentTime <= 0)
        {
            GameOver();
        }
        
    }


    private IEnumerator UpdateTime()
    {
        while(currentTime >= 0)
        {
            timer_png.fillAmount = Mathf.InverseLerp(0, player_time, currentTime);
            timer_txt.SetText(currentTime.ToString());
            yield return new WaitForSeconds(1f);
            currentTime --;
        }

          yield return null;
    }


    private void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible= true;
        Time.timeScale=0;
        game_over_screen.SetActive(true);
        cl.mouse.GetComponent<FirstPersonLook>().enabled = false;

    }
}
