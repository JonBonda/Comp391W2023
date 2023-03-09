using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // something has to collide
        // create an explosion // animation of explosion
        // delete that other entering object
        Destroy(other.gameObject);
        // delete this object
        Destroy(this.gameObject);


    }

}
