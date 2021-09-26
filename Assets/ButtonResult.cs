using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonResult : MonoBehaviour
{
 public RedText redText;
 public GreenText greenText;
 public BlueText blueText;


    public void OnClickStartButton()
    {
        SceneManager.LoadScene("result");
    }
}
