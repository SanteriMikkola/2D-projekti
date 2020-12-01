using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawControll : MonoBehaviour
{
    public float RotationSpeed;
    public Transform Pos1, pos2;
    public GameObject Saw;
    public float speed;
    Vector2 nextPos;
    public Transform startPos;

    public bool rotationControll;
    public float RotZ;
    void Start()
    {
        nextPos = startPos.position;
    }
    void Update()
    {
        if (transform.position == Pos1.position)
        {
            nextPos = pos2.position;
            Saw.transform.Rotate(0, 0, RotationSpeed);
            rotationControll = true;
        }
        if (transform.position == pos2.position)
        {
            nextPos = Pos1.position;
            Saw.transform.Rotate(0, 0, RotationSpeed);
            rotationControll = false;
        }
        transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        if (rotationControll == false)
        {
            RotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            RotZ -= Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, RotZ);
    }
}