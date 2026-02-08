using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float rotation_speed = 15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotation_speed*Time.deltaTime,0);

    }
}
