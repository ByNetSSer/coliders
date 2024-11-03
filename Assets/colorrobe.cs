using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorrobe : MonoBehaviour
    
{
    private SpriteRenderer renderizado;

    // Start is called before the first frame update

    void Start()
    {
        renderizado = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("le robe su color");
        renderizado.color = new Color(collision.gameObject.GetComponent<SpriteRenderer>().color.r, collision.gameObject.GetComponent<SpriteRenderer>().color.g, collision.gameObject.GetComponent<SpriteRenderer>().color.b) ;
        //collision.gameObject.GetComponent<SpriteRenderer>().color
    }
}
