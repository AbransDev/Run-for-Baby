using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject paper_sound;
    AudioSource paper_mp3;


    public GameObject market_list;
    public TextMeshProUGUI page;
    public TextMeshProUGUI Product1_txt;
    public TextMeshProUGUI Product2_txt;
    public TextMeshProUGUI Product3_txt;
    public TextMeshProUGUI Product4_txt;
    public TextMeshProUGUI Product5_txt;
    public TextMeshProUGUI Product11_txt;
    public TextMeshProUGUI Product22_txt;
    public TextMeshProUGUI Product33_txt;
    public TextMeshProUGUI Product44_txt;
    public TextMeshProUGUI Product55_txt;
    public TextMeshProUGUI listScore_txt;


    public int listScore;


    string[] products = { "Juice", "Milk", "Chocolate", "Salami", "Bread", "Hot dog", "Cheeseburger", "Cheese", "Chicken", "Steak", "Sucuk", "Coconut", "Apple", "Banana"};


    public int need1, need2, need3, need4, need5;
    public int no1, no2, no3, no4, no5;
    public int spage = 1;

    public int inv1=0;
    public int inv2=0;
    public int inv3=0;
    public int inv4=0;
    public int inv5=0;


    public GameObject arrow;
    public GameObject mainLight;
    public GameObject spot;


    void Start()
    {

        paper_mp3 = paper_sound.GetComponent<AudioSource>();
        CreateList1();

    }

    // Update is called once per frame
    void Update()
    {

        if(inv1 >= need1 && inv2 >= need2 && inv3 >= need3 && inv4 >= need4 && inv5 >= need5)
        {
            arrow.SetActive(true);
            spot.SetActive(true);
            mainLight.SetActive(false);
        }
        else
        {
            arrow.SetActive(false);
            spot.SetActive(false);
            mainLight.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {   
            paper_mp3.Play();
            market_list.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            paper_mp3.Play();
            market_list.SetActive(false);
        }

        UpdateList();

        
    }




    public void CreateList1()
    {    
        page.text = spage.ToString();
        need1 = UnityEngine.Random.Range(1, 4);
        no1 = UnityEngine.Random.Range(0, 14);

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 

        listScore= 10* (need1);

        Product1_txt.text = products[no1];
        Product11_txt.text = inv1  + "/" + need1;

        listScore_txt.text = "Total Score= " + listScore;

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 
    }

    public void CreateList2()
    {    

        page.text = spage.ToString();
        need1 = UnityEngine.Random.Range(1, 4);
        need2 = UnityEngine.Random.Range(1, 4);
        no1 = UnityEngine.Random.Range(0, 14);

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 

        do
        {
            no2 = UnityEngine.Random.Range(0, 14);
        }
        while(no2 == no1);

        listScore= 10* (need1 + need2);

        Product1_txt.text = products[no1];
        Product11_txt.text = inv1  + "/" + need1;
        Product2_txt.text = products[no2];
        Product22_txt.text = inv2  + "/" + need2;

        listScore_txt.text = "Total Score= " + listScore;
    }

    public void CreateList3()
    {    
        page.text = spage.ToString();
        need1 = UnityEngine.Random.Range(1, 4);
        need2 = UnityEngine.Random.Range(1, 4);
        need3 = UnityEngine.Random.Range(1, 4);
        no1 = UnityEngine.Random.Range(0, 14);

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 

        do
        {
            no2 = UnityEngine.Random.Range(0, 14);
        }
        while(no2 == no1);
        do
        {
            no3 = UnityEngine.Random.Range(0, 14);
        }
        while(no3 == no1 || no3 == no2);

        listScore= 10* (need1 + need2 + need3);

        Product1_txt.text = products[no1];
        Product11_txt.text = inv1  + "/" + need1;
        Product2_txt.text = products[no2];
        Product22_txt.text = inv2  + "/" + need2;
        Product3_txt.text = products[no3];
        Product33_txt.text = inv3  + "/" + need3;

        listScore_txt.text = "Total Score= " + listScore;

       
    }

    public void CreateList4()
    {    
        page.text = spage.ToString();
        need1 = UnityEngine.Random.Range(1, 4);
        need2 = UnityEngine.Random.Range(1, 4);
        need3 = UnityEngine.Random.Range(1, 4);
        need4 = UnityEngine.Random.Range(1, 4);

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 


        no1 = UnityEngine.Random.Range(0, 14);
        do
        {
            no2 = UnityEngine.Random.Range(0, 14);
        }
        while(no2 == no1);
        do
        {
            no3 = UnityEngine.Random.Range(0, 14);
        }
        while(no3 == no1 || no3 == no2);

        do
        {
            no4 = UnityEngine.Random.Range(0, 14);
        }
        while(no4 == no1 || no4 == no2 || no4 == no3);


        listScore= 10* (need1 + need2 + need3 + need4);

        Product1_txt.text = products[no1];
        Product11_txt.text = inv1  + "/" + need1;
        Product2_txt.text = products[no2];
        Product22_txt.text = inv2  + "/" + need2;
        Product3_txt.text = products[no3];
        Product33_txt.text = inv3  + "/" + need3;
        Product4_txt.text = products[no4];
        Product44_txt.text = inv4  + "/" + need4;

        listScore_txt.text = "Total Score= " + listScore;
    }

     public void CreateList5()
    {    
        page.text = spage.ToString();
        need1 = UnityEngine.Random.Range(1, 4);
        need2 = UnityEngine.Random.Range(1, 4);
        need3 = UnityEngine.Random.Range(1, 4);
        need4 = UnityEngine.Random.Range(1, 4);
        need5 = UnityEngine.Random.Range(1, 4);

        inv1=0;
        inv2=0;
        inv3=0;
        inv4=0;
        inv5=0; 


        no1 = UnityEngine.Random.Range(0, 14);
        do
        {
            no2 = UnityEngine.Random.Range(0, 14);
        }
        while(no2 == no1);
        do
        {
            no3 = UnityEngine.Random.Range(0, 14);
        }
        while(no3 == no1 || no3 == no2);

        do
        {
            no4 = UnityEngine.Random.Range(0, 14);
        }
        while(no4 == no1 || no4 == no2 || no4 == no3);

        do
        {
            no5 = UnityEngine.Random.Range(0, 14);
        }
        while(no5 == no1 || no5 == no2 || no5 == no3 || no5 == no4);


        listScore= 10* (need1 + need2 + need3 + need4);

        Product1_txt.text = products[no1];
        Product11_txt.text = inv1  + "/" + need1;
        Product2_txt.text = products[no2];
        Product22_txt.text = inv2  + "/" + need2;
        Product3_txt.text = products[no3];
        Product33_txt.text = inv3  + "/" + need3;
        Product4_txt.text = products[no4];
        Product44_txt.text = inv4  + "/" + need4;
        Product5_txt.text = products[no5];
        Product55_txt.text = inv5  + "/" + need5;

        listScore_txt.text = "Total Score= " + listScore;

        
    }


    public void UpdateList()
    {
        if(inv1 <need1)
        {
        Product1_txt.color = new Color(1, 0, 0, 1);
        Product11_txt.color = new Color(1, 0, 0, 1);
        }else
        {
        Product1_txt.color = new Color(0, 1, 0, 1);
        Product11_txt.color = new Color(0, 1, 0, 1);
        }


        if(inv2 <need2)
        {
        Product2_txt.color = new Color(1, 0, 0, 1);
        Product22_txt.color = new Color(1, 0, 0, 1);
        }else
        {
        Product2_txt.color = new Color(0, 1, 0, 1);
        Product22_txt.color = new Color(0, 1, 0, 1);
        }

        
        if(inv3 <need3)
        {
        Product3_txt.color = new Color(1, 0, 0, 1);
        Product33_txt.color = new Color(1, 0, 0, 1);
        }else
        {
        Product3_txt.color = new Color(0, 1, 0, 1);
        Product33_txt.color = new Color(0, 1, 0, 1);
        }


        if(inv4 <need4)
        {
        Product4_txt.color = new Color(1, 0, 0, 1);
        Product44_txt.color = new Color(1, 0, 0, 1);
        }else
        {
        Product4_txt.color = new Color(0, 1, 0, 1);
        Product44_txt.color = new Color(0, 1, 0, 1);
        }
        
        
        if(inv5 <need5)
        {
        Product5_txt.color = new Color(1, 0, 0, 1);
        Product55_txt.color = new Color(1, 0, 0, 1);
        }else
        {
        Product5_txt.color = new Color(0, 1, 0, 1);
        Product55_txt.color = new Color(0, 1, 0, 1);
        }

        if(need1 > 0)
        {
            Product11_txt.text = inv1  + "/" + need1;
        }
        else
        {
            Product11_txt.text = "";
        }
        
        if(need2 > 0)
        {
            Product22_txt.text = inv2  + "/" + need2;
        }
        else
        {
            Product22_txt.text = "";
        }
        if(need3 > 0)
        {
            Product33_txt.text = inv3  + "/" + need3;
        }
        else
        {
            Product33_txt.text = "";
        }
        if(need4 > 0)
        {
            Product44_txt.text = inv4  + "/" + need4;
        }
        else
        {
            Product44_txt.text = "";
        }
        if(need5 > 0)
        {
            Product55_txt.text = inv5  + "/" + need5;
        }else
        {
            Product55_txt.text = "";
        }

        listScore_txt.text = "Total Score= " + listScore;

    }

}
