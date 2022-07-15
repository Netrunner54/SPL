using UnityEngine;
using UnityEngine.UI;

public class MapGenerator : MonoBehaviour
{
    public GameObject Platform0;
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
    public GameObject Platform4;
    public GameObject Platform5;
    public GameObject Platform6;
    public GameObject Platform7;
    public GameObject Platform8;
    public GameObject Platform9;
    public GameObject Platform10;

    public GameObject player;

    public TMPro.TextMeshProUGUI score;

    private int generatedPlatforms = 0;
    public int level = 0;

    void Update()
    {
        int PlayerLevel = (int)(player.transform.position.y - -4f) / 2;
        if (PlayerLevel + 5 > generatedPlatforms)
        {
            GameObject RandomPlatform = Platform0;
            int P = (int)Random.Range(1.0f, 12.0f);
            if (P == 1) { RandomPlatform = Platform0; }
            else if (P == 2) { RandomPlatform = Platform1; }
            else if (P == 3) { RandomPlatform = Platform2; }
            else if (P == 4) { RandomPlatform = Platform3; }
            else if (P == 5) { RandomPlatform = Platform4; }
            else if (P == 6) { RandomPlatform = Platform5; }
            else if (P == 7) { RandomPlatform = Platform6; }
            else if (P == 8) { RandomPlatform = Platform7; }
            else if (P == 9) { RandomPlatform = Platform8; }
            else if (P == 10) { RandomPlatform = Platform9; }
            else if (P == 11) { RandomPlatform = Platform10; }
            Instantiate(RandomPlatform, new Vector3(0.0f, generatedPlatforms * 2.0f - 2.0f, 0.0f), Quaternion.identity);
            generatedPlatforms++;
        }
        
        if (PlayerLevel > level)
        {
            level++;
        }
        score.text = level.ToString();
    }
}
