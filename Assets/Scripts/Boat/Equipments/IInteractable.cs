public interface IInteractable
{
    public void InteractWith(PlayerController player);
    public void UninteractWith(PlayerController player);

    public void OnAction();
}
