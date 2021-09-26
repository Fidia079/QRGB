using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marTextr : MonoBehaviour
{
  public Text textmr;
  public static int pointr = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointr = (256 - Mathf.Abs(RedText.namered - MakeColor.ansr)) * 100 / 256;
        textmr.text = pointr.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
