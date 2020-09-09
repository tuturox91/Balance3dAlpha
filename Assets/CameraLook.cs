using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public GameObject PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CamPos = PlayerPos.transform.position;
        CamPos.y += 3.043f;
        CamPos.z += -2.6f;
        //CamPos.x += 1.8f;
        this.transform.position = CamPos;
    }
}
