using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject blockPrefab;

    [SerializeField]
    Vector3 startPosition = default;

    void Awake()
    {
        var position = startPosition;

        for (var x = 0; x < 5; x++)
        {
            position.z = startPosition.z;

            for (var z = 0; z < 10; z++)
            {
                Instantiate(blockPrefab, position, Quaternion.identity, transform);

                position.z += blockPrefab.transform.localScale.z * 1.3F;
            }

            position.x += blockPrefab.transform.localScale.x * 1.3F;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}