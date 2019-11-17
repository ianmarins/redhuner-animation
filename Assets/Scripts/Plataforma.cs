using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    // Referências de origem e fim das listas da plataforma
    Vector3 beginPositionPlat1; // Coordenada (-36, 0, 25) - Total de 525 cubos
    List<Vector3> endPositionPlat1;

    Vector3 beginPositionPlat2; // Coordenada (-16, 0, -4) - Total de 572 cubos
    List<Vector3> endPositionPlat2;

    Vector3 beginPositionPlat3; // Coordenada (-1, 0, -4) - Total de 561 cubos
    List<Vector3> endPositionPlat3;

    Vector3 beginPositionPlat4; // Coordenada (1, 0, -4) - Total de 561 cubos
    List<Vector3> endPositionPlat4;

    Vector3 beginPositionPlat5; // Coordenada (16, 0, -4) - Total de 546 cubos
    List<Vector3> endPositionPlat5;

    Vector3 beginPositionPlat6; // Coordenada (36, 0, 25) - Total de 550 cubos
    List<Vector3> endPositionPlat6;

    // Lista de velocidade dos objetos da plat1
    List<int> velocidadePlat1;
    List<int> velocidadePlat2;
    List<int> velocidadePlat3;
    List<int> velocidadePlat4;
    List<int> velocidadePlat5;
    List<int> velocidadePlat6;

    // Listas de Objetos da plataforma
    List<GameObject> pisoPlat1;
    List<GameObject> pisoPlat2;
    List<GameObject> pisoPlat3;
    List<GameObject> pisoPlat4;
    List<GameObject> pisoPlat5;
    List<GameObject> pisoPlat6;

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
        // Instanciando os cubos pisoPlat2 - Total de 572 cubos
        pisoPlat2 = new List<GameObject>();
        for (int i = 0; i <= 571; i++)
        {
            pisoPlat2.Add(Helper.createPiso());
        }
        // Instanciando os cubos pisoPlat3 - Total de 561 cubos
        pisoPlat3 = new List<GameObject>();
        for (int i = 0; i <= 560; i++)
        {
            pisoPlat3.Add(Helper.createPiso());
        }
        // Instanciando os cubos pisoPlat4 - Total de 561 cubos
        pisoPlat4 = new List<GameObject>();
        for (int i = 0; i <= 560; i++)
        {
            pisoPlat4.Add(Helper.createPiso());
        }
        // Instanciando os cubos pisoPlat5 - Total de 546 cubos
        pisoPlat5 = new List<GameObject>();
        for (int i = 0; i <= 545; i++)
        {
            pisoPlat5.Add(Helper.createPiso());
        }
        // Instanciando os cubos pisoPlat6 - Total de 550 cubos
        pisoPlat6 = new List<GameObject>();
        for (int i = 0; i <= 549; i++)
        {
            pisoPlat6.Add(Helper.createPiso());
        }

        // Instanciando a velocidade da Plat1 - Intervalo entre 10 e 25
        velocidadePlat1 = new List<int>();
        for(int i = 0; i <= 524; i++)
        {
            velocidadePlat1.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da Plat2 - Intervalo entre 10 e 25
        velocidadePlat2 = new List<int>();
        for (int i = 0; i <= 571; i++)
        {
            velocidadePlat2.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da Plat3 - Intervalo entre 10 e 25
        velocidadePlat3 = new List<int>();
        for (int i = 0; i <= 571; i++)
        {
            velocidadePlat3.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da Plat4 - Intervalo entre 10 e 25
        velocidadePlat4 = new List<int>();
        for (int i = 0; i <= 571; i++)
        {
            velocidadePlat4.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da Plat5 - Intervalo entre 10 e 25
        velocidadePlat5 = new List<int>();
        for (int i = 0; i <= 571; i++)
        {
            velocidadePlat5.Add(Random.Range(10, 25));
        }
        // Instanciando a velocidade da Plat6 - Intervalo entre 10 e 25
        velocidadePlat6 = new List<int>();
        for (int i = 0; i <= 571; i++)
        {
            velocidadePlat6.Add(Random.Range(10, 25));
        }

        // Inicializando o vetor origem do pisoPlat1 - Coordenada (-36, 0, 25)
        beginPositionPlat1 = new Vector3(-36, 0, 25);
        // Inicializando o vetor origem do pisoPlat2 - Coordenada (-16, 0, -4)
        beginPositionPlat2 = new Vector3(-16, 0, -4);
        // Inicializando o vetor origem do pisoPlat3 - Coordenada (-1, 0, -4)
        beginPositionPlat3 = new Vector3(-1, 0, -4);
        // Inicializando o vetor origem do pisoPlat4 - Coordenada (1, 0, -4)
        beginPositionPlat4 = new Vector3(1, 0, -4);
        // Inicializando o vetor origem do pisoPlat5 - Coordenada (16, 0, -4)
        beginPositionPlat5 = new Vector3(16, 0, -4);
        // Inicializando o vetor origem do pisoPlat6 - Coordenada (36, 0, 25)
        beginPositionPlat6 = new Vector3(36, 0, 25);

        // Adicionando as coordenadas finais de cada cubo da Plat1 - (12, 0, 0) até (32, 0, 24)
        endPositionPlat1 = new List<Vector3>();
        for(int i = 12; i <= 32; i++)
        {
            for(int y = 0; y <= 24; y++)
            {
                endPositionPlat1.Add(new Vector3(i, 0, y));
            }
        }
        // Adicionando as coordenadas finais de cada cubo da Plat2 - (-32, 0, 25) até (-11, 0, 50)
        endPositionPlat2 = new List<Vector3>();
        for (int i = -32; i <= -11; i++)
        {
            for (int y = 25; y <= 50; y++)
            {
                endPositionPlat2.Add(new Vector3(i, 0, y));
            }
        }
        // Adicionando as coordenadas finais de cada cubo da Plat3 - (-10, 0, 0) até (0, 0, 50)
        endPositionPlat3 = new List<Vector3>();
        for (int i = -10; i <= 0; i++)
        {
            for (int y = 0; y <= 50; y++)
            {
                endPositionPlat3.Add(new Vector3(i, 0, y));
            }
        }
        // Adicionando as coordenadas finais de cada cubo da Plat4 - (1, 0, 0) até (11, 0, 50)
        endPositionPlat4 = new List<Vector3>();
        for (int i = 1; i <= 11; i++)
        {
            for (int y = 0; y <= 50; y++)
            {
                endPositionPlat4.Add(new Vector3(i, 0, y));
            }
        }
        // Adicionando as coordenadas finais de cada cubo da Plat5 - (12, 0, 25) até (32, 0, 50)
        endPositionPlat5 = new List<Vector3>();
        for (int i = 12; i <= 32; i++)
        {
            for (int y = 25; y <= 50; y++)
            {
                endPositionPlat5.Add(new Vector3(i, 0, y));
            }
        }
        // Adicionando as coordenadas finais de cada cubo da Plat6 - (-32, 0, 0) até (-11, 0, 24)
        endPositionPlat6 = new List<Vector3>();
        for (int i = -32; i <= -11; i++)
        {
            for (int y = 0; y <= 24; y++)
            {
                endPositionPlat6.Add(new Vector3(i, 0, y));
            }
        }


        startLerping();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i <=524; i++)
        {
            pisoPlat1[i].transform.position = Lerp(beginPositionPlat1, endPositionPlat1[i], timeStartedLerping, velocidadePlat1[i]);
        }

        for (int i = 0; i <= 571; i++)
        {
            pisoPlat2[i].transform.position = Lerp(beginPositionPlat2, endPositionPlat2[i], timeStartedLerping, velocidadePlat2[i]);
        }

        for (int i = 0; i <= 560; i++)
        {
            pisoPlat3[i].transform.position = Lerp(beginPositionPlat3, endPositionPlat3[i], timeStartedLerping, velocidadePlat3[i]);
        }

        for (int i = 0; i <= 560; i++)
        {
            pisoPlat4[i].transform.position = Lerp(beginPositionPlat4, endPositionPlat4[i], timeStartedLerping, velocidadePlat4[i]);
        }

        for (int i = 0; i <= 545; i++)
        {
            pisoPlat5[i].transform.position = Lerp(beginPositionPlat5, endPositionPlat5[i], timeStartedLerping, velocidadePlat5[i]);
        }

        for (int i = 0; i <= 549; i++)
        {
            pisoPlat6[i].transform.position = Lerp(beginPositionPlat6, endPositionPlat6[i], timeStartedLerping, velocidadePlat6[i]);
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
