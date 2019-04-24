using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public int ID;
    public string type;
    public string description;
    public bool empty;
    public Sprite icon;
    public GameObject item;
    public Transform slotIconGO;

    private void Start()
    {
        slotIconGO = transform.GetChild(0);
    }

    public void UpdateSlot()
    {
        slotIconGO.GetComponent<Image>().sprite = icon;
    }
}
