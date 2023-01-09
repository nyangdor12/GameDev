using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSet : MonoBehaviour
{
    public bool doorState = true;
    private void Start() {
        GameEvents.current.onDoorTrigger +=  onDoorAction;
    }
    private void onDoorAction() {
        if(doorState == true){
            //Open Door: gameObject.SetActive(false);

            doorState = false;
        } else if(doorState == false){
            //Close Door: gameObject.SetActive(true);

            doorState = true;
        }
    }


}
