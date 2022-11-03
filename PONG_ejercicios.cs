/*/////////////////////////////////////////////////////////////////////////



//////////////////////       BALL       ///////////////////////////////



/////////////////////////////////////////////////////////////////////////*/

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







/*/////////////////////////////////////////////////////////////////////////



//////////////////////       Paddles       ///////////////////////////////



/////////////////////////////////////////////////////////////////////////*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Scripts.Pong // Nuestra librería
{
    enum PaddlemovementStates
    {
        Stop, MoveUp, MoveDown
    }

    [RequireComponent(typeof(Rigidbody2D), typeof(AudioSource))]
    public class PaddleController : MonoBehaviour
    {
        [SerializeField] KeyCode UpKeyCode = KeyCode.UpArrow;
        [SerializeField] KeyCode DownKeyCode = KeyCode.DownArrow;
        [SerializeField, Tooltip("Velocidad de la pala"), Range(1f, 10f)] public float speed = 3;

        Rigidbody2D _rigidBody2D;

        AudioSource _audioSource;

        PaddlemovementStates currentState;

        // Camera _camera; // podemos cachear asi la camara

        float maxY; // pero vamos a cachear directamente el valor que nos es útil de la camara

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();

            // _camera = Camera.main; // cachearíamos el valor de tamaño de la camara

            maxY = Camera.main.orthographicSize;

            currentState = PaddlemovementStates.Stop;

        }

        // Escucho teclas, es practicamente lo único que tiene que empler el método de ejecución Update()
        private void Update()
        {
            if (Input.GetKey(UpKeyCode) == true)
            {
                // debe subir
                currentState = PaddlemovementStates.MoveUp;
                Debug.Log(currentState.ToString());


            }
            else
            {
                if (Input.GetKey(DownKeyCode) == true)
                {
                    // debo bajar
                    currentState = PaddlemovementStates.MoveDown;
                    Debug.Log(currentState.ToString());

                }
                else
                {
                    // debo estar quieto
                    currentState = PaddlemovementStates.Stop;
                    Debug.Log(currentState.ToString());

                }
            }

        }

        // Realizo cambios en las físicas
        private void FixedUpdate()
        {
            // si he presionado hacia arriba, debería indicar mover hacia arriba
            // _rigidBody2D.velocity = new Vector2(0, speed);
            // si ha presionado hacia abajo, debería indicar mover hacia abajo

            var velocity = CalculateVelocity();
            // calculo de la posición
            float positionYwithoutClamp = _rigidBody2D.position.y + velocity * Time.fixedDeltaTime;
            // calculo de la posición final
            var newPosition = ClampPositionY(positionYwithoutClamp);
            // var newPosition = ClampPosition(_rigidBody2D.position + new Vector2(0, velocity) * Time.fixedDeltaTime);

            // posicion final
            _rigidBody2D.MovePosition(newPosition);

        }

        private float CalculateVelocity()
        {
            switch(currentState) // hacemos uso de del public enum
            {
                case PaddlemovementStates.Stop:
                    return 0;
                case PaddlemovementStates.MoveUp:
                    return speed;
                case PaddlemovementStates.MoveDown:
                    return -speed;
                
            }
            throw new System.Exception("El siwtch falla");
        }

        Vector2 ClampPositionY(float newPositionY)
        {

            // pulsando f12 sobre Camera, nos lleva a la API del elemento y podemos buscar.
            // En este caso nos resulta util el camera.ortographicSize
            var clampY = Mathf.Clamp(newPositionY, -maxY, maxY);
            return new Vector2(_rigidBody2D.position.x, clampY); // clamp sirve para limitar a minimo y maximo el valor.
            // Si nos pasamos hacia alguna dirección, se establecerá ese máx o min

        }



    }

}
