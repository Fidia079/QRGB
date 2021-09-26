using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextQuiz : MonoBehaviour
{

  public void OnClickStartButton()
  {
    score.qtimes += 1;

    if(score.qtimes <= 4)
    {
      SceneManager.LoadScene("SampleScene");
    }
    else
    {
      SceneManager.LoadScene("Final");
    }

  }
}
