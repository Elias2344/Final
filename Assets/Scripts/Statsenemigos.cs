using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statsenemigos : MonoBehaviour
{
    public float health2 = 400f;

    public float damageOnHit = 25f;



    // Start is called before the first frame update

    void Starts()

    {
        
        

    }



    // Update is called once per frame

    void Update()

    {

        

    }



    public void OnHit2(float damage) {

        Debug.Log("OnHit");

        // health = health - damageOnHit;

        health2 -= damage;


        //vida del jugador cuando le impactan va perdiendo energia hasta llegar a 0 y mostrar el GameOver
        if (health2 <= 0f) {

            Die2();
            Over.show ();

        }

    }


    //cuando llegue a 0 el jugador se destruye
    private void Die2() {

        Destroy(this.gameObject);

    }

}
