using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoggoController : UniversalPlayerItems
{
    private Rigidbody2D doggo_RB;
    private Animator animator;
    private Vector2 movement;

    private bool house1Completed;
    private bool house2Completed;
    private bool house3Completed;
    private bool house4Completed;

    public static int level = 1;


    [Header("Game Controller")]
    [SerializeField] private GameObject gameController;
    [SerializeField] private GameController controller;

    [Header("Audio")]
    [SerializeField] private AudioSource audioClip;
    [SerializeField] private AudioClip gnomed;

    [Header("Doggo Move Speed!")]
    public float doggo_MoveSpeed;

    //Setting Inherited Fields
    public override Rigidbody2D Rigidbody
    {
        get
        {
            return doggo_RB;
        }
    }

    public override float Speed
    {
        get
        {
            return doggo_MoveSpeed;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        doggo_RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        controller = gameController.GetComponent<GameController>();
    }


    private void Update()
    {
        //Input for movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Animations for Movement
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //Quit Game Options
        QuitGame();
    }


    void FixedUpdate()
    {
        //Rigidbody movement
        Rigidbody.MovePosition((Vector2) transform.position + movement * doggo_MoveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("gnomed"))
        {
            other.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            audioClip.PlayOneShot(gnomed);
        }

        if (other.gameObject.CompareTag("House 1") && level == 1)
        {
            SceneManager.LoadScene(2);
            level = 2;
        }
        else if (other.gameObject.CompareTag("House 2") && level == 2)
        {
            SceneManager.LoadScene(2);
            level = 3;
        }
        else if (other.gameObject.CompareTag("House 3") && level == 3)
        {
            SceneManager.LoadScene(2);
            level = 4;
        }
        else if(other.gameObject.CompareTag("House 4") && level == 4)
        {
            SceneManager.LoadScene(2);
            level = 5;
        }
        else if (other.gameObject.CompareTag("Win") && level == 5)
        {
            SceneManager.LoadScene(3);
        }
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
