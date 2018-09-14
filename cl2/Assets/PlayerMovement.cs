using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode downKey;
    public KeyCode upKey;
    public KeyCode confirmKey;

    public float moveSpeed = 5;

    public GameObject check;

    public Vector2 playerPos;

    SpriteRenderer sprite;
    Renderer currentHighlightedObject = null;

    // Use this for initialization
    void Start () {
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;
        downKey = KeyCode.S;
        upKey = KeyCode.W;
        confirmKey = KeyCode.Space;

        playerPos = new Vector2(transform.position.x, transform.position.y);
        
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 rayPos = new Vector2(playerPos.x, playerPos.y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

        if (hit)
        {        
            Renderer hitRenderer = hit.collider.GetComponent<Renderer>();
            hitRenderer.material.color = Color.blue;

            if (currentHighlightedObject != hitRenderer && currentHighlightedObject != null)
            {
                currentHighlightedObject.material.color = Color.white;
            }
            currentHighlightedObject = hitRenderer;
        }




            if (Input.GetKey(leftKey))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
           // transform.Rotate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(rightKey))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(downKey))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(upKey))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == check) {
            Debug.Log("confirmready");
          }
    }
}
