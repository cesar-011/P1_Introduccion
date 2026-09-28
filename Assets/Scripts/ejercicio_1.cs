using UnityEngine;

public class prueba : MonoBehaviour 
{
    private Color color;
    public int frame_number = 120;
    private int frame_iter = 0;
    private Renderer rend;
    void Start() 
    {
        rend = GetComponent<Renderer>();
        // Código de inicialización
        color = new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
        rend.material.color = color;
    }

  void Update()
  {
    // Código que se ejecuta en cada frame
    if (frame_number == frame_iter)
    {
      int random_pos = Random.Range(0, 3);
      float random_color = Random.Range(0.0f, 1.0f);
      switch (random_pos)
      {
        case 0:
          color.r = random_color;
          break;
        case 1:
          color.g = random_color;
          break;
        case 2:
          color.b = random_color;
          break;
      }
      frame_iter = 0;
    }
    ++frame_iter;
    rend.material.color = color;
  }
}