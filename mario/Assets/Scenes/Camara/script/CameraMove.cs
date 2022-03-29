using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//����ڰ� ���콺�� �巡�� �ϸ� ī�޶� ȸ���ϰ�ʹ�.


public class CameraMove : MonoBehaviour
{
    public float gravity = -9.81f;//�߷�, �÷��̸� ��, ȭ������ �� ���� �����ϱ� ���������ϰ�
    float yVelocity;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    float rx;
    float ry;
    public float speed = 200f;
    public GameObject aa;

    // Update is called once per frame
    void Update()
    {
        //1)����ڰ� ���콺�� �巡���ϸ� "�����δ�"
        transform.LookAt(aa.transform.position);
        if(Input.GetButton("Fire1")) //�巡��
        {
            //�¾�� ������ ��ġ�� ������.
            transform.position = (new Vector3(-63, 96, -45));
            //������ ������ ������.
            transform.eulerAngles = (new Vector3(36, 25, 0));

            //ī�޶� ������
            float mx = Input.GetAxis("Mouse X");
            float my = Input.GetAxis("Mouse Y");

            //x�� �������� ������ -> ��,�Ʒ�(y����)
            //y�� �������� ������ -> ��,�� (x����)
            //���Ǽ��� ���� ���� �������� x, y ���� -> �ʵ庯�� ���� �� ���� �ϼ�rx(my), ry(mx)
            rx += my * speed * Time.deltaTime;
            ry += mx * speed * Time.deltaTime;

            //���ǵ��� �̸��� ���� ���� -> �ۺ����� ����(����Ƽ�󿡼��� �ӵ� ���� �����ϰ�)

            rx = Mathf.Clamp(rx, -70, 70); //ī�޶� ���� ����


            //2) ī�޶� ȸ��
            transform.eulerAngles = (new Vector3(-rx, ry, 0));
        }

    }



}

