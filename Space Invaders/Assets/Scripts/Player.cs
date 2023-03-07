using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    [FormerlySerializedAs("bullet")] public GameObject bulletPrefab;
    [FormerlySerializedAs("shootingOffset")] public Transform shootOffsetTransform;

    //private Animator playerAnimator;

    //-----------------------------------------------------------------------------
    //void Start()
    //{
      //  playerAnimator = GetComponent<Animator>();
    //}

    //-----------------------------------------------------------------------------
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //todo - trigger a "shoot" on the animator
            //playerAnimator.SetTrigger("Shoot Trigger");
            
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);
        }

        float movement = Input.GetAxisRaw("Horizontal") * moveSpeed;
        transform.position += Vector3.right * movement * Time.deltaTime;
    }
}
