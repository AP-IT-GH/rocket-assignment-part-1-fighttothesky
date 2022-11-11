using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCoin : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            score++;
            scoreText.text = score.ToString();
            Debug.Log(score);
        }
    }
}
