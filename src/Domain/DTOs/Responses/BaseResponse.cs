using System.Net;

namespace Domain.DTOs.Responses;

public class Response<T>
{
    public required HttpStatusCode StatusCode { get; set; }
    public required T Data { get; set; }
}
