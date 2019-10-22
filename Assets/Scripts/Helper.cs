using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper
{
    public static GameObject createCube(float x, float y, float z)
    {
        // Criando um objeto do tipo cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Criando um vetor de posição para ser atribuiido ao cubo posteriormente
        Vector3 posicao = new Vector3(x, y, z);
        Vector3 escala = new Vector3(x, y, z);
        // Atribuindo uma posição ao cubo criado
        cube.transform.position = posicao;
        cube.transform.localScale = escala;
        

        return cube;
    }
}
