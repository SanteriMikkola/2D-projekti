using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn2 : MonoBehaviour
{
    public Transform ResPoint;
    public Transform ResPoint2;
    public Transform CheckPoint;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Respawn2"))
        {
            ResPoint.transform.position = ResPoint2.position;

            Destroy(CheckPoint.gameObject);
            Destroy(other.gameObject);

        }
    }
}
