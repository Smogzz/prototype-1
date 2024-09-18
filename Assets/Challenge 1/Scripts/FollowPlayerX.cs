using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    public float turnSpeed = 20.0f;
    public float speed = 20.0f;
     public float forwardInput;
    public float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * VerticalInput);
     transform.position = plane.transform.position + offset;
    }
}
