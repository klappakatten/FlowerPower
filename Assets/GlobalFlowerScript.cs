using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlobalFlowerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject myFlower1;
    [SerializeField]
    private GameObject myFlower2;
    [SerializeField]
    private GameObject myFlower3;
    [SerializeField]
    private GameObject myFlower4;
    [SerializeField]
    private GameObject myFlower5;
    [SerializeField]
    private GameObject myFlower6;
    [SerializeField]
    private GameObject myFlower7;
    [SerializeField]
    private GameObject myFlower8;
    [SerializeField]
    private GameObject myFlower9;

    [SerializeField]
    private GameObject myBasicSeed;

    public enum eFlowerType
    {
        DEFAULT = 0,
        Flower1,
        Flower2,
        Flower3,
        Flower4,
        Flower5,
        Flower6,
        Flower7,
        Flower8,
        Flower9,
    }

    public GameObject GetFlowerFromType(eFlowerType aFlowerType)
    {
        switch (aFlowerType)
        {
            case eFlowerType.Flower1:
                {
                    return myFlower1;
                }

            case eFlowerType.Flower2:
                {
                    return myFlower2;
                }

            case eFlowerType.Flower3:
                {
                    return myFlower3;
                }

            case eFlowerType.Flower4:
                {
                    return myFlower4;
                }

            case eFlowerType.Flower5:
                {
                    return myFlower5;
                }

            case eFlowerType.Flower6:
                {
                    return myFlower6;
                }

            case eFlowerType.Flower7:
                {
                    return myFlower7;
                }

            case eFlowerType.Flower8:
                {
                    return myFlower8;
                }

            case eFlowerType.Flower9:
                {
                    return myFlower9;
                }
        }
        return null;
    }

    public GameObject GetSeedFromType(eFlowerType aFlowerType)
    {
        if (aFlowerType == eFlowerType.DEFAULT)
        {
            Debug.LogWarning("ERROR | GetSeedFromType");
            return null;
        }

        myBasicSeed.GetComponent<SeedScript>().myFlowerType = aFlowerType;
        return myBasicSeed;
    }

    public eFlowerType Combine(eFlowerType aFlowerType, eFlowerType anOtherFlowerType)
    {
        return eFlowerType.DEFAULT;
    }

}
