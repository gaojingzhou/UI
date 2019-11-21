using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blood : MonoBehaviour
{
    public float blood;
    public float res;
    public Rect rect;
    public Rect add;
    public Rect minus;
    public Rect layout;
    // Start is called before the first frame update
    void Start()
    {
        res = blood;
        rect = new Rect(200, 100, 200, 15);
        add = new Rect(420, 100, 20, 20);
        minus = new Rect(160, 100, 20, 20);
        layout = new Rect(150, 70, 300, 50);
    }

    private void OnGUI()
    {
        
        if (GUI.Button(add, "+"))
        {
            res = res + 0.1f > 1 ? 1 : res + 0.1f;
        }
        if (GUI.Button(minus, "-"))
        {
            res = res - 0.1f < 0 ? 0 : res - 0.1f;
        }
        GUI.Box(layout, "Blood");
        blood = Mathf.Lerp(blood, res, 0.05f);
        GUI.HorizontalScrollbar(rect, 0, blood, 0, 1);
    }
}
