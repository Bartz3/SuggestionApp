namespace SuggestionAppUI;

public static class RegisterServices // Confiugure injection
{
   public static void ConfigureServices(this WebApplicationBuilder builder)//extension method
   {
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMemoryCache(); // dodawanie Cache'a (buforowanie w pamięci) do aplikacji
   }
}
