using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeedScript : MonoBehaviour
{

    static bool colidedOnce = false;
    public GameObject myFlowerObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("canPickUp"))
        {
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
