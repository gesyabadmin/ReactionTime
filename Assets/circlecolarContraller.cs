using System.Collections;
using System.Collections.Genertic;
using UnityEngine;

/*public class CircleColorChange : MonoBehaviour
{
    private Renderer Circle; // 色変化するオブジェクト

    void Start()
    {
        Circle = GetComponent<Renderer>();
        Circle.material.color = new Color(1,0,0,1); //赤
    }

    void Update()
    {
        if (isWaitingForInput && Input.GetMouseButtonDown(0)) // 左クリックを検出
        {
            StartCoroutine("StartChangeColor");
        }
    }

    public void StartChangeColor()
    {
        Invoke("ChangeColor", Random.Range(1f, 3f)); // ランダムな時間後に色変化を開始
    }

    void ChangeColor()
    {
        Circle.material.color = new Color(0,0,1,1);
    }
}
*/


public class ColorChange : MonoBehaviour
{
    private Renderer cubeRend;
 
    void Start()
    {
        cubeRend= GetComponent<Renderer>();
        cubeRend.material.color = new Color(0, 0, 0, 1); //黒
    }
 
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        StartCoroutine("HitColor");
      }
    }
 
    IEnumerator HitColor()
    {
      cubeRend.material.color = new Color(1, 1, 1, 1); //白
      yield return new WaitForSeconds(0.5f);
      cubeRend.material.color = new Color(0, 0, 0, 1); //黒
    }
}