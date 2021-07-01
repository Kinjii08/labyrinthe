using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 4f, curSpeed;
    private float rotation = 100f, fastRotation;
    [SerializeField]
    GameObject ImGameOver;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = speed * 2;
            fastRotation = rotation * (float)1.5;
        }else
        {
            curSpeed = speed;
            fastRotation = rotation;
        }
        transform.Rotate(Vector3.up * fastRotation * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }

    public void GameOver()
    {
        ImGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
