using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public GameObject deathEffect;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = FindObjectOfType<Rigidbody2D>();
        Time.timeScale = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //adding up velocity to player
            rb.velocity = Vector2.up * jumpForce;
            Time.timeScale = 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //setting gameOver to true
            gameObject.SetActive(false);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            GameManager.instance.GameOver();
        }

    }

}
