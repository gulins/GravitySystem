using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(Rigidbody))]
public class Body : MonoBehaviour
{
    public GameObject heavyBody;

    Gravity gravity;


    void Start() { gravity = heavyBody.GetComponent<Gravity>(); }

    void FixedUpdate() { gravity.Pull(transform); }
}
