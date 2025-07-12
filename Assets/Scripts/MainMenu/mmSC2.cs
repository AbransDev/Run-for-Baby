using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class mmSC2 : MonoBehaviour
{
    public Slider mTime;
    public Slider pTime;
    public TextMeshProUGUI mTime_txt;
    public TextMeshProUGUI pTime_txt;
    public float addPerTime;
    public float mainTime;


    void Start()
    {

        mTime.value = PlayerPrefs.GetFloat("anaSüre");
        pTime.value = PlayerPrefs.GetFloat("artanSüre");

             
    }

    // Update is called once per frame
    void Update()
    {
        mTime_txt.text= mTime.value.ToString();
        pTime_txt.text= pTime.value.ToString();

        mainTime = mTime.value;
        addPerTime = pTime.value;

        PlayerPrefs.SetFloat("anaSüre", mainTime);
        PlayerPrefs.SetFloat("artanSüre", addPerTime);

    }
}
