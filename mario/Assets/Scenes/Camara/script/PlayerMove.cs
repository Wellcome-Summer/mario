using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController cc;
    public float dashTime = 2f;
    public float dashSpeed = 20f;
    public float gravity = -9.81f;//�߷�, �÷��̸� ��, ȭ������ �� ���� �����ϱ� ���������ϰ�
    float yVelocity;
    public float speed = 5;
    public float coolTime = 5;
    bool canDash = true;


    // Start is called before the first frame update
    void Start()
    {
       
        cc = GetComponent<CharacterController>();
    }
    private IEnumerator DashCoolTime()
    {
        canDash = false;
        yield return new WaitForSeconds(coolTime);
        canDash = true;
    }

    public int plusScore = 2000;
    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter" + other.name);
        if (other.transform.tag =="Star")
        {
            ScoreManager.instance.SCORE += plusScore;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Platform"))
        {
            platform = other.gameObject.GetComponent<Platform>();
        }
    }


    private IEnumerator DashCoroutine()
    {
        float startTime = Time.time; // need to     remember this to know how long to dash
        while (Time.time < startTime + dashTime)
        {
            cc.Move(transform.forward * dashSpeed * Time.deltaTime);
            // or controller.Move(...), dunno about that script
            yield return null; // this will make Unity stop here and continue next frame
        }
    }
    void Update()
    {
        
        if (false == cc.isGrounded)
        {
            yVelocity += gravity * Time.deltaTime;
        }

        // 1. ������� �Է¿�����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. �յ��¿�� ������ �����
        Vector3 dir = new Vector3(h, 0, v);

        // ����(dir)�� ī�޶� �������� �����ϰ�ʹ�.
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        if (h != 0 || v != 0)
        {
            transform.forward = dir;
        }
        Vector3 velocity = dir * speed;
        velocity.y = yVelocity;
        if (platform != null)
        {
            velocity += platform.velocity;
        }
        // 3. �� �������� �̵��ϰ�ʹ�.
        cc.Move(velocity * Time.deltaTime);

        //OnDrawGizmos();

        if (Input.GetKeyDown(KeyCode.Space) && canDash)
        {
            StartCoroutine(DashCoolTime());
            StartCoroutine(DashCoroutine());
        }


    }

    Platform platform;

    
    private void OnTriggerExit(Collider other)
    {
        platform = null;
    }

    //private void OnDrawGizmos()
    //{

    //    Gizmos.color = Color.red;

    //    Vector3 from = transform.position;
    //    Vector3 to = transform.position + Vector3.up * yVelocity;
    //    Gizmos.DrawLine(from, to);
    //}

}
