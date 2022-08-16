namespace RPG_Character_API.RPG.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string ErrorMessage { get; set; } = null;

    }
}
