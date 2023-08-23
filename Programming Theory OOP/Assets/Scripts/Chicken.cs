using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    //ENCAPSULATION
    private float m_moveSpeed = 8f;
    public float moveSpeed // delete semicolon
    {
        get { return m_moveSpeed; } // getter returns backing field
        set { m_moveSpeed = value; } // setter uses backing field
    }
    // Update is called once per frame
    void Update()
    {
        MoveAnimal();
    }

    // POLYMORPHISM
    public override void MoveAnimal()
    {

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
