using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private bool _onMovement = true;
    void Update()
    {
        if (_onMovement)
        {
            Forward();
        }
    }

    private void Forward()
    {
        transform.Translate( new  Vector3(0,0,-1) * _speed * Time.deltaTime);
    }
    
}
