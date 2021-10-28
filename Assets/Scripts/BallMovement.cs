using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;

    public void Move()
    {
        var randomVector3Force = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        rigidbody.AddForce(randomVector3Force, ForceMode.Impulse);
    }
}
