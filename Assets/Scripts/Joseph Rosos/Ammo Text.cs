using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AmmoText : MonoBehaviour
{
    public Weapon weapon;
    public TextMeshProUGUI text;


    private void Start()
    {
        UpdateAmmoText();
    }


    private void Update()
    {
        UpdateAmmoText();
    }

    public void UpdateAmmoText() { }
   
}
