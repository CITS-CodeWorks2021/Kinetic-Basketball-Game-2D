using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyExtensions
{
  public static Transform Reset(this Transform source)
    {
        source.position = Vector3.zero;
        source.rotation = Quaternion.identity;
        source.localScale = Vector3.one;
        return source;
    }
}
