using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class BusinessProblemDetails:ProblemDetails
{
    public BusinessProblemDetails(string detail)
    {
        Title = "Rule Violation";     //hata başlığı
        Detail = detail;    //hata detayı
        Status = StatusCodes.Status400BadRequest;      //hata kodu
        Type = "https://example.com/probs/business";   //hata tipi, uydurma bir link
    }
}