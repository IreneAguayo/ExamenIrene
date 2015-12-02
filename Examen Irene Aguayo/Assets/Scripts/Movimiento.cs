using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour
{

    Rigidbody2D rg;
    public float fuerza = 5f;

    // Use this for initialization
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            mueve_izquierda();
        }

        if (Input.GetKey(KeyCode.D))
        {
            mueve_derecha();
        }
    }
    void mueve_derecha()
    {
        rg.AddForce(new Vector2(fuerza, 0));
    }

    void mueve_izquierda()
    {
        rg.AddForce(new Vector2(-fuerza, 0));
    }
}
