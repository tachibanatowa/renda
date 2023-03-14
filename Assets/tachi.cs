using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tachi : MonoBehaviour
{
	// カウント用変数
	int Cnt;
	// 結果表示用変数
	int result;
	// タイマー用変数
	int timer;

	public static int resultCnt;

	//カウントダウン
	public float countdown = 5.0f;

	//時間を表示するText型の変数
	public Text timeText;

	bool start;

	// フレーム毎に呼ばれる関数
	void Update()
	{
		if(Input.GetMouseButtonDown(0))
        {
			start = true;
        }


		if (start)
		{

			// マウスがクリックされたら
			if (Input.GetMouseButtonDown(0))
			{
				// カウントを増やす
				Cnt++;
			}

			//カウントをTextコンポーネントへ 
			this.GetComponent<Text>().text = Cnt + "クリック";

			// もしtimerが0になったら
			if (countdown <= 0)
			{
				// カウントを0に戻す
				//カウントをTextコンポーネントへ 
				this.GetComponent<Text>().text = "結果は" + result + "クリックでした～";
			}
			else
			{

				result = Cnt;
				resultCnt = Cnt;
			}
			// タイマーを減らす
			countdown -= Time.deltaTime;
		}
	}
}
