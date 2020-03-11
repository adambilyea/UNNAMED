using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingAreaLights : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    public GameObject Light8;
    public GameObject Light9;
    public GameObject Light10;

    double lightCounter;
    bool lightBool = false;
    bool lightBool2 = false;    
    bool lightBool3 = false;    
    bool lightBool4 = false;    
    bool lightBool5 = false; 
    double lightTemp = 0;
    double lightTemp2 = 0;
    double lightTemp3 = 0;
    double lightTemp4 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.name == "Player")
         {
            lightBool = true;
            Debug.Log("Lights On");
         }
    }


    // Update is called once per frame
    void Update()
    {
        lightCounter += Time.deltaTime;
        //lightCounter++;
        //Debug.Log(lightCounter);
        if (lightBool3 == true)
        {
           //Debug.Log("Lights 3");  
        }


        if (lightBool == true)
        {
            Light1.SetActive(true); 
            Light2.SetActive(true); 
            lightTemp = lightCounter + 1;
            lightBool = false;
            lightBool2 = true;
            Debug.Log("Lights 1"); 
        }
        
        if ((lightCounter > lightTemp) & (lightBool2 == true))
        {
            Light3.SetActive(true); 
            Light4.SetActive(true); 
            lightTemp2 = lightCounter + 1;     
            lightBool3 = true; 
            lightBool2 = false;
            Debug.Log("Lights 2");     
        }

        if ((lightCounter > lightTemp2) & (lightBool3 == true))
        {
            Light5.SetActive(true); 
            Light6.SetActive(true); 
            lightTemp3 = lightCounter + 1;     
            lightBool4 = true; 
            lightBool3 = false;
            Debug.Log("Lights 3");     
        }

        if ((lightCounter > lightTemp3) & (lightBool4 == true))
        {
            Light7.SetActive(true); 
            Light8.SetActive(true);
            lightTemp4 = lightCounter + 1;   
            lightBool5 = true;
            lightBool4 = false;
            Debug.Log("Lights 4"); 
        }

        if ((lightCounter > lightTemp4) & (lightBool5 == true))
        {
            Light9.SetActive(true); 
            Light10.SetActive(true); 
            Debug.Log("Lights 5"); 
        }

    }
}
