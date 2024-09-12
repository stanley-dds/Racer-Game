using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject road;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(transform.position.y <-8f)
        {
            Instantiate(road, new Vector3(0.026f,6.97f,0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
