using UnityEngine;

public class Boomerang : MonoBehaviour
{
    public float speed = 10f;  // 이동 속도
    public float maxDistance = 10f; // 최대 이동 거리

    public float Damage = 100f;

    private Vector2 startPos;
    private Vector2 targetPos;
    private bool returning = false;

    // void Start()
    // {
    //     Throw(Vector2.right);
    // }

    public void Throw(Vector2 direction)
    {
        startPos = transform.position;
        targetPos = startPos + direction.normalized * maxDistance; // 던지는 방향으로 일정 거리 이동
        returning = false;
    }

    void Update()
    {
        if (!returning)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            // 목표 위치에 도달하면 돌아오게 설정
            if (Vector2.Distance(transform.position, targetPos) < 0.1f)
            {
                returning = true;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, GameManager.Instance.Player.transform.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, GameManager.Instance.Player.transform.position) < 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }
}