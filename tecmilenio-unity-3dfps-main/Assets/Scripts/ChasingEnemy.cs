using UnityEngine;

public class ChasingEnemy : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float moveSpeed = 3f; // Velocidad de movimiento
    public float chaseDistance = 3f; // Distancia para comenzar a perseguir

    void Update()
    {
        // Calcular la distancia al jugador
        float distance = Vector3.Distance(transform.position, player.position);

        // Perseguir al jugador si está dentro del rango
        if (distance <= chaseDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
}