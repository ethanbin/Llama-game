using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private const string ENEMY_PREFAB = "Enemy";

    private float rightX;
    private float leftX;

    void Start()
    {
        rightX = GetComponentInChildren<MeshRenderer>().bounds.size.x/2;
        leftX = -rightX;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateEnemyInRandomPosition() {
        GameObject o = Instantiate(Resources.Load(ENEMY_PREFAB) as GameObject);
        o.transform.parent = transform;
        var v = new Vector3(Random.Range(leftX, rightX), 0, 0);
        o.transform.localPosition = v;
    }
}
