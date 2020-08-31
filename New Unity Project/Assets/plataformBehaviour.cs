using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformBehaviour : MonoBehaviour
{


    public Transform[] pontos;
    int pontoAtual;

    protected Rigidbody rigid;

    public float distPonto = 0.1f;
    public float speed = 5;


    void Start()
    {


        rigid = GetComponent<Rigidbody>();


    }



    protected virtual void Update()
    {

        Vector2 dir = pontos[pontoAtual].position - transform.position;
        dir.Normalize();

        rigid.velocity = dir * speed;

        if (Vector2.Distance(pontos[pontoAtual].position, transform.position) <= distPonto)
        {
            pontoAtual++;
            if (pontoAtual >= pontos.Length)
            {
                pontoAtual = 0;
            }
        }

    }


}
