using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInput : MonoBehaviour
{
	// カウント用変数
	int Cnt;
	// 結果表示用変数
	int result;
	//リザルトへ数値を渡す用
	public static int resultCnt;
	//tachiに渡す用
	public static int Cnt1;

	bool start;

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

			// マウスがクリックされたら
			if (Input.GetMouseButtonDown(0))
			{
				// カウントを増やす
				Cnt++;
			}

			//カウントをTextコンポーネントへ 
			Cnt1 = Cnt;
			resultCnt = Cnt;
			

		}
	}
}

