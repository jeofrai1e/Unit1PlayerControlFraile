using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicles : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);   
    }
}
