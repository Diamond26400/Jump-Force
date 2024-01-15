using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float GravityModifier;
    public bool isOnGround = true;
    public float  jumpForce =  100.0f;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
    }

    // Update is called once per frame
   void Update()
   {
     
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            PlayerRb.AddForce(Vector3.up * jumpForce* GravityModifier);
            
           isOnGround =  false;
        }
   }
   
    public void OnCollisionEnter(Collision collision)
    {
      
       isOnGround =  true;
    }

}
