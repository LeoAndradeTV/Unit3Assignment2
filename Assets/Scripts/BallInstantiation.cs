using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInstantiation : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    public bool canDropBall = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canDropBall)
        {
            Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 ballInstantiation = new Vector3(clickPos.x, 9.2f, 0f);
            Instantiate(ball, ballInstantiation, Quaternion.identity);
            canDropBall = false;
        }
    }
}
