using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AssetController : MonoBehaviour
{

    [SerializeField]
    AssetReference level;
    // Start is called before the first frame update
    void Start()
    {
        level.InstantiateAsync(Vector2.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
