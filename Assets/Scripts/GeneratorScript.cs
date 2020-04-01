using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    public GameObject Bacteria;
    public int N;
    public float DyingProbability;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generate());
    }
    IEnumerator Generate()
    {
        for(int i = 0; i < N; i++)
        {
            GameObject  Bac = (GameObject)Instantiate(Bacteria, transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
            Bac.GetComponent<BacteriaScript>().DyingProbability = DyingProbability;
            yield return new WaitForSeconds(0.001f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
