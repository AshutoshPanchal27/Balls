using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallLauncher>().ReturnBall();
        collision.collider.gameObject.SetActive(false);
    }
}
