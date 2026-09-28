using UnityEngine;

public class ejercicio_2 : MonoBehaviour
{
  public Vector3 vector_1;
  public Vector3 vector_2;
  void Start()
  {
    
    float magnitud_vect_1 = vector_1.magnitude;
    float magnitud_vect_2 = vector_2.magnitude;

    float angle = Vector3.Angle(vector_1, vector_2);

    float distance = Vector3.Distance(vector_1, vector_2);


    Debug.Log($"Magnitud vector 1: {magnitud_vect_1}");
    Debug.Log($"Magnitud vector 2: {magnitud_vect_2}");
    Debug.Log($"Angulo entre los vectores: {angle}");
    Debug.Log($"Distancia entre los vectores: {distance}");

    if (vector_1.y > vector_2.y)
    {
      Debug.Log($"El vector 1 tiene mayor altura");
    }
    else if (vector_2.y > vector_1.y)
    {
      Debug.Log($"El vector 2 tiene mayor altura");
    }
    else
    {
      Debug.Log($"Los vectores están a la misma altura");
    }
  }
}
