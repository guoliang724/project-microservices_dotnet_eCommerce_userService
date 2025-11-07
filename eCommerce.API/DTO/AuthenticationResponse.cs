namespace eCommerce.API.DTO
{
    public record AuthenticationResponse(Guid UserID,string? Email,string? PersonaName,string? Gender,string? Token,bool Sucess);
}
