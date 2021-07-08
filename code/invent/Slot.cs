public class Slot : MonoBehaviour
{
	public Sprite sprite; //Спрайт брони для этого слота

	public Image icon; //Иконка, куда будет прикрепляться спрайт

	public void UpdateSlot(bool active) //Обновление слота
	{
		if (active)
		{
			icon.sprite = sprite;
		}
		else
		{
			icon.sprite = null;
		}
	}
}