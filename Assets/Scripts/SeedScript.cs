using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static GlobalFlowerScript;

public class SeedScript : MonoBehaviour
{

    static bool colidedOnce = false;
    //public GameObject myFlowerObject;
    public GlobalFlowerScript.eFlowerType myFlowerType = GlobalFlowerScript.eFlowerType.DEFAULT;

    public eFlowerType type = eFlowerType.Flower1;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("canPickUp"))
        {
            SeedScript otherSeed = collision.collider.GetComponent<SeedScript>();
            if (myFlowerType == otherSeed.myFlowerType
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower4
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower5
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower6
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower7
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower8
                || myFlowerType == GlobalFlowerScript.eFlowerType.Flower9)
            {
                return;
            }
               
            if (SeedScript.colidedOnce == false)
            {
                SeedScript.colidedOnce = true;
                Debug.Log("Item Collided");
            }
            else
            {
                SeedScript.colidedOnce = false;
                Destroy(gameObject);
            }
        }

    }
}

