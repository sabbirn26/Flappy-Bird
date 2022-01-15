using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdbehav : MonoBehaviour
{
    
    public float forceAmount = 6;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if(Input.GetKeyDown(KeyCode.Space))
        {
             rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);

        }

    }

    
}
