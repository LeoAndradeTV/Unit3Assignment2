using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private BallInstantiation ballManager;

    private void Awake()
    {
        ballManager = GameObject.Find("Ball Spawner").GetComponent<BallInstantiation>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            StartCoroutine(FinishRound());
        }
    }

    private IEnumerator FinishRound()
    {
        GameManager.Instance.ShowEndOfTurnText();
        yield return new WaitForSeconds(3f);
        GameManager.Instance.Score = 0;
        ballManager.canDropBall = true;
        GameManager.Instance.HideEndOfTurnText();
        Destroy(gameObject);
    }
}
