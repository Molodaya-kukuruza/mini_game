using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]

    public class BallController : MonoBehaviour
    {

        [SerializeField, Range(5, 15)] private float speed = 10.0f;
        private Rigidbody playerRigidBody;
        private Vector3 movement;
        private Animator animat;

        private void Awake()
        {
            playerRigidBody = GetComponent<Rigidbody>();
            animat = GetComponent<Animator>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringsVar.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringsVar.VERTICAL_AXIS);
            //float jump = Input.GetAxis(GlobalStringsVar.JUMP_BUTTON);

            movement = new Vector3(horizontal, 0, vertical).normalized;
            //movement.Set(movement.x, movement.y*5, movement.z);
        }

        private void FixedUpdate()
        {
            moveCharacter();
        }

        private void moveCharacter()
        {
            playerRigidBody.AddForce(movement * speed);
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "Plane")
            {
                Debug.Log("dead");
                animat.SetTrigger("Dead");
                Coroutine coroutine = StartCoroutine(timer());
            }
        }


        private IEnumerator timer()
        {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene(1);
        }
    }
}