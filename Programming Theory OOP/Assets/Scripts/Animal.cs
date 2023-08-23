using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    protected float negativeDirectionMultiplier = -1f;
    protected Vector3 moveDirection;
    protected GameObject player;
    private float moveSpeed = 1f;


    // Start is called before the first frame update
    void Start()
    {

        
    }

    void Awake()
    {
        //moveDirection = (negativeDirectionMultiplier * transform.position - transform.position).normalized;
        //Debug.Log(moveDirection);
        player = GameObject.Find("Player");
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // INHERITANCE
    public virtual void MoveAnimal()
    {
        
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
    }



}
