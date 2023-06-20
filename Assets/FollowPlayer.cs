
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public Transform player;
    // public Vector3 offset;
    // private Vector3 rotationD;

    // rotationD = (0,1,5);
    // // Update is called once per frame
    // void Update()
    // {
    //     transform.position = player.position + offset;
    //     transform.rotation = player.rotation;
    //     if (Input.GetKey("d"))
    //     {
    //         //transform.Rotate(0, 90.0f, 0.0f,Space.Self);
    //         //LINE ABOVE ACTUALLY WORKS BUT NOT CORRECTLY

    //         transform.rotation = Quaternion.Euler(0, 90.0f, 0);
    //         transform.position = player.position + rotationD;
    //         //rb.AddForce(0,0,forwardForce * Time.deltaTime);
    //         //rb.AddForce(sidewaysForce* Time.deltaTime,0,0);
    //     }

    //     if (Input.GetKey("a"))
    //     {
    //         //rb.AddForce(-sidewaysForce* Time.deltaTime,0,0);s
    //     }
    //     if (Input.GetKey("w"))
    //     {
    //         //rb.AddForce(0,0,forwardForce * Time.deltaTime);
    //     }
    //     if (Input.GetKey("s"))
    //     {
    //         //rb.AddForce(0,0,-forwardForce * Time.deltaTime);
    //     }
    // }
    public Transform player;
    public float pLerp = .01f;
    public float rLerp = .02f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, rLerp);
    }
}

