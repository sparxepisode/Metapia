using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_speed=10;
    public Animator m_Animator;
    public float m_moveSpeed=10;
    public float m_rotation=180;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator.SetFloat("ForwardSpeed", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                m_Animator.SetFloat("ForwardSpeed", 10);
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                m_Animator.SetFloat("ForwardSpeed", -10);
            }

        }
    }
}
