using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D Player;
    public float Speed;
    Vector2 Jump;
    public GameObject Camera;
    public GameObject pauseScreen;
    public GameObject Outcome_Screen;
    public GameObject Win_text;
    public GameObject Lose_text;


    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        Speed = 3;
        pauseScreen.SetActive(false);
        Outcome_Screen.SetActive(false);

    }

    
    void Update()
    {
        Jump = new Vector2(0, 5);

        if (Input.GetButtonDown("Jump"))
        {
            Player.AddForce(Jump, ForceMode2D.Impulse);
        }
        Vector3 dest = new Vector3 (transform.position.x, 0, -10);
        Camera.transform.position = Vector2.Lerp(Camera.transform.position, dest, Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            Player.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * Speed, Player.velocity.y);
        }
        
        
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
           Outcome_Screen.SetActive(true);
            Win_text.SetActive(false);
            Lose_text.SetActive(true);
        }

        if (collision.CompareTag("finish"))
        {
            Outcome_Screen.SetActive(true);
            Win_text.SetActive(true);
            Lose_text.SetActive(false);
        }
    }
}
