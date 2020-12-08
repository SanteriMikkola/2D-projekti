using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public static PlayerDeath gm;
    public Transform ResPoint;
    public Transform player;

    public void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeathBox"))
        {
            player.transform.position = ResPoint.position;
        }
    }
}
