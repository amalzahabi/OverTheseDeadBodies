using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using StarterAssets;

public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPoint;
    [SerializeField] private float bulletSpeed = 600;
    
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }
    
    // Update is called once per frame
    void Update()
    {
       
        if(_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }
    void Shoot()
    {
        
        Debug.Log("Shoot!");
        GameObject Man_03 = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        //Man_03.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed * Time.deltaTime;
        Man_03.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(Man_03, 3);
    }
    
}
