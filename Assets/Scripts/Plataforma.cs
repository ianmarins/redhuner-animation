using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    // Referências de origem e fim das listas da plataforma
    Vector3 beginPostionPlat1; // Coordenada (-36, 0, 25) - Total de 525 cubos
    List<Vector3> endPositionPlat1;

    // Lista de velocidade dos objetos da plat1
    List<int> velocidadePlat1;

    // Listas de Objetos da plataforma
    List<GameObject> pisoPlat1;

    public float timeStartedLerping;

    private void startLerping()
    {
        timeStartedLerping = Time.time;
    }

    void Start()
    {
        // Instanciando os cubos pisoPlat1 - Total de 525 cubos
        pisoPlat1 = new List<GameObject>();
        for(int i = 0; i <= 524; i++)
        {
            pisoPlat1.Add(Helper.createPiso());
        }

        // Instanciando a velocidade da Plat1 - Intervalo entre 10 e 25
        velocidadePlat1 = new List<int>();
        for(int i = 0; i <= 524; i++)
        {
            velocidadePlat1.Add(Random.Range(10, 25));
        }

        // Inicializando o vetor origem do pisoPlat1 - Coordenada (-36, 0, 25)
        beginPostionPlat1 = new Vector3(-36, 0, 25);

        // Adicionando as coordenadas finais de cada cubo - (12, 0, 0) até (32, 0, 24)
        endPositionPlat1 = new List<Vector3>();
        for(int i = 12; i <= 32; i++)
        {
            for(int y = 0; y <= 24; y++)
            {
                endPositionPlat1.Add(new Vector3(i, 0, y));
            }
        }

        startLerping();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i <=524; i++)
        {
            pisoPlat1[i].transform.position = Lerp(beginPostionPlat1, endPositionPlat1[i], timeStartedLerping, velocidadePlat1[i]);
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
