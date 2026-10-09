using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public GameObject target_prefab;
    [SerializeField]
    private BoxCollider2D spawnArea;


    private void OnEnable()
    {
        Target.TargetClicked += OnTargetClicked;
    }

    private void OnDisable()
    {
        Target.TargetClicked -= OnTargetClicked;
    }
    void OnTargetClicked()
    {
        SpawnNewTarget();
    }

    void SpawnNewTarget()
    {
        Bounds bounds = spawnArea.bounds;

        float minX = bounds.min.x;
        float maxX = bounds.max.x;
        float minY = bounds.min.y;
        float maxY = bounds.max.y;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(randomX, randomY, spawnArea.transform.position.z);
        Instantiate(target_prefab,spawnPosition,Quaternion.identity);
    }
}
