using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Material[] mat_s;
    public void OnMouseDown() {
        gameObject.GetComponent<Renderer>().material=mat_s[Random.Range(0, mat_s.Length)];
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
