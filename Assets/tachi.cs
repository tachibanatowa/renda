using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tachi : MonoBehaviour
{
	// 表示する時間を表示.
	public Text second;
	public Text secondText;
	public Text touchText;
	public InGameCount countprefab; 


	//リザルトへ数値を渡す用
	public static int resultCnt;

	private InGametime timer;
	private InGameCount count1;


	public static int Cnt;

	private void Start()
	{
		// インスタンスを生成.
		timer = new InGametime();



		var hozi = FindObjectOfType<InGameCount>();
		//Instantiate プレハブを作る機能
		//シーン上にクローンがあれば、instantiateとdontdestroyをしない

		if (null == hozi)
		{
			count1 = Instantiate<InGameCount>(countprefab);
			DontDestroyOnLoad(count1.gameObject);
		}
		else
		{
            Destroy(hozi.gameObject);
			count1 = Instantiate<InGameCount>(countprefab);
			DontDestroyOnLoad(count1.gameObject);

		}
	
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
			//クリックしたらcountする
			if (Input.GetMouseButtonDown(0))
			{
				count1.ClickCount();

			}
			// 現在のクリック回数を取得する.
			int click = count1.ClickNam();

			//カウントをTextコンポーネントへ 
			touchText.text = click.ToString() + "クリック";
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

