using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] private float timeToHit;
    [SerializeField] private GameObject targetPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed;
    private Vector3 targetPosition;

    void Start() {
        Collider targetCollider = targetPlayer.GetComponentInChildren<Collider>();
        targetPosition = targetCollider.transform.position;
        speed = (targetPosition - transform.position).magnitude / timeToHit;
    }

    // Update is called once per frame
    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemy Trigger enter");
    }

}
