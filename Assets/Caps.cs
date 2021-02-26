using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Caps : MonoBehaviour
{

    public GameObject cap; 
    public GameObject sph1;
    public GameObject sph2;
    public GameObject sph3;  
    public GameObject sph4;
    public GameObject sph5;
    public GameObject sph6;
    public GameObject sph7;  
    public GameObject sph8;
    public GameObject romb; //1 - 1 2
    public GameObject noj; // 2 - 3, 4
    public GameObject teddy; // 3 - 1, 3
    public GameObject rainbow; // 4 - 1, 4
    public GameObject bubble; // 5 - 2, 3
    public GameObject kiss; // 6 - 5, 6
    public GameObject petal; // 7 - 5, 7
    public GameObject desert; // 8 - 5, 8 
    public GameObject dishes; // 9 - 6, 7
    public GameObject heart; // 10 - 7, 8
    public TextMesh TVText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    // Assigns a material named "Assets/Resources/DEV_Orange" to the object.
    Material mat1 = Resources.Load("a/Brick 1.mat", typeof(Material)) as Material;



    if (sph1.GetComponent<Renderer>().material.color == Color.red &
    sph2.GetComponent<Renderer>().material.color == Color.red &
    sph3.GetComponent<Renderer>().material.color == Color.red &
    sph4.GetComponent<Renderer>().material.color == Color.red){

        romb.SetActive(false);
        noj.SetActive(false);
        teddy.SetActive(false);
        rainbow.SetActive(false);
        bubble.SetActive(false);
    }
        // if 1 & 2 -> romb
     else if (sph1.GetComponent<Renderer>().material.color == Color.blue &
        sph2.GetComponent<Renderer>().material.color == Color.blue)
    {
        romb.SetActive(true);
        noj.SetActive(false);
        teddy.SetActive(false);
        rainbow.SetActive(false);
        bubble.SetActive(false);
    }

    // if 3 & 4 -> noj
     else if (sph3.GetComponent<Renderer>().material.color == Color.blue &
        sph4.GetComponent<Renderer>().material.color == Color.blue)
    {
        noj.SetActive(true);
        romb.SetActive(false);
        teddy.SetActive(false);
        rainbow.SetActive(false);
        bubble.SetActive(false);
    }

    // if 1 & 3 -> teddy
    else if (sph3.GetComponent<Renderer>().material.color == Color.blue &
        sph1.GetComponent<Renderer>().material.color == Color.blue)
    {
        teddy.SetActive(true);
        noj.SetActive(false);
        romb.SetActive(false);
        rainbow.SetActive(false);
        bubble.SetActive(false);
    }


    // if 1 & 4 -> rainbow crossbow
    else if (sph4.GetComponent<Renderer>().material.color == Color.blue &
        sph1.GetComponent<Renderer>().material.color == Color.blue)
    {
        rainbow.SetActive(true);
        teddy.SetActive(false);
        noj.SetActive(false);
        romb.SetActive(false);
        bubble.SetActive(false);
    }

    // if 2 & 3 -> bubble blaster
    else if (sph2.GetComponent<Renderer>().material.color == Color.blue &
        sph3.GetComponent<Renderer>().material.color == Color.blue)
    {
        bubble.SetActive(true);
        rainbow.SetActive(false);
        teddy.SetActive(false);
        noj.SetActive(false);
        romb.SetActive(false);
    }



    // ________________________________________________________________________

     if (sph5.GetComponent<Renderer>().material.color == Color.red &
        sph6.GetComponent<Renderer>().material.color == Color.red &
        sph7.GetComponent<Renderer>().material.color == Color.red &
        sph8.GetComponent<Renderer>().material.color == Color.red){

        kiss.SetActive(false);
        petal.SetActive(false);
        desert.SetActive(false);
        dishes.SetActive(false);
        heart.SetActive(false);
     }  

        // if 5 & 6 -> kiss gun
        else if (sph5.GetComponent<Renderer>().material.color == Color.blue &
        sph6.GetComponent<Renderer>().material.color == Color.blue)
    {
        kiss.SetActive(true);
        petal.SetActive(false);
        desert.SetActive(false);
        dishes.SetActive(false);
        heart.SetActive(false);
    }

        // if 5 & 7 -> petal
        else if (sph5.GetComponent<Renderer>().material.color == Color.blue &
        sph7.GetComponent<Renderer>().material.color == Color.blue)
    {
        petal.SetActive(true);
        kiss.SetActive(false);
        desert.SetActive(false);
        dishes.SetActive(false);
        heart.SetActive(false);
    }

        // if 5 & 8 -> desrt
        else if (sph5.GetComponent<Renderer>().material.color == Color.blue &
        sph8.GetComponent<Renderer>().material.color == Color.blue)
    {
        petal.SetActive(false);
        kiss.SetActive(false);
        desert.SetActive(true);
        dishes.SetActive(false);
        heart.SetActive(false);

    }

        // if 6 & 7 -> dishes
        else if (sph6.GetComponent<Renderer>().material.color == Color.blue &
        sph7.GetComponent<Renderer>().material.color == Color.blue)
    {
        petal.SetActive(false);
        kiss.SetActive(false);
        desert.SetActive(false);
        dishes.SetActive(true);
        heart.SetActive(false);
    }

        // if 7 & 8 -> heart
        else if (sph8.GetComponent<Renderer>().material.color == Color.blue &
        sph7.GetComponent<Renderer>().material.color == Color.blue)
    {
        petal.SetActive(false);
        kiss.SetActive(false);
        desert.SetActive(false);
        dishes.SetActive(false);
        heart.SetActive(true);
    }


// ________________________________________________________________________

    //romb + kiss
    if (romb.activeSelf & kiss.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(1f, 0.6f, 0.6f, 1f);
            TVText.text = "Romb Kiss!";
        }
        //romb + petal
    if (romb.activeSelf & petal.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0.3f, 0.4f, 1f, 1f);
            TVText.text = "Romb Petal!";
        }
        //noj + desert
        if (noj.activeSelf & desert.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0.5f, 0.1f, 0.4f, 1f);
            TVText.text = "Knife Desert!";
        }
        //teddy + heart
        if (teddy.activeSelf & heart.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(1f, 0f, 0.6f, 1f);
            TVText.text = "Teddy Heart!";
        }
        //teddy + dishes
        if (teddy.activeSelf & dishes.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0f, 0.2f, 0.4f, 1f);
            TVText.text = "Romb Kiss!";
        }
        //rainbow + petal
        if (rainbow.activeSelf & petal.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0.6f, 1f, 0.6f, 1f);
            TVText.text = "Rainbow Petal!";
        }
        //rainbow + kiss
        if (rainbow.activeSelf & kiss.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0.8f, 1f);
            TVText.text = "Rainbow Kiss!";
        }
        //bubble + heart
        if (bubble.activeSelf & heart.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(1f, 0f, 1f, 1f);
            TVText.text = "Bubble Heart!";
        }
        //bubble + dishes
        if (bubble.activeSelf & dishes.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0f, 1f, 1f, 1f);
            TVText.text = "Bubble Dishes!";
        }

        // romb + dishes
        if (romb.activeSelf & dishes.activeSelf){
        cap.GetComponent<Renderer>().material.color = new Color(0.3f, 0.3f, 0.3f, 1f);
            TVText.text = "Romb Dishes!";
        }
    }
}