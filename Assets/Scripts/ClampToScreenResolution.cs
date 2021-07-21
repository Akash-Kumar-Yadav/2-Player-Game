using System.Collections;
using UnityEngine;

namespace Scripts
{
    public class ClampToScreenResolution : MonoBehaviour
    {
        float x;
        float y;
        Vector2 bound;

        private void Start()
        {
            bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        }
        private void LateUpdate()
        {
            Vector3 clamp = transform.position;
            clamp.x = Mathf.Clamp(clamp.x, -bound.x, bound.x);
            clamp.y = Mathf.Clamp(clamp.y, -bound.y, bound.y);
            transform.position = clamp;
           
        }
    }
}