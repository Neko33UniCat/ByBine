using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacteriaScript : MonoBehaviour
{
    public float DyingProbability;
    public float time;
    GeneratorScript Counter;
    // Start is called before the first frame update
    void Start()
    {
        Counter = GameObject.Find("Generator-Counter").GetComponent<GeneratorScript>();
        Counter.num += 1;
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(time >= 1.0f)
        {
            float r = Random.value;
            if(r <= DyingProbability)
            {
                Counter.num -= 1;
                Destroy(gameObject);
            }
            else
            {
                Instantiate(gameObject);
            }
            time -= 1.0f;
        }
        time += Time.fixedDeltaTime;
    }
}
