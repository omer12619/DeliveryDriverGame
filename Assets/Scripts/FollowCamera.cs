using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]GameObject thingtofollow ;

    //this scrpt make the camera to follow the car
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.position = thingtofollow.transform.position +new Vector3(0,0,-10); 
    }
}
