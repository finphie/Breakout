using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject blockPrefab;

    [SerializeField]
    Vector3 startPosition = default;

    [SerializeField]
    int blockCountX = default;

    [SerializeField]
    int blockCountZ = default;

    void Awake()
    {
        var position = startPosition;

        for (var x = 0; x < blockCountX; x++)
        {
            position.z = startPosition.z;

            for (var z = 0; z < blockCountZ; z++)
            {
                Instantiate(blockPrefab, position, Quaternion.identity, transform);

                position.z += blockPrefab.transform.localScale.z * 1.3F;
            }

            position.x += blockPrefab.transform.localScale.x * 1.3F;
        }
    }

    void Start()
        => GameManager.Instance.BlockCount = blockCountX * blockCountZ;
}