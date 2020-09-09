using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruoyThis : MonoBehaviour
{

    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            
            Instantiate(Prefab, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
