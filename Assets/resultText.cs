using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultText : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //シーンオブジェクトからInGameCountをさがして　　インスペクターで引っ付いてるInGameCount
        var inGameCount = FindObjectOfType<InGameCount>();
        int click = 0;
        click = inGameCount.Clickresult();
        //
        this.GetComponent<Text>().text = "クリック回数は" + click.ToString() + "でした";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
