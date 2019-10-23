using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    public static GameObject createCube(Vector3 vetorPos, Vector3 vetorScale)
    {
        // Criando um objeto do tipo cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Atribuindo uma posição e uma escala ao cubo criado
        cube.transform.position = vetorPos;
        cube.transform.localScale = vetorScale;

        return cube;
    }
}
