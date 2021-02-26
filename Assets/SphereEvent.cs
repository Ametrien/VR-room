using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEvent : MonoBehaviour
{

    private Color wasColor;
    bool collision;

    void Start()
    {
        wasColor = GetComponent<Renderer>().material.color;
        collision = false;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("FIRE");
            //GetComponent<PlayerLog>().AddEvent("Fire1");
            /*RaycastHit hitInfo = new RaycastHit();
         		bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
         		if (hit) 
         		{
             			Debug.Log("Hit " + hitInfo.transform.gameObject.name);
				GetComponent<PlayerLog>().AddEvent("Hit " + hitInfo.transform.gameObject.name);
				if (hitInfo.transform.gameObject.name == "Sphere")
					ChangeClickColor();		
			}*/
            if (collision)
                BlueClick();
        }
    }


    public void ColTrue()
    {
        collision = true;
    }

    public void ColFalse()
    {
        collision = false;
    }


    public void BlueClick()
    {
        if (GetComponent<Renderer>().material.color == Color.red)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (GetComponent<Renderer>().material.color == Color.blue)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}