using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 10;
    public float horzontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Keep the player in bounds
        if (transform.position.x < - xRange) { transform.position = new Vector3(xRange, transform.position.y, transform.position.z); }
        horzontalInput = Input.GetAxis("horzontal");
        if (transform.position.x > -xRange)
            transform.Translate(Vector3.right * horzontalInput * Time.deltaTime * speed);
    }
}
