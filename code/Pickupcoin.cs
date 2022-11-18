using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickupcoin : MonoBehaviour
{
    [SerializeField] Text scoreboardText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score+=1;
            print(score);
            Destroy(gameObject);
            scoreboardText.text = score.ToString();
        }
    }
}
