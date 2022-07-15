using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float x, y, z;
    private float moveSpeed = 2.5f;

    public GameObject GUI;
    public GameObject GameOver;
    public MapGenerator MG;

    private bool end = false;

    private void Start()
    {
        x = 0;
        y = 0;
        z = transform.position.z;
    }

    void Update()
    {
        if (player.transform.position.y + 1 > y)
        {
            y += moveSpeed * Time.deltaTime;
            gameObject.transform.position = new Vector3(x, y, z);
        }
        if (player.transform.position.y + 5 < y && end == false)
        {
            Destroy(GUI);
            GameObject gameOver = Instantiate(GameOver, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            gameOver.GetComponent<GameOver>().score = MG.level;
            end = true;
        }
    }
}
