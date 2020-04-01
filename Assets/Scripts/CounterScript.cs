using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public int num;
    public Text TimeText;
    public Text numText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeText.text = "Time : " + Time.time + " sec";
        numText.text = "Bacteria : " + num + " 匹";
    }
}
