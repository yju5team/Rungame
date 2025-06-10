using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region singleton
    private static ScoreManager instance = null;

    void Awake()
    {
        if (null == instance)
        {
            instance = this;

            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static ScoreManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    #endregion
    public int score;
    public float curTime;
    public int[] levelEnemy = new int[3];
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        curTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartTimeScore()
    {
        StartCoroutine(TimeScore());
    }

    private IEnumerator TimeScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            score += 1;
            curTime += 0.1f;
        }
    }

    public void EnemyDeath(int Level)
    {
        score += 100 * Level;
        levelEnemy[Level - 1]++;
    }

    public void PlayerDeath()
    {
        DataManager.Instance.ScoreDataChange(WeaponSelect.Instance.type, score, levelEnemy[0], levelEnemy[1], levelEnemy[2]);

    }
}
