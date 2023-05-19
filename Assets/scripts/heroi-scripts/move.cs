using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroiAndarCodigo : MonoBehaviour
{
    public bool face = true;

    public Transform heroiT;

    public float vel = 2.5f;
    public float force = 5f;

    public Rigidbody2D heroiRB;

    public bool liberapulo = false;
   
    void Start()
    {
        heroiT = GetComponent<Transform> ();
        heroiRB = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && !face)
        {
            flip();
        }

        else if(Input.GetKey(KeyCode.LeftArrow) && face)
        {
            flip();
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime,0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime,0));
        }
        if(Input.GetKeyDown(KeyCode.Space) && liberapulo == true )
        {
            heroiRB.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
    }
    void flip ()
    {
       face = !face;    

       Vector3 scala = heroiT.localScale;

       scala.x *= -1;

       heroiT.localScale = scala;
    }
    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
    
        {
            liberapulo = true;
        }
    }
    void OnCollisionExit2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao"))
    
        {
            liberapulo = false;
        }
    }
}
