/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using StarterAssets;

public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPoint;
    [SerializeField] private float bulletSpeed = 600;
    
    //Graphics
    private GameObject muzzleFlash;
    private TextMeshProUGUI ammunitionDisplay;

    public float spead;
    public float reloadTime;
     public int magazineSize;
     public int bulletsPerTap;
    public bool allowButtonHold;

     int bulletsLeft;
     int bulletsShot;

    bool shooting;
    bool readyToShoot;
    bool reloading;
    
    
    private void Awake()
    {
        //Make sure magazine is full
        bulletsLeft = magazineSize;
        readyToShoot = true;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        MyInput();

        if(ammunitionDisplay != null)
        {
            ammunitionDisplay.SetText(bulletsLeft / bulletsPerTap + "/" + magazineSize / bulletsPerTap);
        }
        
        if(_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }
    
    
    private void MyInput() 
    {
        //check if allawed to hold down button and take corresponding input
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        //Reloading
        if(Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading)
        {
            Reload();
        }
        //Reloading Automatically when trying to Shoot without Ammo
        if(readyToShoot && shooting && !reloading && bulletsLeft <= 0)
        {
            Reload();
        }

        //Shooting
        if(readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            //Set bullets shot to 0
            bulletsShot = 0;

            Shoot();
        }
    }
    
    
    void Shoot()
    {
        
        readyToShoot = false;

        bulletsLeft--;
        bulletsShot++;
        
        Debug.Log("Shoot!");
        GameObject Man_03 = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        //Man_03.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed * Time.deltaTime;
        Man_03.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(Man_03, 3);
    }
    
    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime);
    }
    private void ReloadFinished()
    {
        //bulletsleft = magazineSize;
        reloading = false;
    }
    
}
*/