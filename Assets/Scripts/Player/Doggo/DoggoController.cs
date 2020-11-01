using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoggoController : UniversalPlayerItems
{
    private Rigidbody2D doggo_RB;
    private Animator animator;
    private Vector2 movement;


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

        if (other.gameObject.CompareTag("House 1") && controller.level == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.CompareTag("House 2") && controller.level == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (other.gameObject.CompareTag("House 3") && controller.level == 3)
        {
            SceneManager.LoadScene(2);
        }
        else if(other.gameObject.CompareTag("Hosue 4") && controller.level == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
