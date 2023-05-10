using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// 游戏管理员
/// </summary>
public class Game1_M : MonoBehaviour
{
    public static Game1_M initialize;

    public GameObject[] wenZhis;

    public List<Vector3> jiLu;
    private void Awake()
    {
        initialize = this;
        foreach (var item in wenZhis)
        {
            jiLu.Add(item.transform.localPosition);
        }
    }
    public int fen;

    public Text text;

    public GameObject game;

    public void StartGame()
    {
        game.SetActive(true);
        for (int i = 0; i < wenZhis.Length; i++)
        {
            wenZhis[i].transform.localPosition = jiLu[i];
            wenZhis[i].transform.localEulerAngles = Vector3.zero;
        }
        fen = 0;
    }
    public void FanHui()
    {
        SceneManager.LoadSceneAsync(0);
        game.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "score: " + fen.ToString();
    }
}
