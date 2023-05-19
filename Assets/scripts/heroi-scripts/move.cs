using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroiAndarCodigo : MonoBehaviour
{
    public bool face = true;

    public transform heroiT;

    public float vel = 2.5f;

    public Rigidbody2D heroiRB;

    public bool liberapulo = false;
   
    void Start()
    {
        heroiT = GetComponent<transform> ();
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
            transform.translate(new Vector2(vel * Time.deltaTime,0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.translate(new Vector2(-vel * Time.deltaTime,0));
        }
        if(Input.GetKeyDown(KeyCode.Space)){}
    }
    void flip ()
    {
       face = !face;

       Vector3 scala = heroiT.localscale;

       scala.x *= -1;

       heroiT.localscale = scala;
    }
    voidOnCollisionEnter2D(Collision2D outro)
    {
        if(outro.gameObject.Comparetag("chao"))
    
        {
            liberapulo = true;
        }
    }
    voidOnCollisionExit2D(Collision2D outro)
    {
        if(outro.gameObject.Comparetag("chao"))
    
        {
            liberapulo = false;
        }
    }
    
}
