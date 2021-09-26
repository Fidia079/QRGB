
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeColor : MonoBehaviour
{

    public static int ansr = 0;
    public static int ansg = 0;
    public static int ansb = 0;

    // Start is called before the first frame update
    void Start()
    {
        colors();
    }

    public void colors()
    {
      float red = Random.Range(0f, 1f);
      float green = Random.Range(0f, 1f);
      float blue = Random.Range(0f, 1f);

      ansr = (int)(red * 255);
      ansg = (int)(green * 255);
      ansb = (int)(blue * 255);

      GetComponent<Renderer>().material.color = new Color(red, green, blue, 1);
    }
}
