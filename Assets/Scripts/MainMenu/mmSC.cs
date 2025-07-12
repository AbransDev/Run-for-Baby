using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class mmSC : MonoBehaviour
{   
    public GameObject credit;
    public GameObject howtoplay;
    public Collect cl;
    public GameObject Green;
    public GameObject Red;
    public GameObject settings;


    void Update()
    {

        
        
    }



    public GameObject music2;
    
    public void play_btn()
    {
        SceneManager.LoadScene(1);
    }

    public void quit_btn()
    {
        Application.Quit();
    }

    public void credit_btn()
    {
        credit.SetActive(true);
    }

    public void back_btn()
    {
        credit.SetActive(false);
    }

    public void howtoplay_btn()
    {
        howtoplay.SetActive(true);
    }

    public void back2_btn()
    {
        howtoplay.SetActive(false);
    }

    public void restart_btn()
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenu_btn()
    {
        SceneManager.LoadScene(0);
    }

    public void resume_btn()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;
        cl.mouse.GetComponent<FirstPersonLook>().enabled = true;
        cl.playerC.GetComponent<FirstPersonMovement>().enabled = true;
        cl.playerC.GetComponent<Jump>().enabled = true;
        cl.playerC.GetComponent<Crouch>().enabled = true;
        cl.ESC.SetActive(false);
        cl.a = false;
    }

    public void voiceOn_btn()
    {
        music2.SetActive(true);
        Green.SetActive(true);
        Red.SetActive(false); 
    }

    public void voiceOff_btn()
    {
         
        music2.SetActive(false);
        Green.SetActive(false);
        Red.SetActive(true);  
    }

     public void settings_btn()
    {
        settings.SetActive(true);
    }

    public void back3_btn()
    {
        settings.SetActive(false);
    }




}
