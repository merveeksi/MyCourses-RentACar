using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Request;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;

//kullanıcının bize gönderdiği sayfa bilgileri
public class GetListBrandQuery : IRequest<GetListResponse<GetListBrandListItemDto>>//, ICachableRequest, ILoggableRequest
{
    public PageRequest PageRequest { get; set; } //kullanıcının bize gönderdiği sayfa bilgileri

    // public string CacheKey => $"GetListBrandQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    //
    // public bool BypassCache {get;}
    // public TimeSpan? SlidingExpiration { get; }
    //
    // public string? CacheGroupKey => "GetBrands";
    //
    public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandListItemDto>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
    
        public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }
    
        public async Task<GetListResponse<GetListBrandListItemDto>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {
            Paginate<Brand> brands =  await _brandRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken : cancellationToken,
                withDeleted:true
            );
    
            GetListResponse<GetListBrandListItemDto> response = _mapper.Map<GetListResponse<GetListBrandListItemDto>>(brands);
            return response;
    
        }
    }
}