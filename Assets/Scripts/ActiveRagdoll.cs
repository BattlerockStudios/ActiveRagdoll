using UnityEngine;

public class ActiveRagdoll : MonoBehaviour
{
    [SerializeField]
    private float force = 10f;
    public Rigidbody leftLeg;
    public Rigidbody rightLeg;

    public Transform leftKneeTargetTransform;
    public Transform rightKneeTargetTransform;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //leftLeg.AddForce((leftLeg.transform.position - leftKneeTargetTransform.position) * force, ForceMode.Impulse);
            leftLeg.transform.position = Vector3.MoveTowards(leftLeg.transform.position, leftKneeTargetTransform.position, force * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            rightLeg.AddForce((rightLeg.transform.position - rightKneeTargetTransform.position), ForceMode.Impulse);
        }
    }
}
