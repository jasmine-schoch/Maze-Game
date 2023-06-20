using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1500f; //public variables can be mondified in renderer
    public float sidewaysForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
       //anything here will run only when the start button is clicked  
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        //Adds a forwards force w variable input within renderer
        //asdw keys are used to move the player USING BIRDS EYE CAMERA
        //rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.rotation = Quaternion.Euler(0, 90.0f, 0);
            rb.AddRelativeForce(0,0,forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.rotation = Quaternion.Euler(0, -90.0f, 0);
            //rb.AddForce(-sidewaysForce* Time.deltaTime,0,0);
            rb.AddRelativeForce(0,0,forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            rb.rotation = Quaternion.Euler(0, 0.0f, 0);
            //rb.AddForce(0,0,forwardForce * Time.deltaTime);
            rb.AddRelativeForce(0,0,forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            //rb.AddForce(0,0,-forwardForce * Time.deltaTime);
            rb.rotation = Quaternion.Euler(0, -180.0f, 0);
            //rb.transform.Rotate(0, 180.0f, 0.0f,Space.Self);
            rb.AddRelativeForce(0,0,forwardForce * Time.deltaTime);
        }


        //IF USING POV CAMERA
        float degreesPerSecond = 40;
        if (Input.GetKey("up"))
        {
            rb.AddRelativeForce(0,0,forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("down"))
         {
            rb.AddRelativeForce(0,0,-forwardForce * Time.deltaTime);
         }

        if (Input.GetKey("right"))
        {
            //rb.transform.Rotate(0, 90.0f, 0.0f,Space.Self);
            rb.transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);

        }

        if (Input.GetKey("left"))
        {
            //rb.transform.Rotate(0, -90.0f, 0.0f,Space.Self);
            rb.transform.Rotate(new Vector3(0, -degreesPerSecond, 0) * Time.deltaTime);
        }
        
    }
}
