using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedText : MonoBehaviour
{
    public static int namered = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void GetTextR(){
      Text inputTextR = GameObject.Find("RedTextField/Text").GetComponent<Text>();
      namered = int.Parse(inputTextR.text);

      Debug.Log(namered);

      InputField formR =  GameObject.Find("RedTextField").GetComponent<InputField>();
      formR.text = "";
    }
}
