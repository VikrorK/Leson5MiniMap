using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform PlayerTransform; //трансформ игрока
    public GameObject Map; //UI объект карты
    private bool mapOpen=false; //условие на открытие карты
    // Start is called before the first frame update
    void Start()
    {
        Map.SetActive(false); //выключаем карту
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)&&mapOpen==false){//если нажали кнопку M и карта отключена
            Map.SetActive(true); //включаем карту
            mapOpen=true; //устанавливаем, что карта включена
        }
        else if(Input.GetKeyDown(KeyCode.M)&&mapOpen==true){//если нажали кнопку M и карта включена
            Map.SetActive(false); //отключаем карту
            mapOpen=false; //устанавливаем, что карта отключена
        }

       MapPosition(); //функция слежения камеры за игроком
    }

    void MapPosition(){
        Vector3 newPos = PlayerTransform.position; //устанавливаем новую переменную для перемещения камеры за игроком
        newPos.y=transform.position.y; //фиксируем ось y на текщей высоте камеры
        transform.position=newPos; //двигаем камеру за игроком
    }
}
