using UnityEngine;

public class SphereFactory : Factory
{

    [SerializeField]
    private GameObject _spherePrefab;
    private IProduct _product;
    private GameObject _cloneSphere;
    public override IProduct GetProduct(Vector3 Position)
    {
        _cloneSphere = Instantiate(_spherePrefab, Position, Quaternion.identity);
        _product = _cloneSphere.GetComponent<IProduct>();
        _product.Initialize();
        Destroy(_cloneSphere, 2);
        return _product;
    }

    
}
