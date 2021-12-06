namespace Game.Interfaces
{
    public interface IPauseMenu
    {
        void ShowNextButton();
        void ShowPreviousButton();
        void SetActive(bool value);
    }
}