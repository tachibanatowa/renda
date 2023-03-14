using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 時間の表示を更新してあげる.
public class Second : MonoBehaviour
{
    //時間を表示するText型の変数
    public Text timeText;

    bool start;

    // 描画の処理が分離できる.
    public void SetTime(float countdown)
    {
        timeText.text = countdown.ToString("f1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
