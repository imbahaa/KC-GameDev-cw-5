using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update

    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
