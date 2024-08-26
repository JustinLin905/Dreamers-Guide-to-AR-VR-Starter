using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Shopping Cart class implemented as a Singleton
public class ShoppingCart : MonoBehaviour
{
    public static ShoppingCart Instance { get; private set; }

    private List<int> cart = new List<int>();

    [SerializeField] GameObject cartItemPrefab;
    [SerializeField] GameObject scrollViewContent;
    [SerializeField] TextMeshProUGUI walletAmount;

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

        walletAmount.text = "$" + Wallet.GetBalance().ToString();
    }

    public void PushToCart(int id)
    {
        cart.Add(id);

        GameObject cartItem = Instantiate(cartItemPrefab, scrollViewContent.transform);
        SetProductData productData = cartItem.GetComponent<SetProductData>();
        productData.SetData(id);
    }

    public void Purchase()
    {
        float total = 0.0f;
        foreach (int id in cart)
        {
            total += ItemDictionary.GetItem(id).price;
        }

        if (total > Wallet.GetBalance())
        {
            Debug.Log("Insufficient funds!");
            return;
        }

        Wallet.Deduct(total);
        walletAmount.text = "$" + Wallet.GetBalance().ToString();

        cart.Clear();
        foreach (Transform child in scrollViewContent.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void ClearCart()
    {
        cart.Clear();
        foreach (Transform child in scrollViewContent.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
