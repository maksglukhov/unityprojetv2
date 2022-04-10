using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickLeft : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 startPoint, endPoint, initialPosition; //startpoint : detecte le point de depart lorsque l'on clique sur le joystick; endpoint : detecte le point d'arrivee quand on relache le joystick; InitialPosition : repositionne a l'endroit ou il doit etre au debut de la scene
    bool touchStart = false;
    public Transform Player;
    public float speed = 10f;
    public float offsetJoystick = 15f;
    void Start()
    {
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        startPoint = initialPosition;
    }

    private void OnMouseDrag()
    {
        touchStart = true;
        endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        touchStart = false;
    }

    private void Update()
    {
        if (touchStart)
        {
            Vector2 offset = endPoint - startPoint;
            Vector2 direction = Vector2.ClampMagnitude(offset, offsetJoystick);
            movePlayer(direction); //deplacement de l'objet
            transform.position = new Vector2(startPoint.x + direction.x, startPoint.y + direction.y); //deplacement du stick

        }
        else
        {
            transform.position = initialPosition; //reset de la position du stick pour l'effet "joystick"
        }

    }

    void movePlayer(Vector2 dir)//change ici la position
    {
        Player.Translate(dir * Time.deltaTime * speed);
    }
}
