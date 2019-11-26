using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    // Função para gerar os blocos que serão utilizados na plataforma
    public static GameObject createPiso()
    {
        // Criando um objeto do tipo cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Atribuindo uma escala para o cubo
        cube.transform.localScale = new Vector3(1, 0.2f, 1);

        return cube;
    }

    // Função para ger os blocos que serão utilizados nas letras, possibilitando a troca de cor
    public static GameObject createLetraColor(Material mat)
    {
        // Criando um objeto do tipo cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // Atribuindo uma escala para o cubo
        cube.transform.localScale = new Vector3(1, 1f, 1);
        cube.GetComponent<Renderer>().material = mat;

        return cube;
    }

    // Função Lerp para auxilio.
    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }

    // Posições dos cubos para a formação da letra R
    public static List<Vector3> letraR()
    {
        List<Vector3> letraR = new List<Vector3>();

        letraR.Add(new Vector3(-13, 1, 39));
        letraR.Add(new Vector3(-12, 1, 39));
        letraR.Add(new Vector3(-11, 1, 39));
        letraR.Add(new Vector3(-8, 1, 39));
        letraR.Add(new Vector3(-7, 1, 39));

        letraR.Add(new Vector3(-12, 2, 39));
        letraR.Add(new Vector3(-8, 2, 39));

        letraR.Add(new Vector3(-12, 3, 39));
        letraR.Add(new Vector3(-9, 3, 39));

        letraR.Add(new Vector3(-12, 4, 39));
        letraR.Add(new Vector3(-10, 4, 39));

        letraR.Add(new Vector3(-12, 5, 39));
        letraR.Add(new Vector3(-11, 5, 39));
        letraR.Add(new Vector3(-10, 5, 39));
        letraR.Add(new Vector3(-9, 5, 39));

        letraR.Add(new Vector3(-12, 6, 39));
        letraR.Add(new Vector3(-8, 6, 39));

        letraR.Add(new Vector3(-12, 7, 39));
        letraR.Add(new Vector3(-8, 7, 39));

        letraR.Add(new Vector3(-13, 8, 39));
        letraR.Add(new Vector3(-12, 8, 39));
        letraR.Add(new Vector3(-11, 8, 39));
        letraR.Add(new Vector3(-10, 8, 39));
        letraR.Add(new Vector3(-9, 8, 39));

        return letraR;
    }

    // Posições dos cubos para a formação da letra E
    public static List<Vector3> letraE()
    {
        List<Vector3> letraE = new List<Vector3>();

        letraE.Add(new Vector3(-2, 1, 39));
        letraE.Add(new Vector3(-1, 1, 39));
        letraE.Add(new Vector3(0, 1, 39));
        letraE.Add(new Vector3(1, 1, 39));
        letraE.Add(new Vector3(2, 1, 39));
        letraE.Add(new Vector3(3, 1, 39));

        letraE.Add(new Vector3(-1, 2, 39));
        letraE.Add(new Vector3(3, 2, 39));

        letraE.Add(new Vector3(-1, 3, 39));

        letraE.Add(new Vector3(-1, 4, 39));

        letraE.Add(new Vector3(-1, 5, 39));
        letraE.Add(new Vector3(0, 5, 39));
        letraE.Add(new Vector3(1, 5, 39));
        letraE.Add(new Vector3(2, 5, 39));

        letraE.Add(new Vector3(-1, 6, 39));

        letraE.Add(new Vector3(-1, 7, 39));
        letraE.Add(new Vector3(3, 7, 39));

        letraE.Add(new Vector3(-2, 8, 39));
        letraE.Add(new Vector3(-1, 8, 39));
        letraE.Add(new Vector3(0, 8, 39));
        letraE.Add(new Vector3(1, 8, 39));
        letraE.Add(new Vector3(2, 8, 39));
        letraE.Add(new Vector3(3, 8, 39));

        return letraE;
    }

    // Posições dos cubos para a formação da letra D
    public static List<Vector3> letraD()
    {
        List<Vector3> letraD = new List<Vector3>();

        letraD.Add(new Vector3(8, 1, 39));
        letraD.Add(new Vector3(9, 1, 39));
        letraD.Add(new Vector3(10, 1, 39));
        letraD.Add(new Vector3(11, 1, 39));
        letraD.Add(new Vector3(12, 1, 39));

        letraD.Add(new Vector3(9, 2, 39));
        letraD.Add(new Vector3(13, 2, 39));

        letraD.Add(new Vector3(9, 3, 39));
        letraD.Add(new Vector3(14, 3, 39));

        letraD.Add(new Vector3(9, 4, 39));
        letraD.Add(new Vector3(14, 4, 39));

        letraD.Add(new Vector3(9, 5, 39));
        letraD.Add(new Vector3(14, 5, 39));

        letraD.Add(new Vector3(9, 6, 39));
        letraD.Add(new Vector3(14, 6, 39));

        letraD.Add(new Vector3(9, 7, 39));
        letraD.Add(new Vector3(13, 7, 39));

        letraD.Add(new Vector3(8, 8, 39));
        letraD.Add(new Vector3(9, 8, 39));
        letraD.Add(new Vector3(10, 8, 39));
        letraD.Add(new Vector3(11, 8, 39));
        letraD.Add(new Vector3(12, 8, 39));

        return letraD;
    }

    // Posições dos cubos para a formação da letra H
    public static List<Vector3> letraH()
    {
        List<Vector3> letraH = new List<Vector3>();

        letraH.Add(new Vector3(-30, 1, 9));
        letraH.Add(new Vector3(-29, 1, 9));
        letraH.Add(new Vector3(-28, 1, 9));
        letraH.Add(new Vector3(-25, 1, 9));
        letraH.Add(new Vector3(-24, 1, 9));
        letraH.Add(new Vector3(-23, 1, 9));

        letraH.Add(new Vector3(-29, 2, 9));
        letraH.Add(new Vector3(-24, 2, 9));

        letraH.Add(new Vector3(-29, 3, 9));
        letraH.Add(new Vector3(-24, 3, 9));

        letraH.Add(new Vector3(-29, 4, 9));
        letraH.Add(new Vector3(-24, 4, 9));

        letraH.Add(new Vector3(-29, 5, 9));
        letraH.Add(new Vector3(-28, 5, 9));
        letraH.Add(new Vector3(-27, 5, 9));
        letraH.Add(new Vector3(-26, 5, 9));
        letraH.Add(new Vector3(-25, 5, 9));
        letraH.Add(new Vector3(-24, 5, 9));

        letraH.Add(new Vector3(-29, 6, 9));
        letraH.Add(new Vector3(-24, 6, 9));

        letraH.Add(new Vector3(-29, 7, 9));
        letraH.Add(new Vector3(-24, 7, 9));

        letraH.Add(new Vector3(-30, 8, 9));
        letraH.Add(new Vector3(-29, 8, 9));
        letraH.Add(new Vector3(-28, 8, 9));
        letraH.Add(new Vector3(-25, 8, 9));
        letraH.Add(new Vector3(-24, 8, 9));
        letraH.Add(new Vector3(-23, 8, 9));

        return letraH;
    }

    // Posições dos cubos para a formação da letra U
    public static List<Vector3> letraU()
    {
        List<Vector3> letraU = new List<Vector3>();

        letraU.Add(new Vector3(-17, 1, 9));
        letraU.Add(new Vector3(-16, 1, 9));
        letraU.Add(new Vector3(-15, 1, 9));
        letraU.Add(new Vector3(-14, 1, 9));

        letraU.Add(new Vector3(-18, 2, 9));
        letraU.Add(new Vector3(-13, 2, 9));

        letraU.Add(new Vector3(-18, 3, 9));
        letraU.Add(new Vector3(-13, 3, 9));

        letraU.Add(new Vector3(-18, 4, 9));
        letraU.Add(new Vector3(-13, 4, 9));

        letraU.Add(new Vector3(-18, 5, 9));
        letraU.Add(new Vector3(-13, 5, 9));

        letraU.Add(new Vector3(-18, 6, 9));
        letraU.Add(new Vector3(-13, 6, 9));

        letraU.Add(new Vector3(-18, 7, 9));
        letraU.Add(new Vector3(-13, 7, 9));

        letraU.Add(new Vector3(-18, 8, 9));
        letraU.Add(new Vector3(-13, 8, 9));

        return letraU;
    }

    // Posições dos cubos para a formação da letra N
    public static List<Vector3> letraN()
    {
        List<Vector3> letraN = new List<Vector3>();

        letraN.Add(new Vector3(-8, 1, 9));
        letraN.Add(new Vector3(-7, 1, 9));
        letraN.Add(new Vector3(-6, 1, 9));
        letraN.Add(new Vector3(-3, 1, 9));
        letraN.Add(new Vector3(-2, 1, 9));
        letraN.Add(new Vector3(-1, 1, 9));

        letraN.Add(new Vector3(-7, 2, 9));
        letraN.Add(new Vector3(-2, 2, 9));

        letraN.Add(new Vector3(-7, 3, 9));
        letraN.Add(new Vector3(-3, 3, 9));
        letraN.Add(new Vector3(-2, 3, 9));

        letraN.Add(new Vector3(-7, 4, 9));
        letraN.Add(new Vector3(-4, 4, 9));
        letraN.Add(new Vector3(-2, 4, 9));

        letraN.Add(new Vector3(-7, 5, 9));
        letraN.Add(new Vector3(-5, 5, 9));
        letraN.Add(new Vector3(-2, 5, 9));

        letraN.Add(new Vector3(-7, 6, 9));
        letraN.Add(new Vector3(-6, 6, 9));
        letraN.Add(new Vector3(-2, 6, 9));

        letraN.Add(new Vector3(-7, 7, 9));
        letraN.Add(new Vector3(-2, 7, 9));

        letraN.Add(new Vector3(-8, 8, 9));
        letraN.Add(new Vector3(-7, 8, 9));
        letraN.Add(new Vector3(-6, 8, 9));
        letraN.Add(new Vector3(-3, 8, 9));
        letraN.Add(new Vector3(-2, 8, 9));
        letraN.Add(new Vector3(-1, 8, 9));

        return letraN;
    }

    // Posições dos cubos para a formação da letra T
    public static List<Vector3> letraT()
    {
        List<Vector3> letraT = new List<Vector3>();

        letraT.Add(new Vector3(6, 1, 9));
        letraT.Add(new Vector3(7, 1, 9));
        letraT.Add(new Vector3(8, 1, 9));

        letraT.Add(new Vector3(7, 2, 9));

        letraT.Add(new Vector3(7, 3, 9));

        letraT.Add(new Vector3(7, 4, 9));

        letraT.Add(new Vector3(7, 5, 9));

        letraT.Add(new Vector3(7, 6, 9));

        letraT.Add(new Vector3(4, 7, 9));
        letraT.Add(new Vector3(7, 7, 9));
        letraT.Add(new Vector3(10, 7, 9));

        letraT.Add(new Vector3(4, 8, 9));
        letraT.Add(new Vector3(5, 8, 9));
        letraT.Add(new Vector3(6, 8, 9));
        letraT.Add(new Vector3(7, 8, 9));
        letraT.Add(new Vector3(8, 8, 9));
        letraT.Add(new Vector3(9, 8, 9));
        letraT.Add(new Vector3(10, 8, 9));

        return letraT;
    }

    // Posições dos cubos para a formação da letra E
    public static List<Vector3> letraE2()
    {
        List<Vector3> letraE2 = new List<Vector3>();

        letraE2.Add(new Vector3(15, 1, 9));
        letraE2.Add(new Vector3(16, 1, 9));
        letraE2.Add(new Vector3(17, 1, 9));
        letraE2.Add(new Vector3(18, 1, 9));
        letraE2.Add(new Vector3(19, 1, 9));
        letraE2.Add(new Vector3(20, 1, 9));

        letraE2.Add(new Vector3(16, 2, 9));
        letraE2.Add(new Vector3(20, 2, 9));

        letraE2.Add(new Vector3(16, 3, 9));

        letraE2.Add(new Vector3(16, 4, 9));

        letraE2.Add(new Vector3(16, 5, 9));
        letraE2.Add(new Vector3(17, 5, 9));
        letraE2.Add(new Vector3(18, 5, 9));
        letraE2.Add(new Vector3(19, 5, 9));

        letraE2.Add(new Vector3(16, 6, 9));

        letraE2.Add(new Vector3(16, 7, 9));
        letraE2.Add(new Vector3(20, 7, 9));

        letraE2.Add(new Vector3(15, 8, 9));
        letraE2.Add(new Vector3(16, 8, 9));
        letraE2.Add(new Vector3(17, 8, 9));
        letraE2.Add(new Vector3(18, 8, 9));
        letraE2.Add(new Vector3(19, 8, 9));
        letraE2.Add(new Vector3(20, 8, 9));

        return letraE2;
    }

    // Posições dos cubos para a formação da letra R
    public static List<Vector3> letraR2()
    {
        List<Vector3> letraR2 = new List<Vector3>();

        letraR2.Add(new Vector3(25, 1, 9));
        letraR2.Add(new Vector3(26, 1, 9));
        letraR2.Add(new Vector3(27, 1, 9));
        letraR2.Add(new Vector3(30, 1, 9));
        letraR2.Add(new Vector3(31, 1, 9));

        letraR2.Add(new Vector3(26, 2, 9));
        letraR2.Add(new Vector3(30, 2, 9));

        letraR2.Add(new Vector3(26, 3, 9));
        letraR2.Add(new Vector3(29, 3, 9));

        letraR2.Add(new Vector3(26, 4, 9));
        letraR2.Add(new Vector3(28, 4, 9));

        letraR2.Add(new Vector3(26, 5, 9));
        letraR2.Add(new Vector3(27, 5, 9));
        letraR2.Add(new Vector3(28, 5, 9));
        letraR2.Add(new Vector3(29, 5, 9));

        letraR2.Add(new Vector3(26, 6, 9));
        letraR2.Add(new Vector3(30, 6, 9));

        letraR2.Add(new Vector3(26, 7, 9));
        letraR2.Add(new Vector3(30, 7, 9));

        letraR2.Add(new Vector3(25, 8, 9));
        letraR2.Add(new Vector3(26, 8, 9));
        letraR2.Add(new Vector3(27, 8, 9));
        letraR2.Add(new Vector3(28, 8, 9));
        letraR2.Add(new Vector3(29, 8, 9));

        return letraR2;
    }
}

