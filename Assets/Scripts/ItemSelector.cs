using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject[] items;
    private int activeItem;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }

        activeItem = 0;
        items[activeItem].SetActive(true);
    }

    // Your code here
}
