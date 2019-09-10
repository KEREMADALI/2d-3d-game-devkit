using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    #region Private & Const Variables

    #endregion

    #region Public Variables

    #endregion

    #region Public Methods

    public static void CreateExplosion(Vector2 explosionCenter, float power, float radius)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(explosionCenter, radius);

        for ( int i=0; i < hitColliders.Length  ; i++ )
        {
            ApplyForce(explosionCenter, hitColliders[i].attachedRigidbody, power);
        }
    }

    private static void ApplyForce(Vector2 explosionCenter, Rigidbody2D rigidbody, float power)
    {
        var direction = ((Vector2)rigidbody.position - explosionCenter).normalized;
        Vector2 forceVector = direction * power;

        rigidbody.AddForce(forceVector);
    }


    #endregion

    #region Private Methods

    #endregion
}
