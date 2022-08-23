using UnityEngine;

public class DirectionPlayer : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           Movement(false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Movement(true);
        }
    }
    private void Movement(bool isRight)
    {
        float translation = isRight ? -10f : 10f;
        if (transform.position.x > 0)
        {
            if (isRight)
            {
                transform.position += new Vector3(-10, 0, 0);
            }
        }
        else if (transform.position.x < 0)
        {
            if (!isRight)
            {
                transform.position += new Vector3(10, 0, 0);
            }
        }
        else
        {
            transform.position += new Vector3(translation, 0, 0);
        }
        
    }
}
