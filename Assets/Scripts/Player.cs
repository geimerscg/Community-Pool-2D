using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }



    void CalculateMovement()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        if (transform.position.y >= 3.82f)
        {
            transform.position = new Vector3(transform.position.x, 3.82f, 0);
        }
        else if (transform.position.y <= -3.87f)
        {
            transform.position = new Vector3(transform.position.x, -3.87f, 0);
        }

        if (transform.position.x >= 8.18f)
        {
            transform.position = new Vector3(8.18f, transform.position.y, 0);
        }
        else if (transform.position.x <= -8.18f)
        {
            transform.position = new Vector3(-8.18f, transform.position.y, 0);
        }

    }
}
