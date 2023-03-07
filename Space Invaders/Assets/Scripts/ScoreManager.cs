using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy.OnEnemyAboutToBeDestroyed += EnemyOnOnEnemyAboutToBeDestroyed;
    }


    private void EnemyOnOnEnemyAboutToBeDestroyed(float pointValue)
    {
        Debug.Log("received the event for tallying score: {pointValue}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
