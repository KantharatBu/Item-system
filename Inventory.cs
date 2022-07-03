using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventoryObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryObject.SetActive(!inventoryObject.activeInHierarchy);
        }
    }
}
