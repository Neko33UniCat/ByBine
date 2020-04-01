using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorScript : MonoBehaviour
{
    public GameObject Bacteria;
    public int N = 4;
    public float DyingProbability = 0.4f;
    public InputField BacteriaNum;
    public GameObject BacteriaNumObject;
    public InputField DyingText;
    public GameObject DyingTextObject;
    public GameObject StartButton;
    public Text Info;
    int flag = 0;

    public int num;
    float StartTime;
    public Text TimeText;
    public Text numText;
    // Start is called before the first frame update
    void Start()
    {
        BacteriaNum.text = "4";
        DyingText.text = "0.4";
        StartCoroutine(Generate());
    }
    IEnumerator Generate()
    {
        while (flag==0)
        {
            yield return new WaitForSeconds(0.1f);
        }
        for (int i = 0; i < N; i++)
        {
            GameObject Bac = (GameObject)Instantiate(Bacteria, transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
            Bac.GetComponent<BacteriaScript>().DyingProbability = DyingProbability;
            yield return new WaitForSeconds(0.01f);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (flag == 1)
        {
            TimeText.text = "Time : " + (Time.time - StartTime).ToString() + " sec";
            numText.text = "Bacteria : " + num + " 匹";
        }
    }
    public void InputNums()
    {
        N = int.Parse(BacteriaNum.text);
    }
    public void InputDying()
    {
        DyingProbability = float.Parse(DyingText.text);
    }
    public void SimulateStart()
    {
        flag = 1;
        StartTime = Time.time;
        Destroy(BacteriaNumObject);
        Destroy(DyingTextObject);
        Destroy(StartButton);
        Info.text = "初めの細菌の数 : " + N + "\n細菌が死ぬ確率 : " + DyingProbability;
    }
}
