using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInput : MonoBehaviour
{
	// カウント用変数
	int Cnt;

	//tachiに渡す用
	public static int resultNam;


	//マウスをクリックしたら呼び出され　カウントされるようにしている
	//次いでにリザルト用の変数に数値を入れている
	public void ClickCount()
	{
		Cnt++;
		resultNam = Cnt;
	}

	//ゲーム画面に回数を表示するため
	public int ClickNam()
	{
		return Cnt;
	}

	//リザルトでゲーム画面でクリックした回数を渡すため
	public int Clickresult()
	{
		
		return resultNam;
	}

}

