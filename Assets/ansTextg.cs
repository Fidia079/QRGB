using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ansTextg : MonoBehaviour
{
  public Text anstextg;
    // Start is called before the first frame update
    void Start()
    {
      anstextg.text = MakeColor.ansg.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
