using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class blockScript : MonoBehaviour
{   
    
    
    Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>();
     
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Score>().points += 100;
        Destroy(gameObject);
       
    }
   
    // Update is called once per frame
    void Update()
    {
           
    }
    

    
    
        
    }





