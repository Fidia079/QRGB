using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marTextb : MonoBehaviour
{
  public Text textmb;
  public static int pointb = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointb = (256 - Mathf.Abs(BlueText.nameblue - MakeColor.ansb)) * 100 / 256 ;
        textmb.text = pointb.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
