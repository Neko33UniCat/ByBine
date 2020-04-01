using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject[] Cameras;
    public int CameraNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            CameraNum = (CameraNum+1) % Cameras.Length;
            for(int i = 0; i < Cameras.Length; i++)
            {
                if (i == CameraNum)
                {
                    Cameras[i].SetActive(true);
                }
                else
                {
                    Cameras[i].SetActive(false);
                }
            }
        }
    }
}
