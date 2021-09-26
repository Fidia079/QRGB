using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inpTextg : MonoBehaviour
{
  public Text textg;
    // Start is called before the first frame update
    void Start()
    {
      textg.text = GreenText.namegreen.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
