using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(ball);
            GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
            StartCoroutine(gameController.EndGame());
        }
    }
}
