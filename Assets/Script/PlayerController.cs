using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float GravityModifier;
    public bool isOnGround;
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
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
          PlayerRb.AddForce(Vector3.up * GravityModifier *1000);
          isOnGround = true;
        }
        else if (isOnGround || !isOnGround)
        {
            isOnGround = false;
        }
    }
}
