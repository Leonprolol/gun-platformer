using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firepoint;
    public GameObject gun;
    public GameObject knifeReal;
    public int ammo = 100;
    public float cooldown = 1.5f;
    private bool canAttack = true;
    private bool knife = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKeyDown(KeyCode.Alpha1)){
            knife = true;
                knifeReal.SetActive(true);
            gun.SetActive(false);
         }

        if (Input.GetKeyDown(KeyCode.Alpha2)){
            knife = false;
               knifeReal.SetActive(false);
            gun.SetActive(true);
         }
     if (Input.GetMouseButtonDown(0)){
        if (knife == true) {
        
        }
        else {
         
            if (ammo > 0 && canAttack == true) {
            GameObject bulletClone = Instantiate(bullet, firepoint.transform.position, Quaternion.identity); 
            bulletClone.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 0)*100;
            ammo = ammo-1;
            canAttack = false;
            StartCoroutine(attackcooldown());
            }
        }
    
       
     }   
     if (Input.GetKeyDown(KeyCode.R) && knife == false) {
        ammo = 100;
     }
    }

    IEnumerator attackcooldown(){
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    } 
}
