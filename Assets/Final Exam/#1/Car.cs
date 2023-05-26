using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float verticalInput;
    private float horizontalInput;
    private Camera mainCamera;
    private Vector2 mousePos;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;

    }


    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        /*
         * FINAL EXAM #1
         * Write a script that will allow movement.
         * The Vertical Axis should make the player move forwards and backwards
         * The Horizontal Axis should make the player rotate on the Vector3.back axis
         */
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = (mousePos - (Vector2)transform.position).normalized;
        Quaternion startingRotation = Quaternion.AngleAxis(90f, Vector3.forward);
        transform.Translate(horizontalInput * Vector2.down * Time.deltaTime * moveSpeed);
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, lookDir) * startingRotation;
        transform.rotation = targetRotation;
    }
}
