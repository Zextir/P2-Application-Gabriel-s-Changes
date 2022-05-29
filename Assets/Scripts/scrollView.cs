using UnityEngine;
using System.Collections;

public class scrollView : MonoBehaviour
{


    Vector2 scrollPosition;
    Touch touch;
    // The string to display inside the scrollview. 2 buttons below add & clear this string.
    string longString = "This is a long-ish string";

    void OnGUI()
    {
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.touches[0];
            if (touch.phase == TouchPhase.Moved)
            {
                scrollPosition.y += touch.deltaPosition.y;
            }
        }
    }
}