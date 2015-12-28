using UnityEngine;
using System.Collections;

public class PanoramaControler : MonoBehaviour
{
    public GameObject prefab;
    public GameObject currentImage;
    GameObject leftImage;
    GameObject rightImage;
    public RectTransform mask;
    public float speed;
    float defaultSpeed;


    void Awake()
    {
        defaultSpeed = speed;
    }

    void Update()
    {
        SpeedUp();

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Left();
           
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            Right();

        }
    }

    public void SpeedUp ()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            defaultSpeed = speed;
            speed = speed * 3;
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            speed = defaultSpeed;
        }

        //else
        //{
        //    speed = defaultSpeed;
       // }

            

    }
    void LateUpdate()
    {
        if(currentImage.GetComponent<RectTransform>().anchoredPosition.x > -100f && leftImage == null)
        {
            leftImage = Instantiate(prefab);
            leftImage.GetComponent<RectTransform>().SetParent(mask, false);
            leftImage.GetComponent<RectTransform>().anchoredPosition = currentImage.GetComponent<RectTransform>().anchoredPosition - new Vector2(5376f, 0f);
        }
        if (currentImage.GetComponent<RectTransform>().anchoredPosition.x < -3932f && rightImage == null)
        {
            rightImage = Instantiate(prefab);
            rightImage.GetComponent<RectTransform>().SetParent(mask, false);
            rightImage.GetComponent<RectTransform>().anchoredPosition = currentImage.GetComponent<RectTransform>().anchoredPosition - new Vector2(-5376f, 0f);
        }

        if (currentImage.GetComponent<RectTransform>().anchoredPosition.x > 1444)
        {
            rightImage = currentImage;
            currentImage = leftImage;
            leftImage = null;
        }

        if (currentImage.GetComponent<RectTransform>().anchoredPosition.x < -5475)
        {
            leftImage = currentImage;
            currentImage = rightImage;
            rightImage = null;
        }

        if (rightImage != null && rightImage.GetComponent<RectTransform>().anchoredPosition.x >= 5376)
        {
            Destroy(rightImage);
        }

        if (leftImage != null && leftImage.GetComponent<RectTransform>().anchoredPosition.x <= -5376)
        {
            Destroy(leftImage);
        }

    }
    public void Left()
    {
        currentImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * speed;
        if(leftImage != null)
        {
            leftImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * speed;
        }
        if(rightImage != null)
        {
            rightImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(1f, 0f) * Time.deltaTime * speed;
        }
    }
    public void Right()
    {
        currentImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * speed;
        if (leftImage != null)
        {
            leftImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * speed;
        }
        if (rightImage != null)
        {
            rightImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(1f, 0f) * Time.deltaTime * speed;
        }
    
    }
}
