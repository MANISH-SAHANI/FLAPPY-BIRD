using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temp : MonoBehaviour
{
    public float speed;
    public void VisibilityToggle()
    {
        transform.position = transform.position + new Vector3(0,-speed * Time.deltaTime, 0);
    }


    public void Re()
    {
        print("Re");
        if (Input.GetMouseButton(0))
        {
            print("MOuse");
            SceneManager.LoadScene("Level1");
        }
    }

}
