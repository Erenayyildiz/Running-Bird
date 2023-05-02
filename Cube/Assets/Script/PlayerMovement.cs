using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float move = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(0, 0, move);
    }
}
