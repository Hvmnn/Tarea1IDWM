using System.ComponentModel.DataAnnotations;

namespace courses_dotnet_api.Src.DTOs.Account;

public class PasswordDto
{
    public required byte[] PasswordHash {get; set;}
    public required byte[] PasswordSalt {get; set;}   
}