using UnityEngine;

public class ejercicio_4 : MonoBehaviour
{
  void Start()
  {
    GameObject esfera = GameObject.FindWithTag("blue_sphere");
    GameObject cubo = GameObject.FindWithTag("cubo");
    GameObject cilindro = GameObject.FindWithTag("cilindro");

    float dist_esfera_cubo = Vector3.Distance(esfera.transform.position, cubo.transform.position);
    float dist_esfera_cilindro = Vector3.Distance(esfera.transform.position, cilindro.transform.position);

    Debug.Log($"Distancia de la esfera al cubo: {dist_esfera_cubo}");
    Debug.Log($"Distancia de la esfera al cilindro: {dist_esfera_cilindro}");
  }
}
