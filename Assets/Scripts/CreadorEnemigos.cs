using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEnemigos : MonoBehaviour
{
    public GameObject Enemigos;
    public float tiempoCreacion = 2f, RangoCreacion = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Creando", 2.0f, tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creando(){
        Vector3 SpawnPosition = new Vector3(0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3 (this.transform.position.x, SpawnPosition.y, 0);

        GameObject Enemigo = Instantiate (Enemigos, SpawnPosition, Quaternion.identity);
    }
}
