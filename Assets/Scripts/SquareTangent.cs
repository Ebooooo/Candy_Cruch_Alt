using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareTangent : MonoBehaviour
{
    protected Vector3 GetRotatedTangent(float degree, float scale)
        {
            float angle = degree * Mathf.Deg2Rad;
            float x = scale * Mathf.Sin(angle);
            float y = scale * Mathf.Cos(angle);
            return new Vector2(x, y);
        }
}
