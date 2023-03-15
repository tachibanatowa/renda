using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultText : MonoBehaviour
{
    private InGameCount tuchi;


    // Start is called before the first frame update
    void Start()
    {
        tuchi = new InGameCount();
    }

    // Update is called once per frame
    void Update()
    {
        int click = tuchi.Clickresult();

        this.GetComponent<Text>().text = "クリック回数は" + click.ToString() + "でした";
    }
}
