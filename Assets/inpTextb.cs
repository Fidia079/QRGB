using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inpTextb : MonoBehaviour
{
  public Text textb;
    // Start is called before the first frame update
    void Start()
    {
      textb.text = BlueText.nameblue.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
