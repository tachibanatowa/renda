using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tachi : MonoBehaviour
{
	
	
	//リザルトへ数値を渡す用
	public static int resultCnt;

	
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
			//カウントをTextコンポーネントへ 
			this.GetComponent<Text>().text = InGameInput.Cnt1 + "クリック";

			// もしtimerが0になったら
			if (InGametime.GameTime)
			{
				
			}
		}
	}
}
