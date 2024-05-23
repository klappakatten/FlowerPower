using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    public Transform myFlowerSpawnPos;

    private GlobalFlowerScript myGlobalFlowers;
    private void Start()
    {
        myGlobalFlowers = GameObject.FindObjectOfType<GlobalFlowerScript>();
    }

    private void OnCollisionEnter(Collision aCollision)
    {
        if (aCollision.collider.CompareTag("canPickUp"))
        {
            GameObject newFlower = GameObject.Instantiate(myGlobalFlowers.GetFlowerFromType(aCollision.gameObject.GetComponent<SeedScript>().myFlowerType));
            newFlower.transform.position = myFlowerSpawnPos.transform.position;
            GameObject.Destroy(aCollision.gameObject);
            Debug.Log("Spawn Flower");
        }

    }
}
