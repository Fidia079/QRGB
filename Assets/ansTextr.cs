using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ansTextr : MonoBehaviour
{
  public Text anstextr;
    // Start is called before the first frame update
    void Start()
    {
      anstextr.text = MakeColor.ansr.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
