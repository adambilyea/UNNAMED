using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerElevator : MonoBehaviour
{

    public GameObject Platform;

    private void OnTriggerStay() 
    { 
        Platform.transform.up += Platform.transform.up * Time.deltaTime;
    }
}
