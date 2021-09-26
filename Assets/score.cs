using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static int Score = 0;
    public static int qtimes = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text scoreLabel = GameObject.Find("Canvas/ScoreText").GetComponent<Text>();
        Score += marTextr.pointr + marTextg.pointg + marTextb.pointb;
        scoreLabel.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
