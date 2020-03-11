using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDoorTrigger : MonoBehaviour
{
    bool doorOpen = false;
    public GameObject door;
    public GameObject door2;
    public GameObject hitch;
    public GameObject hitch2;
    double counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (doorOpen == true)
        {
            counter += Time.deltaTime;
            hitch.transform.position = Vector3.Lerp(hitch.transform.position, new Vector3(hitch.transform.position.x - 2, hitch.transform.position.y, hitch.transform.position.z), 0.05f);
            hitch2.transform.position = Vector3.Lerp(hitch2.transform.position, new Vector3(hitch2.transform.position.x + 2, hitch2.transform.position.y, hitch2.transform.position.z), 0.05f);

            if (counter > 1.5)
            {
                door.transform.position = Vector3.Lerp(door.transform.position, new Vector3(door.transform.position.x + 10, door.transform.position.y, door.transform.position.z), 0.02f);
                door2.transform.position = Vector3.Lerp(door2.transform.position, new Vector3(door2.transform.position.x - 10, door2.transform.position.y, door2.transform.position.z), 0.02f);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.name == "Player")
         {
            doorOpen = true;
            Debug.Log("DoorOpen");
         }
    }
}
