using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Destroy : MonoBehaviour
{

    // Start is called before the first frame update

    public long score = 0;
    public TextMeshProUGUI scoreText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Int64.TryParse(scoreText.text, out score);
        score++;
        scoreText.text = score.ToString();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
