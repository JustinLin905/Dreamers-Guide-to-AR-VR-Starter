using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shopping Cart class implemented as a Singleton
public class ShoppingCart : MonoBehaviour
{
    public static ShoppingCart Instance { get; private set; }

    private List<int> cart = new List<int>();

    [SerializeField] GameObject cartItemPrefab;
    [SerializeField] GameObject scrollViewContent;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PushToCart(int id)
    {
        cart.Add(id);

        GameObject cartItem = Instantiate(cartItemPrefab, scrollViewContent.transform);
        SetProductData productData = cartItem.GetComponent<SetProductData>();
        productData.SetData(id);
    }
}
