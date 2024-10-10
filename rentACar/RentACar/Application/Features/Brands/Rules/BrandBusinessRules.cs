using Application.Features.Brands.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;


//İş kuralları ve subclass type IoC
namespace Application.Features.Brands.Rules;

public class BrandBusinessRules:BaseBusinessRules
{
    private readonly IBrandRepository _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }
    //tekrar etmesin diye
    public async Task BrandNameCannotBeDuplicatedWhenInserted(string name)
    {
        Brand? result = await _brandRepository.GetAsync(predicate: b=>b.Name.ToLower()==name.ToLower());

        if (result!=null)
        {
            throw new BusinessException(BrandsMessages.BrandNameExists);
        }
    }
}