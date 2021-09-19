using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovie : MonoBehaviour
{
    public bool trup = false;
    [SerializeField] private float jumpForce, jumpOffset, runForce;
    [SerializeField] private bool onGround = false;
    [SerializeField] private Transform groundColliderTransform;

    [SerializeField] private GameObject knopkaRestart, knopkaMenu;



   [SerializeField] private GameObject knife;

    [SerializeField] public GameObject Head;

    [SerializeField] public GameObject Korpus;

    [SerializeField] private GameObject Shield;

    [SerializeField] private LayerMask groundMask;
    [SerializeField] public Animator anime;
    private GameObject udalenie;
   
    private float Power = 0.5f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        anime.SetBool("Shield", false);
        anime.SetBool("Stay", false);
        anime.SetBool("Somersaulting", false);
        anime.SetBool("Runing", false);

        anime.SetBool("Fight", false);

        anime.SetBool("Jumping", false);


        anime.SetBool("DeathKnight",false);
    }

    private void FixedUpdate()
    {
        Vector2 OverlapCirclePosition = groundColliderTransform.position;
        anime.SetBool("DeathStay", false);
        onGround = Physics2D.OverlapCircle(OverlapCirclePosition, jumpOffset, groundMask);
    }

    private void Jump ()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }



    private void onMovie (float X)
    {
        if (X>0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            knife.GetComponent<BoxCollider2D>().offset = new Vector2(0.09f, knife.GetComponent<BoxCollider2D>().offset.y);

            Shield.GetComponent<BoxCollider2D>().offset = new Vector2(0.04f, Shield.GetComponent<BoxCollider2D>().offset.y);

        } else { GetComponent<SpriteRenderer>().flipX = true;
            knife.GetComponent<BoxCollider2D>().offset = new Vector2(-0.16f, knife.GetComponent<BoxCollider2D>().offset.y);
            Shield.GetComponent<BoxCollider2D>().offset = new Vector2(-0.16f, Shield.GetComponent<BoxCollider2D>().offset.y);
        }
 

        rb.velocity = new Vector2(X*runForce, rb.velocity.y);

    }



    public void Movie(float movie_x, bool movie_y)
    {
    
   if ((movie_x != 0) && (trup == false))
            {
                onMovie(movie_x);

            }

            if (onGround == true)
            { Animations(movie_x, movie_y); }

            if ((movie_y == true) && (trup == false))
            {
                if (onGround == true)
                {
                    Jump();
                }
            }

         

        }
  
 


    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  if (helthKnight.scrollbar.size != 0)
       // { udalenie = collision.gameObject; };
       
    }


    private void Animations (float movie_x, bool movie_y)
    {
        if (movie_y == true)
        {
            anime.SetBool("Stay", false);
            anime.SetBool("Jumping", true);

        } else {anime.SetBool("Jumping", false);}


        if (movie_x != 0)
        {
            
            anime.SetBool("Runing", true);
            anime.SetBool("Stay", false);

        } else { anime.SetBool("Runing", false); if (onGround == true) { anime.SetBool("Stay", true); } }

        if (Input.GetKey(KeyCode.Q))
        {
            anime.SetBool("Shield", true); anime.SetBool("Stay", false);
            Shield.gameObject.SetActive(true);
            if (udalenie != null)
            {Destroy(udalenie); }



        } else 
        { anime.SetBool("Shield", false);
            Shield.gameObject.SetActive(false);
            if (udalenie != null)
            {
              //  helthKnight.minusHelth(Power);


                Destroy(udalenie);
            }
        }






        if (Input.GetKeyUp(KeyCode.Q))
        {
            anime.SetBool("Stay", true);
        }

        if (Input.GetKey(KeyCode.E))
        {
            anime.SetBool("Fight", true); anime.SetBool("Stay", false);

            knife.gameObject.SetActive(true);


        }
        else { anime.SetBool("Fight", false); knife.gameObject.SetActive(false); }

        if (Input.GetKeyUp(KeyCode.E))
        {
            anime.SetBool("Stay", true);
        }

        if (Input.GetKey(KeyCode.R))
        {
            anime.SetBool("Somersaulting", true); anime.SetBool("Stay", false);
        }
        else { anime.SetBool("Somersaulting", false); }

        if (Input.GetKeyUp(KeyCode.R))
        {
            anime.SetBool("Stay", true);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
        
            trup = true;
            anime.SetBool("DeathKnight", true);
            GetComponent<Rigidbody2D>().gravityScale = 0;
            Head.gameObject.SetActive(false);
            Korpus.gameObject.SetActive(false);

            knopkaMenu.gameObject.SetActive(true);
            knopkaRestart.gameObject.SetActive(true);

        }




    }


}
