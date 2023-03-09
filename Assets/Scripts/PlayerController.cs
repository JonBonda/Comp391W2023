using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public int speed = 10;

    public float minX, minY, maxX, maxY;


    //public GameObject PulseCannonSpawner000;
    public GameObject PulseCannonSpawner00a;
    public GameObject PulseCannonSpawner00b;
    //public GameObject pulse_000;
    public GameObject pulse_00a;
    public GameObject pulse_00b;

    // public GameObject BeamCannonSpawner011;
    public GameObject BeamCannonSpawner01a;
    public GameObject BeamCannonSpawner01b;
    // public GameObject beam_011;
    public GameObject beam_01a;
    public GameObject beam_01b;

    private float timer = 0.0f;

    public float fireRate = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


        // Restrict Player to the Game's Domain Area // Main Camera Boundaries
        // float newX, newY;
        // newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        // newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);
        // minX, maxX = +/- 16
        // minY, maxY = +/- 6.5
        // Debug.Log("Clamp X: " + newX + " Y: " + newY);
        // GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);


        // Player's initial/previous iteration position method
        float h, v;
        h = UnityEngine.Input.GetAxis("Horizontal");                  
        v = UnityEngine.Input.GetAxis("Vertical");                    

        // We user the Debug.log to display the x + y values during game when in motion
        // Debug.Log("horizontal values: " + h + " vertical values: " + v);

        // Player's new iteration position method
        Vector2 newvelocity = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity = newvelocity * speed;


        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {

                        //GameObject gObjPulse00;
            GameObject gObjPulse0a;
            GameObject gObjPulse0b;

            //GameObject gObjBeam00;
            GameObject gObjBeam0a;
            GameObject gObjBeam0b;

            //gObjPulse00 = GameObject.Instantiate(pulse_000, PulseCannonSpawner000.transform.position, PulseCannonSpawner000.transform.rotation);
            gObjPulse0a = GameObject.Instantiate(pulse_00a, PulseCannonSpawner00a.transform.position, PulseCannonSpawner00a.transform.rotation);
            gObjPulse0b = GameObject.Instantiate(pulse_00b, PulseCannonSpawner00b.transform.position, PulseCannonSpawner00b.transform.rotation);
            // gObjBeam00 = GameObject.Instantiate(beam_011, BeamCannonSpawner011.transform.position, BeamCannonSpawner011.transform.rotation);
            gObjBeam0a = GameObject.Instantiate(beam_01a, BeamCannonSpawner01a.transform.position, BeamCannonSpawner01a.transform.rotation);
            gObjBeam0b = GameObject.Instantiate(beam_01b, BeamCannonSpawner01b.transform.position, BeamCannonSpawner01b.transform.rotation);

            // gObjPulse00.transform.Rotate(new Vector3(-2, 3, 90));
            gObjPulse0a.transform.Rotate(new Vector3(0, 0, 0));
            gObjPulse0b.transform.Rotate(new Vector3(0, 0, 0));

            // gObjBeam00.transform.Rotate(new Vector3(0, -1, 90));
            gObjBeam0a.transform.Rotate(new Vector3(0, 0, 0));
            gObjBeam0b.transform.Rotate(new Vector3(0, 0, 0));
            timer = 0; // reset the timer
        }


        timer += Time.deltaTime;


    }
}
