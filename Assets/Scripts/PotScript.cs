using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    public Transform myFlowerSpawnPos;

    private GlobalFlowerScript myGlobalFlowers;

    public GameObject[] flowerList;


    private void Start()
    {
        myGlobalFlowers = GameObject.FindObjectOfType<GlobalFlowerScript>();
    }

    private void OnCollisionEnter(Collision aCollision)
    {

        if (aCollision.gameObject.GetComponent<PotScript>())
        {
            return;
        }

        if (aCollision.collider.CompareTag("canPickUp"))
        {
            GameObject newFlower = Instantiate(flowerList[Random.Range(0,flowerList.Length)], myFlowerSpawnPos);
            newFlower.transform.position = myFlowerSpawnPos.transform.position;
            newFlower.transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0));
            GameObject.Destroy(aCollision.gameObject);
            Debug.Log("Spawn Flower");
        }

        }
       
    }
