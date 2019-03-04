using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Rendering;
using UnityEngine;
using Unity.Transforms;

public class CSpawning : MonoBehaviour
{

    [SerializeField] GameObject[] unitPrefabs;
    Vector3 [] spawns = new Vector3 [] { new Vector3 (0, 0, -3), new Vector3 (0, 0, -1.5f), new Vector3 (0, 0, 0), new Vector3 (0, 0, 1.5f), new Vector3 (0, 0, 3), new Vector3 (-3, 0, -3), new Vector3 (-3, 0, -1.5f), new Vector3 (-3, 0, 0), new Vector3 (-3, 0, 1.5f), new Vector3 (-3, 0, 3), new Vector3 (-1.5f, 0, -3), new Vector3 (-1.5f, 0, -1.5f), new Vector3 (-1.5f, 0, 0), new Vector3 (-1.5f, 0, 1.5f), new Vector3 (-1.5f, 0, 3), new Vector3 (1.5f, 0, -3), new Vector3 (1.5f, 0, -1.5f), new Vector3 (1.5f, 0, 0), new Vector3 (1.5f, 0, 1.5f), new Vector3 (1.5f, 0, 3), new Vector3 (3, 0, -3), new Vector3 (3, 0, -1.5f), new Vector3 (3, 0, 0), new Vector3 (3, 0, 1.5f), new Vector3 (3, 0, 3) };

    public void SpawnCube (Vector3 position)
    {
        Instantiate (unitPrefabs[Random.Range(0, 4)], transform.position + position, Quaternion.identity);
    }

    public Vector3[] GetSpawns ()
    {
        Vector3[] _spawns = spawns;
        return _spawns;
    }

}
