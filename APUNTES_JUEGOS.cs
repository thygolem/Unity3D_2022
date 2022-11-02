using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Pong // Nuestra librería
{
    [RequireComponent(typeof(Rigidbody2D))] // nos crea el compomente si no lo hemos hecho manualmente, faltaría configurar sus variables

    public class BallController : MonoBehaviour
    {
        [SerializeField] Vector2 initialVelocity = new Vector2(10, 0);

        Rigidbody2D _rigidBody2D;
        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();

            if(_rigidBody2D == null) throw new System.Exception("ERROR, falta el rigidbody 2D");

            _rigidBody2D.velocity = initialVelocity;
        }
    }
}

