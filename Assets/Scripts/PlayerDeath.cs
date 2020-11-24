using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public static PlayerDeath gm;
    public Transform ResPoint;
    public Transform player;
    public float SpawnDelay = 2f;

    public void Start()
    {
            gm = GameObject.FindWithTag("DeathBox").GetComponent<PlayerDeath>();
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeathBox"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
