using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    void Update()
    {
        //Move diagonally down and right
        transform.Translate(new Vector3(1, -1, 0) * Time.deltaTime * 3f);

        //Remove enemy when it leaves the screen
        if (transform.position.y < -6.5f || transform.position.x > 10f)
        {
            Destroy(this.gameObject);
        }
    }
}


