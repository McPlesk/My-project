using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_spikes : MonoBehaviour
{
    private float rotate;
    public float RotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate += Time.deltaTime * RotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotate);
    }
}
