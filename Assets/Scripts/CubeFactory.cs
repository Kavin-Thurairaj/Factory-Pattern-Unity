using UnityEngine;

public class CubeFactory : Factory
{

    [SerializeField]
    private GameObject cubePrefab;
    private IProduct product;
    private GameObject cubeClone;


    public override IProduct GetProduct(Vector3 Position)
    {
        cubeClone = Instantiate(cubePrefab, Position, Quaternion.identity);
        product = cubeClone.GetComponent<IProduct>();
        product.Initialize();

        Destroy(cubeClone,2);
        return product;
    }

}
