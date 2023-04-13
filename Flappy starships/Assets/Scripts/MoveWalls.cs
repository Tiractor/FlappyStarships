using UnityEngine;
public class MoveWalls : MonoBehaviour
{
    [SerializeField] private float _Speed = 5;
    private Vector3 BasePos;
    private void Awake()
    {
        BasePos = transform.position;
    }
    private void Update()
    {
        transform.position += new Vector3(-0.02f * _Speed, 0, 0);
        if (transform.position.x <= -15) transform.position = BasePos;
    }
}
