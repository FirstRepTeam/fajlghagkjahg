using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UnformatButtons : MonoBehaviour//, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
 {
    Image CountryImg;
    public GameObject shop;
    public GameObject map;
    public GameObject inventory;
    Image SelectCountry;
    // public event testclickimage TapEvent;
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    // public Texture2D gg;
    public Image img;
    Vector3 initialVectorBottomLeft;
    Vector3 initialVectorTopRight;

    Vector3 UpdatedVectorBottomLeft;
    Vector3 UpdatedVectorTopRight;

    Camera MainCamera;
    public float lastScreenWidth = 0f;
    void Start()
    {
        lastScreenWidth = Screen.width;
        ResizeSpriteToScreen();
    }

    void Update()
    {
        if (lastScreenWidth != Screen.width)
        {
            lastScreenWidth = Screen.width;
            ResizeSpriteToScreen();
        }

    }

   
    private void ResizeSpriteToScreen()
    {
        float worldSpriteWidth = GetComponent<SpriteRenderer>().sprite.bounds.size.x;

        // get the screen height & width in world space units
        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = (worldScreenHeight / Screen.height) * Screen.width;

        // initialize new scale to the current scale
        Vector3 newScale = transform.localScale;

        // divide screen width by sprite width, set to X axis scale
        newScale.x = worldScreenWidth / worldSpriteWidth;

        // apply scale change
        transform.localScale = newScale;
       
    }
}
