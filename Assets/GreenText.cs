using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenText : MonoBehaviour
{
  public static int namegreen = 0;
  // Start is called before the first frame update
  void Start()
  {
      
  }

  public void GetTextG(){
    Text inputTextG = GameObject.Find("GreenTextField/Text").GetComponent<Text>();
    namegreen = int.Parse(inputTextG.text);

    Debug.Log(namegreen);

    InputField formG =  GameObject.Find("GreenTextField").GetComponent<InputField>();
    formG.text = "";
  }
}
