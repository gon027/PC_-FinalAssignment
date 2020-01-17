using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    /// <summary>
    /// bool型のランダムな値を取得する
    /// </summary>
    /// <returns>True or False</returns>
    public static bool getRandomBool()
    {
        return Random.Range(0, 2) == 0;
    }
}
