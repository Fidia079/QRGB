using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marTextg : MonoBehaviour
{
  public Text textmg;
  public static int pointg = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointg = (256 - Mathf.Abs(GreenText.namegreen - MakeColor.ansg)) * 100 / 256 ;
        textmg.text = pointg.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
