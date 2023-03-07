using UnityEngine;

public class Enemy : MonoBehaviour
{
    public delegate void EnemyDestroyed(float pointValue);

    public static event EnemyDestroyed OnEnemyAboutToBeDestroyed;

    public int pointValue = 50;
    
    
    //-----------------------------------------------------------------------------
    void OnCollisionEnter2D()
    {
        // todo - trigger death animation
        Debug.Log("Ouch!");

        OnEnemyAboutToBeDestroyed.Invoke(pointValue);
        Destroy(this.gameObject);
    }
}
