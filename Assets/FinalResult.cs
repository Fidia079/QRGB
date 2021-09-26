using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Text FinalLabel = GameObject.Find("Canvas/Score").GetComponent<Text>();
      score.Score += marTextr.pointr + marTextg.pointg + marTextb.pointb;
      FinalLabel.text = score.Score.ToString();

      Text LastComment = GameObject.Find("Canvas/Comment").GetComponent<Text>();
      if(score.Score <= 0){
        LastComment.text = "ふざけるのも大概にしろ";
      }else if(score.Score >= 1 && score.Score <= 800){
        LastComment.text = "残念！COBOLを触りましょう";
      }else if(score.Score >= 801 && score.Score <= 1000){
        LastComment.text = "Go言語を触ると良いことあるかも";
      }else if(score.Score >= 1001 && score.Score <= 1100){
        LastComment.text = "普通なので特になし";
      }else if(score.Score >= 1101 && score.Score <= 1300){
        LastComment.text = "最高評価まであと一歩！！頑張れ！";
      }else if(score.Score >= 1301 && score.Score <= 1500){
        LastComment.text = "天才じゃん";
      }
    }

}
