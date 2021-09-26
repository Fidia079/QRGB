using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueText : MonoBehaviour
{
   public static int nameblue = 0;
   // Start is called before the first frame update
   void Start()
   {

   }

   public void GetTextB(){
     Text inputTextB = GameObject.Find("BlueTextField/Text").GetComponent<Text>();
     nameblue = int.Parse(inputTextB.text);

     Debug.Log(nameblue);

     InputField formB =  GameObject.Find("BlueTextField").GetComponent<InputField>();
     formB.text = "";
   }
}
