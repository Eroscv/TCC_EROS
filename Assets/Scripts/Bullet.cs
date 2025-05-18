using UnityEngine;

public class HomingBullet : MonoBehaviour
{
    public float speed = 6f;          // Velocidade da bala
    public float rotateSpeed = 300f;  // Velocidade de rota��o para mirar no alvo
    public float lifeTime = 5f;       // Tempo antes de destruir a bala

    private Transform target;         // Refer�ncia ao player

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        // Dire��o para o alvo
        Vector2 direction = (Vector2)target.position - (Vector2)transform.position;
        direction.Normalize();

        // Rota��o suave para seguir o alvo
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

        // Move o proj�til para frente
        transform.position += transform.right * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
        {
            // Aqui voc� pode adicionar dano ao player
            Destroy(gameObject);
        }
    }
}
