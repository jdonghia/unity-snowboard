using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float torque = 2f;
    public bool hasBumped = false;
    Rigidbody2D m_rigidbody;
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasBumped)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                FindObjectOfType<SurfaceEffector2D>().speed = 20;
            } else {
                FindObjectOfType<SurfaceEffector2D>().speed = 10;

            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                m_rigidbody.AddTorque(torque);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                m_rigidbody.AddTorque(-torque);
            }
        }

    }
}
