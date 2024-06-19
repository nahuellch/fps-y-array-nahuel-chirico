using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public int nivelHambre;
    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        alimentoScript alimento;
        alimento = col.GetComponent<alimentoScript>();

        if (alimento)
        {
            TomarAlimento(alimento.valorAlimenticio);
            Destroy(col.gameObject);
        }
        Debug.Log(col.gameObject);
    }

    void TomarAlimento(int valorAlimenticio)
    {
        nivelHambre -= valorAlimenticio;
        if (nivelHambre <= 0)
        {
            nivelHambre = 0;
        }
    }
}
