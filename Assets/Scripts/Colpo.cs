using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colpo : MonoBehaviour
{
    public Rigidbody rgBullet;
    public GameObject player;

    private Vector3 lastVelocity;
    private float curSpeed;
    private Vector3 direction;

    private void LateUpdate()
    {
        lastVelocity = rgBullet.velocity;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coda"))
        {
            curSpeed = lastVelocity.magnitude;
            direction = Vector3.Reflect(lastVelocity.normalized, collision.GetContact(0).normal);

            rgBullet.velocity = direction * curSpeed;
        }
        else
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("UltimaVita"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}