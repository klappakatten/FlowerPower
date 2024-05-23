using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{

    static bool colidedOnce = false;

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
            if (Item.colidedOnce == false)
            {
                Item.colidedOnce = true;
                Debug.Log("Item Collided");
            }
            else
            {
                Item.colidedOnce = false;
                Destroy(gameObject);
            }
        }

    }
}
