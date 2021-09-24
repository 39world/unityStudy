using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badthing2 : MonoBehaviour
{   

    public float turnSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        float X = Random.Range(-2.0f,2.0f);

        transform.position = new Vector3(X,5.5f,0);
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Rotate(0,0,10);

        if(transform.position.y < -6)
        {
            Destroy(gameObject);
        }        
    }

    void OnCollisionEnter2D(Collision2D coll) {
        
        if (coll.gameObject.tag == "pet")
        {
            gameManager.I.gameOver();
        }

    }
}
