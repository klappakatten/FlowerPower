using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    public Transform myFlowerSpawnPos;

    private GlobalFlowerScript myGlobalFlowers;

    public GameObject[] flowerList;

    public GameObject[] flowerList2;
    public GameObject[] flowerList3;
    public GameObject[] flowerList4;


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

            GameObject newFlower = null;

            if(aCollision.gameObject.GetComponent<SeedScript>().tajp == SeedScript.seedType.Seed1)
            {
                 newFlower = Instantiate(flowerList2[Random.Range(0, flowerList2.Length)], myFlowerSpawnPos);
            }
            else if (aCollision.gameObject.GetComponent<SeedScript>().tajp == SeedScript.seedType.Seed2)
            {
                 newFlower = Instantiate(flowerList3[Random.Range(0, flowerList3.Length)], myFlowerSpawnPos);
            }
            else if (aCollision.gameObject.GetComponent<SeedScript>().tajp == SeedScript.seedType.Seed3)
            {
                 newFlower = Instantiate(flowerList4[Random.Range(0, flowerList4.Length)], myFlowerSpawnPos);
            }


            newFlower.transform.position = myFlowerSpawnPos.transform.position;
            newFlower.transform.rotation = Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0));
            GameObject.Destroy(aCollision.gameObject);
            Debug.Log("Spawn Flower");
        }

        }
       
    }
