using UnityEngine;

public class Cube : MonoBehaviour , IProduct
{
    public string ProductName { get; set; } = "Cube";

    private AudioSource audio;

    public void Initialize()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
        Debug.Log(ProductName + " Spawned For You");
    }

    
}
