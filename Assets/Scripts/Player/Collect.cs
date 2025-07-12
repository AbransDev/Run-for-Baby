using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{   


    //sounds

    public GameObject take_item_sound;
    AudioSource take_mp3;

    public GameObject phone_message;
    AudioSource phone_mp3;

    public GameObject phone_message2;
    AudioSource phone2_mp3;

    public GameObject alert;
    AudioSource alert_mp3;



    public GameManager gm;
    public Timer tm;

    public GameObject phoneUI;
    public GameObject phoneUI2;
    public GameObject trick1;
    public GameObject trick2;



    public Image nokta;
    public float mesafe;
    public bool reset= false;
    public int TotalScore = 0; 



    public bool a = false;
    public GameObject mouse;
    public GameObject playerC;
    public GameObject ESC;
    

    void Start()
    {

        take_mp3 = take_item_sound.GetComponent<AudioSource>();
        phone_mp3 = phone_message.GetComponent<AudioSource>();
        phone2_mp3 = phone_message2.GetComponent<AudioSource>();
        alert_mp3  = alert.GetComponent<AudioSource>();

       
        
    }


    void Update()
    {

     

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(a==false)
            {
                pauseOn();
            }else
            {
                puseOff();
            }
        }

        if(Input.GetMouseButtonDown(0) && nokta.color == Color.red)
        {
            tm.currentTime -=2;
            alert_mp3.Play();
        }


        Vector3 ileri = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        nokta.color = Color.white;

        if(Physics.Raycast(transform.position, ileri, out hit))
        {
                Debug.DrawLine(transform.position, hit.point, Color.red);

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "cashier")
                { 
                    if(gm.inv1 >= gm.need1 && gm.inv2 >= gm.need2 && gm.inv3 >= gm.need3 && gm.inv4 >= gm.need4 && gm.inv5 >= gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {

                            if(gm.spage == 1)
                            {
                                gm.spage++;
                                reset= true;
                                TotalScore += gm.listScore;
                                tm.currentTime+= PlayerPrefs.GetFloat("artanSüre");
                                StartCoroutine(NewListMessage());
                                gm.CreateList2();
                            }
                            else if (gm.spage == 2)
                            {   
                                gm.spage ++;
                                reset= true;
                                TotalScore += gm.listScore;
                                tm.currentTime+= PlayerPrefs.GetFloat("artanSüre");
                                StartCoroutine(NewListMessage2());
                                gm.CreateList3();
                            }
                            else if (gm.spage == 3)
                            {   
                                gm.spage ++;
                                reset= true;
                                TotalScore += gm.listScore;
                                tm.currentTime+= PlayerPrefs.GetFloat("artanSüre");
                                StartCoroutine(NewListMessage2());
                                gm.CreateList4();
                            }
                            else if (gm.spage >= 4)
                            {   
                                gm.spage ++;
                                reset= true;
                                TotalScore += gm.listScore;
                                tm.currentTime+= PlayerPrefs.GetFloat("artanSüre");
                                StartCoroutine(NewListMessage2());
                                gm.CreateList5();
                            }

                        }
                    }
                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P1")
                { 
                    if(gm.Product1_txt.text == "Juice" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Juice" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Juice" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Juice" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Juice" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }
                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P2")
                { 
                    if(gm.Product1_txt.text == "Milk" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Milk" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Milk" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Milk" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Milk" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }
                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P3")
                { 
                    if(gm.Product1_txt.text == "Chocolate" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Chocolate" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Chocolate" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Chocolate" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Chocolate" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P4")
                { 
                    if(gm.Product1_txt.text == "Salami" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Salami" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Salami" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Salami" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Salami" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P5")
                { 
                    if(gm.Product1_txt.text == "Bread" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Bread" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Bread" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Bread" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Bread" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P6")
                { 
                    if(gm.Product1_txt.text == "Hot dog" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Hot dog" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Hot dog" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Hot dog" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Hot dog" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P7")
                { 
                    if(gm.Product1_txt.text == "Cheeseburger" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Cheeseburger" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Cheeseburger" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Cheeseburger" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Cheeseburger" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P8")
                { 
                    if(gm.Product1_txt.text == "Cheese" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Cheese" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Cheese" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Cheese" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Cheese" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P9")
                { 
                    if(gm.Product1_txt.text == "Chicken" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Chicken" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Chicken" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Chicken" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Chicken" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P10")
                { 
                    if(gm.Product1_txt.text == "Steak" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Steak" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Steak" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Steak" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Steak" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P11")
                { 
                    if(gm.Product1_txt.text == "Sucuk" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Sucuk" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Sucuk" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Sucuk" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Sucuk" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P12")
                { 
                    if(gm.Product1_txt.text == "Coconut" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Coconut" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Coconut" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Coconut" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Coconut" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P13")
                { 
                    if(gm.Product1_txt.text == "Apple" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Apple" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Apple" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Apple" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Apple" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

                if(hit.distance <= mesafe && hit.collider.gameObject.tag== "P14")
                { 
                    if(gm.Product1_txt.text == "Banana" && gm.inv1 < gm.need1)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv1++;             
                        }
                    }
                    else if(gm.Product2_txt.text == "Banana" && gm.inv2 < gm.need2 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);   
                        gm.inv2++;             
                        }
                    }
                    else if(gm.Product3_txt.text == "Banana" && gm.inv3 < gm.need3)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv3++;             
                        }
                    }
                    else if(gm.Product4_txt.text == "Banana" && gm.inv4 < gm.need4 )
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);    
                        gm.inv4++;             
                        }
                    }
                    else if(gm.Product5_txt.text == "Banana" && gm.inv5 < gm.need5)
                    {
                        nokta.color  = Color.green;
                        if(Input.GetMouseButtonDown(0))
                        {
                        take_mp3.Play();
                        hit.collider.gameObject.SetActive(false);  
                        gm.inv5++;             
                        }
                    }
                    else
                    {
                        nokta.color = Color.red;
                    }

                }

            


        }  


        IEnumerator NewListMessage()
        {
            phone_mp3.Play();

            yield return new WaitForSeconds(2);

            phoneUI.SetActive(true);

            yield return new WaitForSeconds(7);

            phoneUI.SetActive(false);

        }

        IEnumerator NewListMessage2()
        {
            phone2_mp3.Play();

            yield return new WaitForSeconds(2);

            phoneUI2.SetActive(true);

            yield return new WaitForSeconds(7);

            phoneUI2.SetActive(false);

        }

        if(gm.inv1 >= gm.need1 && gm.inv2 >= gm.need2 && gm.inv3 >= gm.need3 && gm.inv4 >= gm.need4 && gm.inv5 >= gm.need5)
        {
            trick1.SetActive(false);
            trick2.SetActive(true);  
                      
        }else
        {   
            trick1.SetActive(true);
            trick2.SetActive(false);   
                
        }
        
    }


    

        


        public void pauseOn()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible= true;
            mouse.GetComponent<FirstPersonLook>().enabled = false;
            playerC.GetComponent<FirstPersonMovement>().enabled = false;
            playerC.GetComponent<Jump>().enabled = false;
            playerC.GetComponent<Crouch>().enabled = false;
            ESC.SetActive(true);
            a = true;
        }

        public void puseOff()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible= false;
            mouse.GetComponent<FirstPersonLook>().enabled = true;
            playerC.GetComponent<FirstPersonMovement>().enabled = true;
            playerC.GetComponent<Jump>().enabled = true;
            playerC.GetComponent<Crouch>().enabled = true;
            ESC.SetActive(false);
            a = false;
        }
}
