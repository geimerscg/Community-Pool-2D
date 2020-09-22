using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < 0)
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if (transform.position.y <= -5.75f) 
        {
            Destroy(this.gameObject);
        }
    }

}
