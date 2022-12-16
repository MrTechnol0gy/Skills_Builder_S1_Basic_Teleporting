using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 500f;    
    
    void OnTriggerEnter(Collider other)
    {
        JumpyJumpy(other);
    }

    void JumpyJumpy(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.AddForce(0, jumpForce, 0);

        }
    }
}
