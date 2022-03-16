using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
