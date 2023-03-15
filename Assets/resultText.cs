using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultText : MonoBehaviour
{
    private InGameInput tuchi;


    // Start is called before the first frame update
    void Start()
    {
        tuchi = new InGameInput();
    }

    // Update is called once per frame
    void Update()
    {
        int click = tuchi.Clickresult();

        this.GetComponent<Text>().text = "クリック回数は" + click.ToString() + "でした";
    }
}
