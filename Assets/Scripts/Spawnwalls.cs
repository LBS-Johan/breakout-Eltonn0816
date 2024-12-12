using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Spawnwalls : MonoBehaviour
{
    public GameObject block; 
    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < 16; j++)
        {

            for (int i = 0; i < 6; i++)
            {
                
                Instantiate(block, new Vector3(j -7.5f, i *0.65f, 0), Quaternion.identity);

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
