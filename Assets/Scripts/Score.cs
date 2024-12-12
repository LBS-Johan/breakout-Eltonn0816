using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int points;
    TextMeshProUGUI scoreUI; 
    // Start is called before the first frame update
    void Start()
    {
        scoreUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = points.ToString();
        if (points > 13600)
        {
            SceneManager.LoadScene(2);
        }
    }
}
