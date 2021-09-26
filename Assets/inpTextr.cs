using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inpTextr : MonoBehaviour
{
  public Text textr;
    // Start is called before the first frame update
    void Start()
    {
      textr.text = RedText.namered.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
