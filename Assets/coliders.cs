using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int direccionx = 1;
    public int direcciony = 1;
    public float g;
    private SpriteRenderer renderizado;
    private Rigidbody2D rigid;
    public bool velocity = true;
    // Start is called before the first frame update
    void Start()
    {
        renderizado = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (velocity)
        {
            rigid.velocity = new Vector2(direccionx * g, direcciony * g);
        }
        else
        {
            rigid.AddForce(new Vector2(direccionx * g, direcciony * g));
        }
        
    } 
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "murosx")
        {
            direcciony = direcciony * -1;
            renderizado.flipY = !renderizado.flipY;
        }
        if (collision.gameObject.tag == "murosy")
        {
            
            renderizado.flipX = !renderizado.flipX;
            direccionx = direccionx * -1;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        renderizado.color = new Color(Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f);
    }
}


