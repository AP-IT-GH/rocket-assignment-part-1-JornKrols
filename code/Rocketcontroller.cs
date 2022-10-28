using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketcontroller : MonoBehaviour
{
    [SerializeField] float thrusterforce = 10f;
    [SerializeField] float tiltingforce = 10f;

    bool thrust = false;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space);

        if(!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f ,0f , (tilt * tiltingforce * Time.deltaTime))));
        }

        rb.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if(thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrusterforce * Time.deltaTime);
        }
    }
}
