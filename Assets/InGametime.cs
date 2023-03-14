using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGametime
{
    //カウントダウン
    public float countdown = 5.0f;

    //スタートの確認用
    bool start;
    //ゲーム時間が終わりか途中かの確認用
    public static bool GameTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            start = true;
        }


        if (start)
        {


            if (countdown <= 0)
            {
                GameTime = true;
                
            }
            else
            {
                GameTime = false;


            }

            // タイマーを減らす
            //for (float g=0; g <= countdown; g = g + 1.0f)
            //{
                countdown -= 1.0f;
            //}

            SceneManager.LoadScene("ResultScene");
        }

        
    }

}
