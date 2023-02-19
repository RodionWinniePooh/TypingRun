using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 200f;
    bool dragging = false;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        dragging = true;
    }
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }


        //transform.Rotate(new Vector3(0, 1, 0)); авто вращение

        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // поле зрение камеры
        //RaycastHit hit = new RaycastHit(); // хранит данные объекта с котором пересекся вектор камеры и параметры пересечения
        //if (Physics.Raycast(ray, out hit)) // выполняется если хоть один объект встретился
        //{
        //    Vector3 rot = transform.eulerAngles; // запись предыдущего угла Эйлера "Rotation"
        //    transform.LookAt(hit.point); // перевод в угол поворота из полученных координат при пересечении с объектом
        //    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); // установка нового угла
        //}
    }

    void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            //float y = Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.down * x);
            //rb.AddTorque(Vector3.right * y);
        }
    }
}
