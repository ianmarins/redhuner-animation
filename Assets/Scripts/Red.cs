using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    // Referências de origem e fim das letras
    Vector3 beginPositionR;
    List<Vector3> endPositionR;

    Vector3 beginPositionE;
    List<Vector3> endPositionE;

    Vector3 beginPositionD;
    List<Vector3> endPositionD;

    Vector3 beginPositionControl;
    Vector3 endPositionControl;

    // Lista de velocidade das letras
    List<int> velocidadeR;
    List<int> velocidadeE;
    List<int> velocidadeD;
    int velocidadeControl;

    // Lista de objetos das letras
    List<GameObject> letraR;
    List<GameObject> letraE;
    List<GameObject> letraD;
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
        beginPositionControl = new Vector3(0, 0, -11);
        endPositionControl = new Vector3(0, 0, -10);

        // Instanciando os cubos letra R - Total de 24 cubos
        letraR = new List<GameObject>();
        for (int i = 0; i <= 23; i++)
        {
            letraR.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra E - Total de 23 cubos
        letraE = new List<GameObject>();
        for (int i = 0; i <= 22; i++)
        {
            letraE.Add(Helper.createLetraColor(red));
        }
        // Instanciando os cubos letra D - Total de 22 cubos
        letraD = new List<GameObject>();
        for (int i = 0; i <= 21; i++)
        {
            letraD.Add(Helper.createLetraColor(red));
        }

        // Instanciando a velocidade da letra R - Intervalo entre 10 e 25
        velocidadeR = new List<int>();
        for (int i = 0; i <= 23; i++)
        {
            velocidadeR.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da letra E - Intervalo entre 10 e 25
        velocidadeE = new List<int>();
        for (int i = 0; i <= 22; i++)
        {
            velocidadeE.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da letra D - Intervalo entre 10 e 25
        velocidadeD = new List<int>();
        for (int i = 0; i <= 21; i++)
        {
            velocidadeD.Add(Random.Range(10, 25));
        }

        // Inicializando o vetor origem da letra R - Coordenada (-2, 0, -4)
        beginPositionR = new Vector3(-2, 0, -4); // ref 9
        // Inicializando o vetor origem da letra E - Coordenada (2, 0, -4)
        beginPositionE = new Vector3(2, 0, -4); // ref 10
        // Inicializando o vetor origem da letra D - Coordenada (36, 0, 26)
        beginPositionD = new Vector3(36, 0, 26); // ref 12

        // Inicializando o vetor final da letra R
        endPositionR = Helper.letraR();
        // Inicializando o vetor final da letra E
        endPositionE = Helper.letraE();
        // Inicializando o vetor final da letra D
        endPositionD = Helper.letraD();

        startLerping();
    }

    // Update is called once per frame
    void Update()
    {
        // Learping control
        control.transform.position = Lerp(beginPositionControl, endPositionControl, timeStartedLerping, velocidadeControl);

        // Learping letra R
        for (int i = 0; i <= 23; i++)
        {
            letraR[i].transform.position = Lerp(beginPositionR, endPositionR[i], timeStartedLerping, velocidadeR[i]);
        }

        // Learping letra E
        for (int i = 0; i <= 22; i++)
        {
            letraE[i].transform.position = Lerp(beginPositionE, endPositionE[i], timeStartedLerping, velocidadeE[i]);
        }

        // Learping letra D
        for (int i = 0; i <= 21; i++)
        {
            letraD[i].transform.position = Lerp(beginPositionD, endPositionD[i], timeStartedLerping, velocidadeD[i]);
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
