using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{
    [SerializeField]
    private float force = 10f;
    public Rigidbody leftLeg;
    public Rigidbody rightLeg;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            leftLeg.AddForce(transform.up * force, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            rightLeg.AddForce(transform.up * force, ForceMode.Impulse);
        }
    }
}
