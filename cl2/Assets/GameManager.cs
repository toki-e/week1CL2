using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float currentPage = 1;
    public float timer = 30;
    public KeyCode downKey = KeyCode.S;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode upKey = KeyCode.W;

    public GameObject hiraA; //hiragana alphabet letter A
    public GameObject hiraO; //letter O etc
    public GameObject hiraI; 
    public GameObject hiraMa;
    public GameObject hiraMa2;
    public GameObject hiraI2;
    public GameObject hiraSe;

    public GameObject WSpr;
    public GameObject ASpr;
    public GameObject SSpr;
    public GameObject DSpr;
    public GameObject checkMark;

    public GameObject bwArt;
    public GameObject mikuArt;
    public GameObject bunch;

    public Text topText;
    public Text middleText;
    public Text timeText;

    public bool last = false;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        timeText.text = "Time:" + timer;

        if (timer <= 0) {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene(1);
        }

		if (currentPage == 1)
        {
            if (Input.GetKey(downKey)){
                currentPage = 2;
                Debug.Log("currentPage");
            }

        }

        if (currentPage == 2)
        {
            topText.text = "How about now?";
            middleText.text = "";

            hiraA.transform.position = new Vector2(3, -44.18f);
            hiraO.SetActive(true);
            hiraMa.SetActive(true);

            ASpr.SetActive(true);
            DSpr.SetActive(true);

            SSpr.transform.position = new Vector2(0.36f, -45.61f);
            checkMark.SetActive(false);

            if (Input.GetKey(rightKey))
            {
                currentPage = 3;
                Debug.Log(currentPage);
            }

        }

        if (currentPage == 3)
        {
            bwArt.SetActive(true);
            topText.text = "Can you find it now?";
            hiraA.transform.position = new Vector2(2.402f, -45.12f);
            hiraMa.transform.position = new Vector2(-0.588f, -44.563f);
            hiraO.transform.position = new Vector2(-0.713f, -45.97f);

            hiraA.transform.localScale = new Vector3(0.1231479f, 0.12039f, 0.1206448f);
            hiraMa.transform.localScale = new Vector3(0.1231479f, 0.12039f, 0.1206448f);
            hiraO.transform.localScale = new Vector3(0.1231479f, 0.12039f, 0.1206448f);

            ASpr.transform.position = new Vector2(-2.56f, -44.12f);
            SSpr.transform.position = new Vector2(-2.559f, -45.21f);
            DSpr.transform.position = new Vector2(-2.52f, -46.36f);

            if (Input.GetKey(downKey)) {

                currentPage = 4;
              
            }
        }

        if (currentPage == 4) {
            bwArt.SetActive(false);
            topText.text = "Good! Now?";
            mikuArt.SetActive(true);

            hiraA.transform.position = new Vector2(-4f, -44.74f);
            hiraMa.transform.position = new Vector2(-3.39f, -47.57f);
            hiraO.transform.position = new Vector2(-1.055f, -44.974f);

            ASpr.transform.position = new Vector2(-2.51f, -44.89f);
            SSpr.transform.position = new Vector2(-2.86f, -46.55f);
            DSpr.transform.position = new Vector2(-1.13f, -47.45f);

            hiraSe.SetActive(true);
            hiraI.SetActive(true);
            hiraI2.SetActive(true);
            hiraMa2.SetActive(true);

            if (Input.GetKey(leftKey)) {
                currentPage = 5;
            }

        }

        if(currentPage == 5)
        {
            topText.text = "The last one!";
            bunch.SetActive(true);
            mikuArt.SetActive(false);

            SSpr.transform.position = new Vector2(-2.86f, -45.61f);
            DSpr.transform.position = new Vector2(-0.05f, -45.61f);
            ASpr.transform.position = new Vector2(2.79f, -45.61f);

            hiraA.SetActive(false);

            if (Input.GetKey(downKey))
            {
                currentPage++;
                //last = false;
                Debug.Log(currentPage);
            }
        }

        if (currentPage == 6)
        {
            if (Input.GetKey(downKey))
            {
              topText.text = "Success!";
                bunch.SetActive(false);
            }
        }

    }
}
