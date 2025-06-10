using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace GridScene
{
    public class MovementScript : MonoBehaviour
    {
        [SerializeField]
        private float moveTime = 0.5f;
        [SerializeField]
        private float backTime = 0.5f;

        [SerializeField]
        private float DashTime = 0.5f;

        //[SerializeField]
        //private float DashDistance = 5f;

        public Vector3 MoveDirection { set; get; } = Vector3.zero;
        public bool IsMove { set; get; } = false;

        private IEnumerator Start()
        {
            while (true)
            {
                if (MoveDirection != Vector3.zero && IsMove == false)
                {
                    Vector3 end = transform.position + MoveDirection;

                    if (end.y > 4 || end.y < -4)
                    {
                        MoveDirection = Vector3.zero;
                    }
                    else
                    {
                        if (MoveDirection.x < 0)
                        {
                            end.x -= 1;
                        }
                        yield return StartCoroutine(GridSmoothMovement(end));
                    }
                }

                if (MoveDirection == Vector3.zero && IsMove == false)
                {
                    transform.Translate(Vector2.left * backTime * Time.deltaTime, Space.World);
                    //yield return StartCoroutine(GridSmoothMovement(back));
                    yield return null;
                }

                yield return null;
            }
        }


        private IEnumerator GridSmoothMovement(Vector3 end)
        {
            Vector3 Start = transform.position;
            float current = 0;
            float percent = 0;

            IsMove = true;

            while (percent < 1)
            {
                current += Time.deltaTime;
                percent = current / moveTime;

                transform.position = Vector3.Lerp(Start, end, percent);

                yield return null;
            }

            IsMove = false;
        }

        public void OverClockDash()
        {
            Vector3 Dash = transform.position + MoveDirection;
            StartCoroutine(GridDashMovement(Dash));

        }

        private void DashMovement()
        {

        }

        private IEnumerator GridDashMovement(Vector3 end)
        {
            for (int i = 0; i < 3; i++)
            {
                Vector3 Start = transform.position;
                float current = 0;
                float percent = 0;

                IsMove = true;

                while (percent < 1)
                {
                    current += Time.deltaTime;
                    percent = current / DashTime;

                    transform.position = Vector3.Lerp(Start, end, percent);

                    yield return null;
                }

                IsMove = false;
            }
        }
    }

}
