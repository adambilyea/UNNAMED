using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingElevator : MonoBehaviour
{

    public GameObject platform;

    private void OnTriggerStay()
    {
        platform.transform.position += platform.transform.up * Time.deltaTime;
    }
}
