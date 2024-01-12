using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float GravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
        Controller();
    }

    // Update is called once per frame
    void Controller()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          PlayerRb.AddForce(Vector3.up * GravityModifier *1000);
        }
    }
}
