using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballscript : MonoBehaviour
{   
    Rigidbody2D  rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -8);
    }
    // Update is called once per frame
    void Update()
    {
        
        float speed = 6.5f;
        rb.velocity = rb.velocity.normalized * speed;
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(1);
        }
    }
}
