using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawControll : MonoBehaviour
{
    public float RotSpeed;
    public Transform Pos1, pos2;

    Vector2 nextPos;
    public Transform startPos;
    void Start()
    {
        nextPos = startPos.position;
    }
    void Update()
    {
        if (transform.position == Pos1.position)
        {
            nextPos = pos2.position;
            transform.Rotate(0, 0, RotSpeed);
        }

        if (transform.position == pos2.position)
        {
            nextPos = Pos1.position;
            transform.Rotate(0, 0, RotSpeed);
        }
    }
}
