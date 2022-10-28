using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    void Start()
    {
        Die();
    }

    void Die()
    {
        Destroy(gameObject, 3);
    }
}
