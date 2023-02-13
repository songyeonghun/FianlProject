using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public int Hp=100;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hp++;
    }
}
