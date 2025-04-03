using UnityEngine;

public class MovimientoCapsula : MonoBehaviour
{
    public float fuerza = 1f;
    public float velocidadMovimiento = 5f;
    private Rigidbody rb;
    private bool enSuelo = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento horizontal con WASD
        float movimientoX = Input.GetAxis("Horizontal") * velocidadMovimiento * Time.deltaTime;
        float movimientoZ = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(new Vector3(movimientoX, 0, movimientoZ));

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
            enSuelo = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true; // Activa la variable cuando toca el suelo
            Debug.Log("La c�psula toc� el suelo"); // Mensaje de depuraci�n
        }
    }
}
  