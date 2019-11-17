using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    // Referências de origem e fim das letras
    Vector3 beginPositionH;
    List<Vector3> endPositionH;

    Vector3 beginPositionU;
    List<Vector3> endPositionU;

    Vector3 beginPositionN;
    List<Vector3> endPositionN;

    Vector3 beginPositionT;
    List<Vector3> endPositionT;

    Vector3 beginPositionE;
    List<Vector3> endPositionE;

    Vector3 beginPositionR;
    List<Vector3> endPositionR;

    Vector3 beginPositionControl;
    Vector3 endPositionControl;

    // Lista de velocidade das letras
    List<int> velocidadeH;
    List<int> velocidadeU;
    List<int> velocidadeN;
    List<int> velocidadeT;
    List<int> velocidadeE;
    List<int> velocidadeR;
    int velocidadeControl;

    // Lista de objetos das letras
    List<GameObject> letraH;
    List<GameObject> letraU;
    List<GameObject> letraN;
    List<GameObject> letraT;
    List<GameObject> letraE;
    List<GameObject> letraR;
    GameObject control;

    public float timeStartedLerping;

    private void startLerping()
    {
        timeStartedLerping = Time.time;
    }

    public Material red;
    public Material yellow;

    void Start()
    {
        // Instanciando informações do controle
        control = Helper.createLetraColor(yellow);
        velocidadeControl = 10;
        beginPositionControl = new Vector3(-1, 0, -11);
        endPositionControl = new Vector3(-1, 0, -10);

        // Instanciando os cubos letra H - Total de 28 cubos
        letraH = new List<GameObject>();
        for (int i = 0; i <= 27; i++)
        {
            letraH.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra U - Total de 18 cubos
        letraU = new List<GameObject>();
        for (int i = 0; i <= 17; i++)
        {
            letraU.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra N - Total de 28 cubos
        letraN = new List<GameObject>();
        for (int i = 0; i <= 27; i++)
        {
            letraN.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra T - Total de 18 cubos
        letraT = new List<GameObject>();
        for (int i = 0; i <= 17; i++)
        {
            letraT.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra E - Total de 23 cubos
        letraE = new List<GameObject>();
        for (int i = 0; i <= 22; i++)
        {
            letraE.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra R - Total de 24 cubos
        letraR = new List<GameObject>();
        for (int i = 0; i <= 23; i++)
        {
            letraR.Add(Helper.createLetraColor(red));
        }

        // Instanciando a velocidade da letra H - Intervalo entre 10 e 25
        velocidadeH = new List<int>();
        for (int i = 0; i <= 27; i++)
        {
            velocidadeH.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da letra U - Intervalo entre 10 e 25
        velocidadeU = new List<int>();
        for (int i = 0; i <= 17; i++)
        {
            velocidadeU.Add(Random.Range(10, 25));
        }

        // Instanciando a velocidade da letra N - Intervalo entre 10 e 25
        velocidadeN = new List<int>();
        for (int i = 0; i <= 27; i++)
        {
            velocidadeN.Add(Random.Range(10, 25));
        }

        // Instanciando a velocidade da letra T - Intervalo entre 10 e 25
        velocidadeT = new List<int>();
        for (int i = 0; i <= 17; i++)
        {
            velocidadeT.Add(Random.Range(10, 25));
        }

        // Instanciando a velocidade da letra E - Intervalo entre 10 e 25
        velocidadeE = new List<int>();
        for (int i = 0; i <= 22; i++)
        {
            velocidadeE.Add(Random.Range(10, 25));
        }

        // Instanciando a velocidade da letra R - Intervalo entre 10 e 25
        velocidadeR = new List<int>();
        for (int i = 0; i <= 23; i++)
        {
            velocidadeR.Add(Random.Range(10, 25));
        }

        // Inicializando o vetor origem da letra H - Coordenada (-36, 0, 26)
        beginPositionH = new Vector3(-36, 0, 26); // ref 7
        // Inicializando o vetor origem da letra U - Coordenada (-17, 0, -4)
        beginPositionU = new Vector3(-17, 0, -4); // ref 8
        // Inicializando o vetor origem da letra N - Coordenada (-2, 0, -4)
        beginPositionN = new Vector3(-2, 0, -4); // ref 9
        // Inicializando o vetor origem da letra T - Coordenada (2, 0, -4)
        beginPositionT = new Vector3(2, 0, -4); // ref 10
        // Inicializando o vetor origem da letra E - Coordenada (17, 0, -4)
        beginPositionE = new Vector3(17, 0, -4); // ref 11
        // Inicializando o vetor origem da letra R - Coordenada (36, 0, 26)
        beginPositionR = new Vector3(36, 0, 26); // ref 12

        // Inicializando o vetor final da letra H
        endPositionH = Helper.letraH();
        // Inicializando o vetor final da letra U
        endPositionU = Helper.letraU();
        // Inicializando o vetor final da letra N
        endPositionN = Helper.letraN();
        // Inicializando o vetor final da letra T
        endPositionT = Helper.letraT();
        // Inicializando o vetor final da letra E2
        endPositionE = Helper.letraE2();
        // Inicializando o vetor final da letra R2
        endPositionR = Helper.letraR2();

        startLerping();
    }

    // Update is called once per frame
    void Update()
    {
        // Learping control
        control.transform.position = Lerp(beginPositionControl, endPositionControl, timeStartedLerping, velocidadeControl);

        // Learping letra H
        for (int i = 0; i <= 27; i++)
        {
            letraH[i].transform.position = Lerp(beginPositionH, endPositionH[i], timeStartedLerping, velocidadeH[i]);
        }

        // Learping letra U
        for (int i = 0; i <= 17; i++)
        {
            letraU[i].transform.position = Lerp(beginPositionU, endPositionU[i], timeStartedLerping, velocidadeU[i]);
        }

        // Learping letra N
        for (int i = 0; i <= 27; i++)
        {
            letraN[i].transform.position = Lerp(beginPositionN, endPositionN[i], timeStartedLerping, velocidadeN[i]);
        }

        // Learping letra T
        for (int i = 0; i <= 17; i++)
        {
            letraT[i].transform.position = Lerp(beginPositionT, endPositionT[i], timeStartedLerping, velocidadeT[i]);
        }

        // Learping letra E
        for (int i = 0; i <= 22; i++)
        {
            letraE[i].transform.position = Lerp(beginPositionE, endPositionE[i], timeStartedLerping, velocidadeE[i]);
        }

        // Learping letra R
        for (int i = 0; i <= 23; i++)
        {
            letraR[i].transform.position = Lerp(beginPositionR, endPositionR[i], timeStartedLerping, velocidadeR[i]);
        }

    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
