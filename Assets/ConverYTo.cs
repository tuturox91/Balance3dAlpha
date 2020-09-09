using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConverYTo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject SpawnPos;
    public Material Rock;
    public Material Paper;
    public Material Wood;

    public Mesh RockM;
    public Mesh PaperM;

    private GameObject player;

    public enum myEnum // your custom enumeration
    {
        Paper,
        Rock,
        Wood
    };

    public myEnum TypePlayer;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            if (other.gameObject.GetComponent<MovementScript>().TypeOfPlayer != 2)
            {

                if (TypePlayer == myEnum.Rock)
                {
                    StartCoroutine(StartSpawnRock());
                }

            }
            if (other.gameObject.GetComponent<MovementScript>().TypeOfPlayer != 1)
            {
                if (TypePlayer == myEnum.Paper)
                {
                    StartCoroutine(StartSpawnPaper());
                }
            }
            if (other.gameObject.GetComponent<MovementScript>().TypeOfPlayer != 3)
            {
                if (TypePlayer == myEnum.Wood)
                {
                    StartCoroutine(StartSpawnWood());
                }
            }

        }
    }
    //0.1 mass
    //0.33 speed;
    IEnumerator StartSpawnRock()
    {
        player.gameObject.transform.position = SpawnPos.transform.position;
        player.gameObject.GetComponent<MovementScript>().FullStop = true;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        yield return new WaitForSeconds(2f);
        player.gameObject.GetComponent<Rigidbody>().mass = 4f;
        player.gameObject.GetComponent<MovementScript>().Speed = 4f;
        player.gameObject.GetComponent<MeshFilter>().mesh = RockM;
        player.gameObject.GetComponent<MeshCollider>().sharedMesh = RockM;
        player.gameObject.GetComponent<MovementScript>().TypeOfPlayer = 2;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        player.gameObject.GetComponent<MeshRenderer>().material = Rock;
        player.gameObject.GetComponent<MovementScript>().FullStop = false;

    }

    IEnumerator StartSpawnWood()
    {
        player.gameObject.transform.position = SpawnPos.transform.position;
        player.gameObject.GetComponent<MovementScript>().FullStop = true;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        yield return new WaitForSeconds(2f);
        player.gameObject.GetComponent<Rigidbody>().mass = 0.9f;
        player.gameObject.GetComponent<MovementScript>().Speed = 1.2f;
        player.gameObject.GetComponent<MeshFilter>().mesh = RockM;
        player.gameObject.GetComponent<MeshCollider>().sharedMesh = RockM;
        player.gameObject.GetComponent<MovementScript>().TypeOfPlayer = 3;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        player.gameObject.GetComponent<MeshRenderer>().material = Wood;
        player.gameObject.GetComponent<MovementScript>().FullStop = false;

    }


    IEnumerator StartSpawnPaper()
    {
        player.gameObject.transform.position = SpawnPos.transform.position;
        player.gameObject.GetComponent<MovementScript>().FullStop = true;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        yield return new WaitForSeconds(2f);
        player.gameObject.GetComponent<Rigidbody>().mass = 0.1f;
        player.gameObject.GetComponent<MovementScript>().Speed = 0.20f;
        player.gameObject.GetComponent<MeshFilter>().mesh = PaperM;
        player.gameObject.GetComponent<MeshCollider>().sharedMesh = PaperM;
        player.gameObject.GetComponent<MovementScript>().TypeOfPlayer = 1;
        player.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        player.gameObject.GetComponent<MeshRenderer>().material = Paper;
        player.gameObject.GetComponent<MovementScript>().FullStop = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
