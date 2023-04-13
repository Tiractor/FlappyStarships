using UnityEngine;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
    [SerializeField] private string GoToTheScene;
    [SerializeField] private Rigidbody _Rigidbody;
    [SerializeField] private float _Speed = 5;
    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody>(); // Saving standart output Source for more quickly 
    }
    public void Left()
    {
        _Rigidbody.AddForce(new Vector3(0, 0, _Speed));
    }
    public void Right()
    {
        _Rigidbody.AddForce(new Vector3(0, _Speed, 0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(GoToTheScene);
    }
}
