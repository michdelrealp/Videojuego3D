using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    public float impulseForce = 3f;

    private bool ignoreNextCollision;

    private void OnCollisionEnter(Collision collision)
    {
        // Evitar colisiones m�ltiples en corto tiempo
        if (ignoreNextCollision)
        {
            return;
        }

        // Sumar puntos solo si la colisi�n es v�lida
        GameManager.singleton.AddScore(1);

        // Detener movimiento y aplicar impulso hacia arriba
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);

        // Activar protecci�n contra colisiones repetidas por 0.2s
        ignoreNextCollision = true;
        Invoke("AllowNextCollision", 0.2f);
    }

    private void AllowNextCollision()
    { 
        ignoreNextCollision = false;
    }
}
