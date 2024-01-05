using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]int hitpoint = 100;
    [SerializeField]float  speed = 0.001f;
    [SerializeField] float steerspeed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        float bre = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0,bre,0);
    }

}
