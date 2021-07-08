public class Item : MonoBehaviour
{
	public int index = 0; //Номер предмета, в этой игре будет всего 3 типа брони, поэтому писать более сложный скрипт нет смысла

	void OnTriggerEnter2D(Collider2D obj) //«Наезд» на объект
	{
		if (obj.transform.tag == "Player") 
		{
			obj.GetComponent<Items>().AddItem(index);//Если наехал игрок, то он сможет подобрать предмет
			Destroy(gameObject); //Удаление объекта с карты
		}
	}
}