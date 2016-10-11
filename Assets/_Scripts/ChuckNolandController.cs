using UnityEngine;
using System.Collections;

public class ChuckNolandController : MonoBehaviour {

    private Transform _transform;
	// Use this for initialization
	void Start () {

        this._transform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        this._move();
	
	}
private void _move() {

        this._transform.position = new Vector2(Mathf.Clamp(Input.mousePosition.x - 320f, -280f,280f), -190f);
    }
    //Another event that will cause collision to have on contact
    //you're not gonna remember this function onTriggerEnter2D built in function but you can look it up.
    //be careful to keep in mind the difference, this is 2D and Collider2D NOT Collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Flamingo")){
            //Debug.Log does what you want the Console panel to say when you hit something
            Debug.Log("HIT!!");
        }
        if (other.gameObject.CompareTag("Wave")){
            Debug.Log("Keep Rowing!!");
        }
    }
}
