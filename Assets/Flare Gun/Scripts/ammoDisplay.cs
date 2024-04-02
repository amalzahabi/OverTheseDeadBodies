using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ammoDisplay : MonoBehaviour
{
    [SerializeField] public int ammo;
    public bool isFiring;
    public TextMeshProUGUI amDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        amDisplay.text = ammo.ToString();
        if(Input.GetMouseButtonDown(0) && !isFiring && ammo > 0)
        {
            isFiring = true;
            ammo--;
            isFiring = false;
        }
    }
}
