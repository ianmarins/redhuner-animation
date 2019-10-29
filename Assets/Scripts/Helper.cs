using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    public static GameObject createPiso()
    {
        // Criando um objeto do tipo cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Atribuindo uma escala para o cubo
        cube.transform.localScale = new Vector3(1, 0.2f, 1);

        return cube;
    }
}
