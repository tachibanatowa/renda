using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tachi : MonoBehaviour
{
	// 表示する時間を表示.
	public Second second;
	public Text secondText;
	public Text touchText;

	//リザルトへ数値を渡す用
	public static int resultCnt;

	private InGametime timer;

	private void Start()
	{
		// インスタンスを生成.
		timer = new InGametime();
	}

	// フレーム毎に呼ばれる関数
	void Update()
	{
		// ボタンを押したらカウントを開始.
		if (Input.GetMouseButtonDown(0) && timer.IsStart() == false)
		{
			// タイマーをスタートさせる.
			timer.Start(5.0f);
		}

		// タイマーがスタートしてるか？.
		if (timer.IsStart())
		{
			//カウントをTextコンポーネントへ 
			touchText.text = InGameInput.Cnt1 + "クリック";

			// 時間を更新させる.
			timer.UpdateTime(Time.deltaTime);


			// 現在の時間を取得する.
			float time = timer.GetTime();

			// 時間の表示する値を変更.
			// あとで.
			//second.SetTime(time);
			secondText.text = time.ToString("f1");

			// もしtimerが0になったら
			if (time <= 0f)
			{
				// リザルトに遷移.
				SceneManager.LoadScene("ResultScene");
			}
		}
	}
}

