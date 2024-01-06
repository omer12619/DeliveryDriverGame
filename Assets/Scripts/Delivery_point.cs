using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery_point : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float timetodestroy;
    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Package" && hasPackage ==false)
        {
            hasPackage = true;
            Debug.Log("makeit");
            Destroy(collision.gameObject, timetodestroy);
        }
        else if(collision.tag == "Customer" && hasPackage==true)
        {
            Debug.Log("makeit");
            hasPackage =false;
            Destroy(collision.gameObject, timetodestroy);
            
        }
        
    }
}
