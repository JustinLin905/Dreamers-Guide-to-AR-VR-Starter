using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetProductData : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI productName;
    [SerializeField] private TextMeshProUGUI productPrice;
    public void SetData(int id)
    {
        ItemMetadata item = ItemDictionary.GetItem(id);
        productName.text = item.name;
        productPrice.text = "$" + item.price.ToString();
    }
}
