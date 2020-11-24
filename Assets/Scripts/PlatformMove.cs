using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform Pos1, pos2;
    public float speed;
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
        }
        
        if (transform.position == pos2.position)
        {
            nextPos = Pos1.position;
        }
        transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
