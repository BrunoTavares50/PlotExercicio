namespace Plot.WebAPI.Services
{
    public interface IImageService
    {
        bool IsConfigured { get; }

        Task<string> UploadImagemAsync(IFormFile arquivo, ImageFolder pasta);
        Task<bool> DeleteImageAsync(string imageUrl);
    }
}
