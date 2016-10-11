using UnityEngine;
using System.Collections;

public class WaveController : MonoBehaviour {

    //Private onstance variables

    //this variable adds speed to the clouds.
    private int _speed;

    //this variable will add a drift to the clouds so they don't only move one dimensional
    private int _drift;
    private Transform _transform;
    public int Speed
    {

        get
        {
            return this._speed;
        }
        set
        {

            this._speed = value;
        }
    }

    //a property
    public int Drift
    {
        get {

            return this._drift;
        }
        set {
            this._drift = value;
        } 
    }

    // Use this for initialization
    void Start()
    {
        //telling compiler that the transform component that directly comes from my object (ocean asset) 
        //I'm getting a reference to it and storing it into this private local variable _transform
        //so now my current position is being stored in the _transform component, keeps track of where I am
        //Transform keeps track of location, rotation and scale
        this._transform = this.GetComponent<Transform>();

        this. _reset();
        

    }
    // Update is called once per frame
    void Update()
    {
        this._move();
        this._checkBounds();
    }

    private void _move()
    {
        //now we created a Vector (cause it has an X and a Y 2d coordinates) new variable called newPosition and assigned it the value
        //of _transform so we can move from old orginal position (_transform) to new position(newPosition) with speed 5
        Vector2 newPosition = this._transform.position;

        //can't change the _transform variable since that would break the rules since it is equal to Transform directly but we can
        //modify newPosition as much as we want.
        //here we are saying take old coordination position from _transform and give it to newPosition then add _speed to it.
        newPosition.y -= this._speed;
        newPosition.x -= this._drift;
        //assigning back the new position thats had speed added to it
        this._transform.position = newPosition;
    }

    private void _checkBounds()
    {
        if (_transform.position.y <= -280f)
        {
            this._reset();
        }
    }
    private void _reset()
    {
        this._speed = Random.Range(5, 10);
        this._drift = Random.Range(-2, 2);

        //this._transform.position = new Vector2(0f, 272f);
        this._transform.position = new Vector2(Random.Range(-208F, 208F), 285f);
    }

}
