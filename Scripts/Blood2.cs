using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blood2 : MonoBehaviour
{
    public float blood;
    public float res;
    public Rect add;
    public Rect minus;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        res = blood;
        add = new Rect(420, 100, 20, 20);
        minus = new Rect(160, 100, 20, 20);
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
        blood = Mathf.Lerp(blood, res, 0.05f);
        slider.value = blood;
    }
}
