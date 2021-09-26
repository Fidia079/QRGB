using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ansTextb : MonoBehaviour
{
  public Text anstextb;
    // Start is called before the first frame update
    void Start()
    {
      anstextb.text = MakeColor.ansb.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
