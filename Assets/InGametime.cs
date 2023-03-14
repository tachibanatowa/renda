
public class InGametime
{
    //カウントダウン(現在の時間)
    public float countdown;

    //スタートの確認用
    bool start = false;
    
    //ゲーム時間が終わりか途中かの確認用
    public static bool GameTime;

    // タイマーを開始させる関数.
    // 時間を外から設定できたら神.
    public void Start(float time)
    {
        countdown = time;
        // フラグを立てる.
        start = true;
    }

    // タイマーが開始されているかチェックする関数.
    public bool IsStart()
    {
        return start;
    }

    // タイマーを更新させる関数.
    // 引く時間を引数から持ってくればUnityに依存しない.
    public void UpdateTime(float minusTime)
    {
        //float oneFrame = 1 / 60f;
        countdown -= minusTime;
    }
    
    // 時間を取得する関数.
    public float GetTime()
    {
        return countdown;
    }

    // public void Update()
    // {
    //
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         start = true;
    //     }
    //
    //
    //     if (start)
    //     {
    //
    //
    //         if (countdown <= 0)
    //         {
    //             GameTime = true;
    //             
    //         }
    //         else
    //         {
    //             GameTime = false;
    //
    //
    //         }
    //
    //         // タイマーを減らす
    //         //for (float g=0; g <= countdown; g = g + 1.0f)
    //         //{
    //             countdown -= 1.0f;
    //         //}
    //
    //         SceneManager.LoadScene("ResultScene");
    //     }
    // }
}
