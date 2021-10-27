using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBallLifeSpan : MonoBehaviour
{
    [SerializeField]
    private Transform self;

    private void IsUnderWater()
    {
        if (self.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsUnderWater();
    }
}
