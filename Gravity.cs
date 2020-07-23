using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravityFactor = -10f;

    public void Pull(Transform body)
    {
        Vector3 targetDirection = (body.position - transform.position).normalized;
        Vector3 bodyUpDirection = body.up;

        body.rotation = Quaternion.FromToRotation(bodyUpDirection, targetDirection) *  body.rotation;
        body.GetComponent<Rigidbody>().AddForce(targetDirection * gravityFactor);
    }
}
