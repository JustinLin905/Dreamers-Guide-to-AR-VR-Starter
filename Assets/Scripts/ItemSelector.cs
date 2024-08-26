using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    // Index is Item ID
    [SerializeField] private GameObject[] items;

    int activeItem;

    void Start()
    {        
        // Deactivate all items
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }

        // Activate the first item
        activeItem = 0;
        items[activeItem].SetActive(true);
    }

    public void ToggleItem(int index)
    {
        items[activeItem].SetActive(false);
        items[index].SetActive(true);
        activeItem = index;
    }

    public void AddToCart() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        ShoppingCart.Instance.PushToCart(activeItem);
    }
}
