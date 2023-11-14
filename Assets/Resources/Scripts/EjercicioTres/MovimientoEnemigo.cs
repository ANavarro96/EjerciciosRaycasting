using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    public Transform objetivo;
    public int minimo;
    public int maximo;
    int velocidad;

    // Start is called before the first frame update
    void Start()
    {
        // Determinamos una posición al azar de inicio para cada enemigo
        transform.position = DevolverPosicionInicial();
        // Le asignamos una velocidad al azar
        velocidad = Random.Range(minimo, maximo);
    }

    // Update is called once per frame
    void Update()
    {
        // Usamos MoveTowards para que se mueva hacia allá
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, Time.deltaTime);
    }


    Vector3 DevolverPosicionInicial()
    {
        float x = Random.Range(-30f, 30f);
        float y = objetivo.position.y;
        float z = Random.Range(-30f, 30f);

        return new Vector3(x, y, z);   
    }
}
