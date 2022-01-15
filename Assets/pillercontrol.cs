using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillercontrol : MonoBehaviour
{

    public float x;
    public float y;
    //float z;
    Vector2 pos;
    
    public float speed=2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.left* speed *Time.deltaTime;
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag=="Respawn")
        {
            Debug.Log("Working!");
            //Destroy(gameObject);
            x = Random.Range(1, 15);
            y = Random.Range(6, 10);
            //z = Random.Range(-25, 26);
            pos = new Vector2(x, y);
            transform.position = pos;
           
        }

        

    // public float generateRandomFloat(System.Random random, int min, int max)
    //  {
    //      int val = random.Next(min, max);
    //      float offset = (float)val;
    //      return offset;
    //  }
    }

    
}
