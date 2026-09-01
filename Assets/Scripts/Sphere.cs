using UnityEngine;

public class Sphere : MonoBehaviour , IProduct
{

    private ParticleSystem _particleSystem;
    public string ProductName { get; set; } = "Sphere";

    public void Initialize()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        _particleSystem.Play();
        Debug.Log(ProductName +" Spawned For You");
    }
}
